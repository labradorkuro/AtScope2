using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseGenerator
{
    /// <summary>
    /// キーデータクラス
    /// </summary>
    class KeyData
    {
        private string key = "";        // キー文字列
        private int index = 0;          // ５１２文字のキー文字列から取得した位置
        private string clientName = ""; // ライセンス先
        public KeyData(int index, string keyString, string clientName)
        {
            setKeyData(index, keyString,clientName);
        }
        public void setKeyData(int index, string keyString, string clientName)
        {
            this.key = keyString;
            this.index = index;
            this.clientName = clientName;
        }
        public int getIndex()
        {
            return index;
        }
        public string getKey()
        {
            return key;
        }
        public string getClientName()
        {
            return clientName;
        }
    }
}
