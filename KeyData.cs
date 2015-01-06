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
        private string useCode = "";   // ご利用コード
        public KeyData(int index, string keyString, string clientName, string useCode)
        {
            setKeyData(index, keyString,clientName, useCode);
        }
        public void setKeyData(int index, string keyString, string clientName, string useCode)
        {
            this.key = keyString;
            this.index = index;
            this.clientName = clientName;
            this.useCode = useCode;
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
        public string getUseCode()
        {
            return useCode;
        }
        public void setUseCode(string useCode)
        {
            this.useCode = useCode;
        }
    }
}
