namespace SexTeaERP.Base
{
    partial class FormBSAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBSAccount));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolreflush = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labCondation = new System.Windows.Forms.ToolStripLabel();
            this.cbxCondition = new System.Windows.Forms.ToolStripComboBox();
            this.txtKeyWord = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtOK = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccountInfo = new System.Windows.Forms.DataGridView();
            this.AccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccSubject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AccMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccMoney = new System.Windows.Forms.TextBox();
            this.cbxAccSubject = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBankAccount = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolCancel,
            this.toolAdd,
            this.toolAmend,
            this.toolDelete,
            this.toolreflush,
            this.toolStripSeparator1,
            this.labCondation,
            this.cbxCondition,
            this.txtKeyWord,
            this.toolStripSeparator2,
            this.txtOK,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1374, 41);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Enabled = false;
            this.toolSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(82, 35);
            this.toolSave.Tag = "1";
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Enabled = false;
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(82, 44);
            this.toolCancel.Tag = "2";
            this.toolCancel.Text = "取消";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Enabled = false;
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(82, 44);
            this.toolAdd.Tag = "3";
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolAmend
            // 
            this.toolAmend.Enabled = false;
            this.toolAmend.Image = ((System.Drawing.Image)(resources.GetObject("toolAmend.Image")));
            this.toolAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmend.Name = "toolAmend";
            this.toolAmend.Size = new System.Drawing.Size(82, 44);
            this.toolAmend.Tag = "4";
            this.toolAmend.Text = "修改";
            this.toolAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Enabled = false;
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(82, 44);
            this.toolDelete.Tag = "5";
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // toolreflush
            // 
            this.toolreflush.Image = ((System.Drawing.Image)(resources.GetObject("toolreflush.Image")));
            this.toolreflush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolreflush.Name = "toolreflush";
            this.toolreflush.Size = new System.Drawing.Size(82, 44);
            this.toolreflush.Text = "刷新";
            this.toolreflush.Click += new System.EventHandler(this.toolreflush_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // labCondation
            // 
            this.labCondation.Name = "labCondation";
            this.labCondation.Size = new System.Drawing.Size(116, 44);
            this.labCondation.Text = "查询条件:";
            // 
            // cbxCondition
            // 
            this.cbxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(90, 50);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(100, 50);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // txtOK
            // 
            this.txtOK.Image = ((System.Drawing.Image)(resources.GetObject("txtOK.Image")));
            this.txtOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtOK.Name = "txtOK";
            this.txtOK.Size = new System.Drawing.Size(82, 44);
            this.txtOK.Tag = "6";
            this.txtOK.Text = "查找";
            this.txtOK.Click += new System.EventHandler(this.txtOK_Click);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(82, 44);
            this.toolExit.Tag = "7";
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccountInfo);
            this.groupBox2.Location = new System.Drawing.Point(24, 294);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1326, 514);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "帐户记录";
            // 
            // dgvAccountInfo
            // 
            this.dgvAccountInfo.AllowUserToAddRows = false;
            this.dgvAccountInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountCode,
            this.AccountName,
            this.BankAccount,
            this.AccSubject,
            this.AccMoney});
            this.dgvAccountInfo.Location = new System.Drawing.Point(16, 30);
            this.dgvAccountInfo.Margin = new System.Windows.Forms.Padding(6);
            this.dgvAccountInfo.Name = "dgvAccountInfo";
            this.dgvAccountInfo.RowHeadersWidth = 82;
            this.dgvAccountInfo.RowTemplate.Height = 23;
            this.dgvAccountInfo.Size = new System.Drawing.Size(1298, 480);
            this.dgvAccountInfo.TabIndex = 0;
            this.dgvAccountInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountInfo_CellClick);
            // 
            // AccountCode
            // 
            this.AccountCode.DataPropertyName = "AccountCode";
            this.AccountCode.HeaderText = "账户编号";
            this.AccountCode.MinimumWidth = 10;
            this.AccountCode.Name = "AccountCode";
            this.AccountCode.ReadOnly = true;
            this.AccountCode.Width = 200;
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "AccountName";
            this.AccountName.HeaderText = "账户名称";
            this.AccountName.MinimumWidth = 10;
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            this.AccountName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AccountName.Width = 200;
            // 
            // BankAccount
            // 
            this.BankAccount.DataPropertyName = "BankAccount";
            this.BankAccount.HeaderText = "银行账号";
            this.BankAccount.MinimumWidth = 10;
            this.BankAccount.Name = "BankAccount";
            this.BankAccount.ReadOnly = true;
            this.BankAccount.Width = 200;
            // 
            // AccSubject
            // 
            this.AccSubject.DataPropertyName = "AccSubject";
            this.AccSubject.HeaderText = "会计科目";
            this.AccSubject.MinimumWidth = 10;
            this.AccSubject.Name = "AccSubject";
            this.AccSubject.ReadOnly = true;
            this.AccSubject.Width = 200;
            // 
            // AccMoney
            // 
            this.AccMoney.DataPropertyName = "AccMoney";
            this.AccMoney.HeaderText = "账户金额";
            this.AccMoney.MinimumWidth = 10;
            this.AccMoney.Name = "AccMoney";
            this.AccMoney.ReadOnly = true;
            this.AccMoney.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAccMoney);
            this.groupBox1.Controls.Add(this.cbxAccSubject);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBankAccount);
            this.groupBox1.Controls.Add(this.txtAccountName);
            this.groupBox1.Controls.Add(this.txtAccountCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1326, 224);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "帐户信息";
            // 
            // txtAccMoney
            // 
            this.txtAccMoney.Location = new System.Drawing.Point(522, 140);
            this.txtAccMoney.Margin = new System.Windows.Forms.Padding(6);
            this.txtAccMoney.MaxLength = 9;
            this.txtAccMoney.Name = "txtAccMoney";
            this.txtAccMoney.ReadOnly = true;
            this.txtAccMoney.Size = new System.Drawing.Size(248, 35);
            this.txtAccMoney.TabIndex = 14;
            this.txtAccMoney.Text = "0";
            this.txtAccMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAccMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccMoney_KeyPress);
            // 
            // cbxAccSubject
            // 
            this.cbxAccSubject.Enabled = false;
            this.cbxAccSubject.FormattingEnabled = true;
            this.cbxAccSubject.Location = new System.Drawing.Point(132, 140);
            this.cbxAccSubject.Margin = new System.Windows.Forms.Padding(6);
            this.cbxAccSubject.Name = "cbxAccSubject";
            this.cbxAccSubject.Size = new System.Drawing.Size(248, 32);
            this.cbxAccSubject.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "期初金额";
            // 
            // txtBankAccount
            // 
            this.txtBankAccount.Location = new System.Drawing.Point(900, 54);
            this.txtBankAccount.Margin = new System.Windows.Forms.Padding(6);
            this.txtBankAccount.MaxLength = 19;
            this.txtBankAccount.Name = "txtBankAccount";
            this.txtBankAccount.ReadOnly = true;
            this.txtBankAccount.Size = new System.Drawing.Size(410, 35);
            this.txtBankAccount.TabIndex = 10;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(522, 54);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(6);
            this.txtAccountName.MaxLength = 50;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(248, 35);
            this.txtAccountName.TabIndex = 9;
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.Location = new System.Drawing.Point(132, 54);
            this.txtAccountCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtAccountCode.MaxLength = 10;
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.ReadOnly = true;
            this.txtAccountCode.Size = new System.Drawing.Size(248, 35);
            this.txtAccountCode.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "会计科目";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "银行账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "账户名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户编号";
            // 
            // FormBSAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1374, 832);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormBSAccount";
            this.Text = "结算账户";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton toolreflush;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labCondation;
        private System.Windows.Forms.ToolStripComboBox cbxCondition;
        private System.Windows.Forms.ToolStripTextBox txtKeyWord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton txtOK;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccountInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBankAccount;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAccSubject;
        private System.Windows.Forms.TextBox txtAccMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankAccount;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccMoney;
    }
}