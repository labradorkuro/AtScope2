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
        private string key = "";                // キー文字列
        private int index = 0;                  // ５１２文字のキー文字列から取得した位置
        private string clientName = "";         // ライセンス先
        private string useCode = "";            // ご利用コード
        private string start_date = "";         // 開始年月
        private string start_edition = "";      // 開始時のエディション
        private string expire = "";             // 有効期限
        private string current_edition = "";    // 現在のエディション
        public KeyData(int index, string keyString, string clientName, string useCode, string start_date, string start_edition, string expire, string current_edition)
        {
            setKeyData(index, keyString,clientName, useCode, start_date, start_edition,expire,current_edition);
        }
        public void setKeyData(int index, string keyString, string clientName, string useCode, string start_date, string start_edition, string expire, string current_edition)
        {
            this.key = keyString;
            this.index = index;
            this.clientName = clientName;
            this.useCode = useCode;
            this.start_date = start_date;
            this.start_edition = start_edition;
            this.expire = expire;
            this.current_edition = current_edition;
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
        public string getStart_date()
        {
            return start_date;
        }
        public string getStart_edition()
        {
            return start_edition;
        }
        public void setExpire(string expire)
        {
            this.expire = expire;
        }
        public void setCurrent_edition(string edition)
        {
            this.current_edition = edition;
        }
        public string getExpire()
        {
            return expire;
        }
        public string getCurrent_edition()
        {
            return current_edition;
        }
    }
}
