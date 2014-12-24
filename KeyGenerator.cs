using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
namespace LicenseGenerator
{
    public class KeyGenerator
    {
        private string[] editions = new string[] {"STDD","MANA","ARCH" };
        private string keySeedString = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string generateString = "";
        public string createKeyStrings()
        {
            string result = "";
            Random rnd = new Random();
            for (int i = 0; i < 512; i++)
            {
                int r = rnd.Next(36);
                result += keySeedString[r];
            }
            generateString = result;
            return result;
        }
        public void setGenerateKeyString(string key)
        {
            this.generateString = key;
        }
        public string getEditionString(int index)
        {
            return this.editions[index];
        }
        /// <summary>
        /// エディション文字列からそのインデックスを取得する
        /// </summary>
        /// <param name="edition"></param>
        /// <returns></returns>
        public int getEditionIndex(string edition)
        {
            for (int i = 0; i < editions.Length; i++)
            {
                if (edition.Equals(editions[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// ライセンスキー文字列の生成
        /// </summary>
        /// <param name="key"></param>
        /// <param name="startDate"></param>
        /// <param name="edition"></param>
        /// <returns></returns>
        public string[] getLicenseString(string key, string startDate, int edition)
        {
            string yymm = startDate.Substring(2, 2) + startDate.Substring(5, 2);
            // エディションを表す文字列を取得する
            string editionString = getEditionString(edition);
            // キー文字列＋開始年月＋エディション文字列でライセンスキーを作る
            string licensekey =  key + "-" + yymm + "-" + editionString;
            // 後半8文字を前半8文字を使って暗号化する
            string key0 = key.Substring(0, 4) + key.Substring(5, 4);
            string last8 = yymm + editionString;
            string mask = maskLast8(key0, last8);
            return new string[] { licensekey, mask };
        }
        /// <summary>
        /// ライセンスキーの暗号化
        /// 前の8文字を使って後ろの8文字を暗号化する
        /// </summary>
        /// <param name="key"></param>
        /// <param name="last8"></param>
        /// <returns></returns>
        public string maskLast8(string key, string last8)
        {
            string result = "";
            for (int i = 0; i < 8; i++)
            {
                // キーの前半８文字から1文字取得
                byte val1 = Convert.ToByte(key[i]);
                // キーの後半８文字から1文字取得
                byte val2 = Convert.ToByte(last8[i]);
                // 後半文字のインデックスを取得する
                int idx1 = keySeedString.IndexOf(last8[i]);
                // 前半文字のインデックスを取得する
                int idx2 = keySeedString.IndexOf(key[i]);
                // 後半の文字を前半文字のインデックス分後ろへずらす
                int idx = idx1 + idx2;
                if (idx >= 36)
                {
                    // 最後へ達したら前へ戻る
                    idx -= 36;
                }
                // 求めたインデックスから文字を取得する
                result += keySeedString[idx];
            }
            return result;
        }

        /// <summary>
        /// 暗号化した文字列をもとに戻す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="mask"></param>
        /// <returns></returns>
        public string unmaskLast8(string keyString)
        {
            string result = "";
            string[] s = keyString.Split(new char[] { '-' });
            string key = s[0] + s[1];
            string mask = s[2] + s[3];
            for (int i = 0; i < 8; i++)
            {
                // 後半8文字のインデックスを取得する
                int idx1 = keySeedString.IndexOf(mask[i]);
                // 前半8文字のインデックスを取得する
                int idx2 = keySeedString.IndexOf(key[i]);
                // 後半文字のインデックスに前半文字のインデックスを加算してあるので減算する
                int idx = idx1 - idx2;
                if (idx < 0)
                {
                    // 負の値になった時は戻す
                    idx += 36;
                }
                result += keySeedString[idx];
            }
            return result;
        }
    }
}
