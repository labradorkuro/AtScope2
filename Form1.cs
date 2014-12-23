using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LicenseGenerator
{
    public partial class Form1 : Form
    {
        private KeyGenerator keyGen = new KeyGenerator();   // キー文字列処理クラス
        private KeyList keyList = new KeyList();            // ライセンスキーのリスト
        /// <summary>
        /// フォームの初期化処理
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.comboBoxEditionList.SelectedIndex = 0;
            this.buttonKeyStringGet.Enabled = false;
            this.buttonLicenseKeyIssue.Enabled = false;
            this.buttonDescrypt.Enabled = false;
            this.toolStripButtonSave.Enabled = false;
        }
        /// <summary>
        /// 終了ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// キー文字列の生成
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            string key = keyGen.createKeyStrings();
            this.textBoxGenerateStrings.Text = key;
            this.buttonKeyStringGet.Enabled = true;
            this.toolStripButtonSave.Enabled = true;
        }
        /// <summary>
        /// 生成された文字列からライセンスキー用に8文字抜き出す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKeyStringGet_Click(object sender, EventArgs e)
        {
            // ライセンスキーリストの現在の個数＝最終取得位置を取得する
            int last_index = keyList.getLength();
            // キー文字列から4文字抜き出す
            string key = this.textBoxGenerateStrings.Text.Substring(last_index, 4);
            // キー文字列から4文字抜き出す
            key += "-" + this.textBoxGenerateStrings.Text.Substring(last_index + 4, 4);
            // キー文字列を表示する
            this.textBoxKey1.Text = key;
            // 文字列取得位置を表示する
            this.textBoxKeyIndex.Text = last_index.ToString();
            this.textBoxLicenseKey.Text = "";
            this.textBoxLicenseKeyEncrypt.Text = "";
            this.buttonLicenseKeyIssue.Enabled = true;
        }
        /// <summary>
        /// ライセンスキー発行処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLicenseKeyIssue_Click(object sender, EventArgs e)
        {
            // エディションの選択値を取得
            int edition = this.comboBoxEditionList.SelectedIndex;
            // 利用開始年月を取得
            string ym = this.dateTimePickerStartDate.Text;

            string[] licenseKeys = keyGen.getLicenseString(this.textBoxKey1.Text, ym, edition);
            string licenseKey = licenseKeys[0];
            // ライセンスキーの表示
            this.textBoxLicenseKey.Text = licenseKey;
            // 暗号化後のライセンスキーの表示
            string outStr = licenseKeys[1];
            string license = this.textBoxKey1.Text + "-" + outStr.Substring(0, 4) + "-" + outStr.Substring(4, 4);
            this.textBoxLicenseKeyEncrypt.Text = license;
            this.buttonDescrypt.Enabled = true;
            // ライセンスキーリストの現在の個数＝最終取得位置を取得する
            int last_index = keyList.getLength();
            // キー情報をリストに追加する
            KeyData kd = new KeyData(last_index, license,this.textBoxLicenseClientName.Text);
            keyList.addKeyData(kd);
            // 保存ボタン有効化
            this.toolStripButtonSave.Enabled = true;
        }

        /// <summary>
        /// 暗号化したライセンスキーの複合テスト
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // test
            string um = keyGen.unmaskLast8(this.textBoxLicenseKeyEncrypt.Text);
            this.textBoxLicenseKeyEncrypt.Text = um;
            this.buttonDescrypt.Enabled = false;
        }
        /// <summary>
        /// キー情報の保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "Text Files(.txt)|*.txt";
            if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fn = this.saveFileDialog1.FileName;
                StreamWriter sr = new StreamWriter((new FileStream(fn, FileMode.Create)), Encoding.Default);
                // ５１２文字のキー文字列を書く
                sr.WriteLine(this.textBoxGenerateStrings.Text);
                sr.WriteLine("");
                for (int i = 0; i < keyList.getLength(); i++)
                {
                    KeyData kd = keyList.getKeyData(i);
                    string line = (i + 1).ToString() + "," + kd.getIndex().ToString() + "," + kd.getKey() + "," + this.textBoxLicenseClientName.Text;
                    sr.WriteLine(line);
                }
                sr.Close();

            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Text Files(.txt)|*.txt";
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fn = this.openFileDialog1.FileName;
                StreamReader sr = new StreamReader(fn, Encoding.Default);
                // ５１２文字のキー文字列を読む
                this.textBoxGenerateStrings.Text = sr.ReadLine();
                sr.ReadLine();
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split(new char[] { ',' });
                    KeyData kd = new KeyData(int.Parse(s[1]), s[2], s[3]);
                    keyList.addKeyData(kd);
                }
                sr.Close();
                this.buttonKeyStringGet.Enabled = true;
            }

        }
    }
}
