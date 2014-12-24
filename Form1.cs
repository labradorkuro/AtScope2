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
        bool isDirty = false;   // 変更フラグ
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
            initListView();
        }
        /// <summary>
        /// 終了ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (isDirty)
            {
                // 変更あり
                if (MessageBox.Show("保存されていない変更があります。保存しないで終了しますか？", "確認", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
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
            isDirty = true;
            // 保存ボタン有効化
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
            addListViewItem(last_index + 1, kd);
            // 保存ボタン有効化
            this.toolStripButtonSave.Enabled = true;
            isDirty = true;
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
                    string line = (i + 1).ToString() + "," + kd.getIndex().ToString() + "," + kd.getKey() + "," + kd.getClientName();
                    sr.WriteLine(line);
                }
                sr.Close();
                // 保存ボタン有効化
                this.toolStripButtonSave.Enabled = false;
                isDirty = false;
            }
        }
        /// <summary>
        /// キー情報ファイルの読込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Text Files(.txt)|*.txt";
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fn = this.openFileDialog1.FileName;
                StreamReader sr = new StreamReader(fn, Encoding.Default);
                // ５１２文字のキー文字列を読む
                string keyStr = sr.ReadLine();
                this.textBoxGenerateStrings.Text = keyStr;
                keyGen.setGenerateKeyString(keyStr);
                this.keyList.Clear();
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
                createListView();
            }

        }
        private void initListView()
        {
            this.listViewLicenseKeyList.Clear();
            this.listViewLicenseKeyList.Items.Clear();
            this.listViewLicenseKeyList.Columns.Clear();
            this.listViewLicenseKeyList.View = View.Details;
            this.listViewLicenseKeyList.FullRowSelect = true;
            this.listViewLicenseKeyList.GridLines = true;
            this.listViewLicenseKeyList.CheckBoxes = false;
            this.listViewLicenseKeyList.Sorting = SortOrder.Descending;

            this.listViewLicenseKeyList.Columns.Add("番号", 60, HorizontalAlignment.Center);
            this.listViewLicenseKeyList.Columns.Add("Index", 60, HorizontalAlignment.Center);
            this.listViewLicenseKeyList.Columns.Add("Key", 200, HorizontalAlignment.Center);
            this.listViewLicenseKeyList.Columns.Add("ライセンス先名称", 200, HorizontalAlignment.Center);
        }
        private void createListView()
        {
            this.listViewLicenseKeyList.Items.Clear();
            for (int i = 0; i < keyList.getLength(); i++)
            {
                KeyData kd = keyList.getKeyData(i);
                addListViewItem(i + 1, kd);
            }
        }
        private void addListViewItem(int no,KeyData kd)
        {
            ListViewItem item = new ListViewItem();
            string n = no.ToString();
            item.Text = n;
            item.SubItems.Add(kd.getIndex().ToString());
            item.SubItems.Add(kd.getKey());
            item.SubItems.Add(kd.getClientName());
            this.listViewLicenseKeyList.Items.Add(item);
        }
        /// <summary>
        /// ライセンスキーリストの選択イベント処理
        /// 選択した内容をフォームに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewLicenseKeyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewLicenseKeyList.SelectedItems.Count > 0)
            {
                ListViewItem item = this.listViewLicenseKeyList.SelectedItems[0];
                // インデックス
                this.textBoxKeyIndex.Text = item.SubItems[1].Text;
                // キー
                this.textBoxLicenseKeyEncrypt.Text = item.SubItems[2].Text;
                // ライセンス先名称
                this.textBoxLicenseClientName.Text = item.SubItems[3].Text;
                // 暗号化された開始日付とエディションを復号化して表示する
                string um = keyGen.unmaskLast8(this.textBoxLicenseKeyEncrypt.Text);
                string ym = "20" + um.Substring(0, 2) + "/" + um.Substring(2,2);
                string edition = um.Substring(4, 4);
                this.comboBoxEditionList.SelectedIndex = keyGen.getEditionIndex(edition);
                this.dateTimePickerStartDate.Text = ym;
                this.buttonLicenseKeyIssue.Enabled = false;
            }
        }
    }
}
