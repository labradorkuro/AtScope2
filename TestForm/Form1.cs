using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtScopeLicense;
namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = this.textBox1.Text;
            LicenseCheck lc = new LicenseCheck();
            int rc = lc.checkProductLicense();
            if (rc == 0)
            {
                MessageBox.Show("OK","キーチェック",MessageBoxButtons.OK);
            }
            else if (rc == -1)
            {
                MessageBox.Show("NG", "キーチェック", MessageBoxButtons.OK);

            }
            else if (rc == -2)
            {
                MessageBox.Show("CANCEL", "キーチェック", MessageBoxButtons.OK);

            }
        }
    }
}
