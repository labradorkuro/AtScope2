namespace LicenseGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "1",
            "aaaa"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxGenerateStrings = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerateKey = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKeyString = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddKeyList = new System.Windows.Forms.Button();
            this.buttonSelectKeyList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonKeyStringGet = new System.Windows.Forms.Button();
            this.textBoxKey1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKeyIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLicenseClientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEditionList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonLicenseKeyIssue = new System.Windows.Forms.Button();
            this.textBoxLicenseKey = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxLicenseKeyEncrypt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDescrypt = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonSelectKeyList);
            this.panel1.Controls.Add(this.buttonAddKeyList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.buttonGenerateKey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxGenerateStrings);
            this.panel1.Location = new System.Drawing.Point(13, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 253);
            this.panel1.TabIndex = 0;
            // 
            // textBoxGenerateStrings
            // 
            this.textBoxGenerateStrings.Location = new System.Drawing.Point(32, 67);
            this.textBoxGenerateStrings.Multiline = true;
            this.textBoxGenerateStrings.Name = "textBoxGenerateStrings";
            this.textBoxGenerateStrings.ReadOnly = true;
            this.textBoxGenerateStrings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGenerateStrings.Size = new System.Drawing.Size(332, 171);
            this.textBoxGenerateStrings.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "キー文字列";
            // 
            // buttonGenerateKey
            // 
            this.buttonGenerateKey.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGenerateKey.Location = new System.Drawing.Point(168, 9);
            this.buttonGenerateKey.Name = "buttonGenerateKey";
            this.buttonGenerateKey.Size = new System.Drawing.Size(196, 52);
            this.buttonGenerateKey.TabIndex = 2;
            this.buttonGenerateKey.Text = "キー文字列生成";
            this.buttonGenerateKey.UseVisualStyleBackColor = true;
            this.buttonGenerateKey.Click += new System.EventHandler(this.buttonGenerateKey_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNo,
            this.columnKeyString});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(560, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(321, 171);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnNo
            // 
            this.columnNo.Text = "No";
            this.columnNo.Width = 40;
            // 
            // columnKeyString
            // 
            this.columnKeyString.Text = "キー文字列";
            this.columnKeyString.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(441, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "キーリスト";
            // 
            // buttonAddKeyList
            // 
            this.buttonAddKeyList.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAddKeyList.Location = new System.Drawing.Point(402, 67);
            this.buttonAddKeyList.Name = "buttonAddKeyList";
            this.buttonAddKeyList.Size = new System.Drawing.Size(124, 52);
            this.buttonAddKeyList.TabIndex = 5;
            this.buttonAddKeyList.Text = "追加ー＞";
            this.buttonAddKeyList.UseVisualStyleBackColor = true;
            // 
            // buttonSelectKeyList
            // 
            this.buttonSelectKeyList.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSelectKeyList.Location = new System.Drawing.Point(402, 143);
            this.buttonSelectKeyList.Name = "buttonSelectKeyList";
            this.buttonSelectKeyList.Size = new System.Drawing.Size(124, 52);
            this.buttonSelectKeyList.TabIndex = 6;
            this.buttonSelectKeyList.Text = "＜－選択";
            this.buttonSelectKeyList.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonDescrypt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxLicenseKeyEncrypt);
            this.panel2.Controls.Add(this.textBoxLicenseKey);
            this.panel2.Controls.Add(this.buttonLicenseKeyIssue);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBoxEditionList);
            this.panel2.Controls.Add(this.dateTimePickerStartDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxLicenseClientName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxKeyIndex);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxKey1);
            this.panel2.Controls.Add(this.buttonKeyStringGet);
            this.panel2.Location = new System.Drawing.Point(13, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 225);
            this.panel2.TabIndex = 1;
            // 
            // buttonKeyStringGet
            // 
            this.buttonKeyStringGet.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonKeyStringGet.Location = new System.Drawing.Point(32, 14);
            this.buttonKeyStringGet.Name = "buttonKeyStringGet";
            this.buttonKeyStringGet.Size = new System.Drawing.Size(156, 39);
            this.buttonKeyStringGet.TabIndex = 3;
            this.buttonKeyStringGet.Text = "キー文字取得";
            this.buttonKeyStringGet.UseVisualStyleBackColor = true;
            this.buttonKeyStringGet.Click += new System.EventHandler(this.buttonKeyStringGet_Click);
            // 
            // textBoxKey1
            // 
            this.textBoxKey1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxKey1.Location = new System.Drawing.Point(270, 22);
            this.textBoxKey1.Name = "textBoxKey1";
            this.textBoxKey1.ReadOnly = true;
            this.textBoxKey1.Size = new System.Drawing.Size(147, 27);
            this.textBoxKey1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(441, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "インデックス";
            // 
            // textBoxKeyIndex
            // 
            this.textBoxKeyIndex.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxKeyIndex.Location = new System.Drawing.Point(560, 22);
            this.textBoxKeyIndex.Name = "textBoxKeyIndex";
            this.textBoxKeyIndex.ReadOnly = true;
            this.textBoxKeyIndex.Size = new System.Drawing.Size(100, 27);
            this.textBoxKeyIndex.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(204, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "キー";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(27, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "ライセンス先名称";
            // 
            // textBoxLicenseClientName
            // 
            this.textBoxLicenseClientName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxLicenseClientName.Location = new System.Drawing.Point(187, 70);
            this.textBoxLicenseClientName.Name = "textBoxLicenseClientName";
            this.textBoxLicenseClientName.Size = new System.Drawing.Size(429, 27);
            this.textBoxLicenseClientName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(72, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "開始年月";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CalendarFont = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerStartDate.CustomFormat = "yyyy/MM";
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(187, 105);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 33);
            this.dateTimePickerStartDate.TabIndex = 11;
            this.dateTimePickerStartDate.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // comboBoxEditionList
            // 
            this.comboBoxEditionList.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxEditionList.FormattingEnabled = true;
            this.comboBoxEditionList.Items.AddRange(new object[] {
            "Standard版",
            "Manager版",
            "Archtect版"});
            this.comboBoxEditionList.Location = new System.Drawing.Point(515, 108);
            this.comboBoxEditionList.MaxDropDownItems = 3;
            this.comboBoxEditionList.Name = "comboBoxEditionList";
            this.comboBoxEditionList.Size = new System.Drawing.Size(212, 33);
            this.comboBoxEditionList.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(414, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "エディション";
            // 
            // buttonLicenseKeyIssue
            // 
            this.buttonLicenseKeyIssue.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonLicenseKeyIssue.Location = new System.Drawing.Point(32, 155);
            this.buttonLicenseKeyIssue.Name = "buttonLicenseKeyIssue";
            this.buttonLicenseKeyIssue.Size = new System.Drawing.Size(194, 52);
            this.buttonLicenseKeyIssue.TabIndex = 14;
            this.buttonLicenseKeyIssue.Text = "ライセンスキー発行";
            this.buttonLicenseKeyIssue.UseVisualStyleBackColor = true;
            this.buttonLicenseKeyIssue.Click += new System.EventHandler(this.buttonLicenseKeyIssue_Click);
            // 
            // textBoxLicenseKey
            // 
            this.textBoxLicenseKey.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxLicenseKey.Location = new System.Drawing.Point(246, 170);
            this.textBoxLicenseKey.Name = "textBoxLicenseKey";
            this.textBoxLicenseKey.ReadOnly = true;
            this.textBoxLicenseKey.Size = new System.Drawing.Size(263, 27);
            this.textBoxLicenseKey.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.listView2);
            this.panel3.Location = new System.Drawing.Point(12, 527);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(915, 170);
            this.panel3.TabIndex = 2;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(21, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(381, 115);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(12, 703);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 51);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "終了";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLicenseKeyEncrypt
            // 
            this.textBoxLicenseKeyEncrypt.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxLicenseKeyEncrypt.Location = new System.Drawing.Point(618, 170);
            this.textBoxLicenseKeyEncrypt.Name = "textBoxLicenseKeyEncrypt";
            this.textBoxLicenseKeyEncrypt.ReadOnly = true;
            this.textBoxLicenseKeyEncrypt.Size = new System.Drawing.Size(263, 27);
            this.textBoxLicenseKeyEncrypt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(534, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "暗号化";
            // 
            // buttonDescrypt
            // 
            this.buttonDescrypt.Location = new System.Drawing.Point(754, 49);
            this.buttonDescrypt.Name = "buttonDescrypt";
            this.buttonDescrypt.Size = new System.Drawing.Size(115, 62);
            this.buttonDescrypt.TabIndex = 18;
            this.buttonDescrypt.Text = "複合テスト";
            this.buttonDescrypt.UseVisualStyleBackColor = true;
            this.buttonDescrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(940, 26);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(36, 23);
            this.toolStripButtonOpen.Text = "開く";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(43, 23);
            this.toolStripButtonSave.Text = "保存";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 758);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "AtScopeライセンスキー発行ユーティリティ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnNo;
        private System.Windows.Forms.ColumnHeader columnKeyString;
        private System.Windows.Forms.Button buttonGenerateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGenerateStrings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelectKeyList;
        private System.Windows.Forms.Button buttonAddKeyList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxEditionList;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLicenseClientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKeyIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKey1;
        private System.Windows.Forms.Button buttonKeyStringGet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLicenseKey;
        private System.Windows.Forms.Button buttonLicenseKeyIssue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLicenseKeyEncrypt;
        private System.Windows.Forms.Button buttonDescrypt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

