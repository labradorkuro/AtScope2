using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseGenerator
{
    /// <summary>
    /// キーリスト
    /// </summary>
    class KeyList
    {
        private ArrayList keyList = new ArrayList();

        public void addKeyData(KeyData kd)
        {
            this.keyList.Add(kd);
        }
        public int getLength()
        {
            return keyList.Count;
        }
        public KeyData getKeyData(int index)
        {
            if (index <= this.keyList.Count)
            {
                return (KeyData)this.keyList[index];
            }
            return null;
        }
    }
}
