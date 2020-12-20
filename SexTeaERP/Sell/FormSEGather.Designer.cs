namespace SexTeaERP.Sell
{
    partial class FormSEGather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSEGather));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolCheck = new System.Windows.Forms.ToolStripButton();
            this.toolUnCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labCondation = new System.Windows.Forms.ToolStripLabel();
            this.cbxCondition = new System.Windows.Forms.ToolStripComboBox();
            this.txtKeyWord = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtOK = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSEGatherInfo = new System.Windows.Forms.DataGridView();
            this.SEGatherCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEGatherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SEOutCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SEMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFlag = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cbxEmployeeCode = new System.Windows.Forms.ComboBox();
            this.cbxAccountCode = new System.Windows.Forms.ComboBox();
            this.txtSEMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpSEOutDate = new System.Windows.Forms.DateTimePicker();
            this.btnChoice = new System.Windows.Forms.Button();
            this.txtSEOutCode = new System.Windows.Forms.TextBox();
            this.cbxIsFlag = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCustomerCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOperatorCode = new System.Windows.Forms.ComboBox();
            this.dtpSEGatherDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSEGatherCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSEGatherInfo)).BeginInit();
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
            this.toolCheck,
            this.toolUnCheck,
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
            this.toolStrip1.TabIndex = 10;
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
            this.toolCancel.Size = new System.Drawing.Size(82, 35);
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
            this.toolAdd.Size = new System.Drawing.Size(82, 35);
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
            this.toolAmend.Size = new System.Drawing.Size(82, 35);
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
            this.toolDelete.Size = new System.Drawing.Size(82, 35);
            this.toolDelete.Tag = "5";
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // toolCheck
            // 
            this.toolCheck.Enabled = false;
            this.toolCheck.Image = ((System.Drawing.Image)(resources.GetObject("toolCheck.Image")));
            this.toolCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCheck.Name = "toolCheck";
            this.toolCheck.Size = new System.Drawing.Size(82, 35);
            this.toolCheck.Text = "审核";
            this.toolCheck.Click += new System.EventHandler(this.toolCheck_Click);
            // 
            // toolUnCheck
            // 
            this.toolUnCheck.Enabled = false;
            this.toolUnCheck.Image = ((System.Drawing.Image)(resources.GetObject("toolUnCheck.Image")));
            this.toolUnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUnCheck.Name = "toolUnCheck";
            this.toolUnCheck.Size = new System.Drawing.Size(82, 35);
            this.toolUnCheck.Text = "弃审";
            this.toolUnCheck.Click += new System.EventHandler(this.toolUnCheck_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // labCondation
            // 
            this.labCondation.Name = "labCondation";
            this.labCondation.Size = new System.Drawing.Size(116, 35);
            this.labCondation.Text = "查询条件:";
            // 
            // cbxCondition
            // 
            this.cbxCondition.DropDownWidth = 90;
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(75, 41);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(80, 41);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // txtOK
            // 
            this.txtOK.Image = ((System.Drawing.Image)(resources.GetObject("txtOK.Image")));
            this.txtOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtOK.Name = "txtOK";
            this.txtOK.Size = new System.Drawing.Size(82, 35);
            this.txtOK.Tag = "6";
            this.txtOK.Text = "查找";
            this.txtOK.Click += new System.EventHandler(this.txtOK_Click);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(82, 35);
            this.toolExit.Tag = "7";
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSEGatherInfo);
            this.groupBox2.Location = new System.Drawing.Point(16, 380);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1342, 434);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "销售收款单记录";
            // 
            // dgvSEGatherInfo
            // 
            this.dgvSEGatherInfo.AllowUserToAddRows = false;
            this.dgvSEGatherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSEGatherInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEGatherCode,
            this.SEGatherDate,
            this.OperatorCode,
            this.SEOutCode,
            this.SEOutDate,
            this.CustomerCode,
            this.SEMoney,
            this.AccountCode,
            this.EmployeeCode,
            this.Remark,
            this.IsFlag});
            this.dgvSEGatherInfo.Location = new System.Drawing.Point(16, 30);
            this.dgvSEGatherInfo.Margin = new System.Windows.Forms.Padding(6);
            this.dgvSEGatherInfo.Name = "dgvSEGatherInfo";
            this.dgvSEGatherInfo.RowHeadersWidth = 82;
            this.dgvSEGatherInfo.RowTemplate.Height = 23;
            this.dgvSEGatherInfo.Size = new System.Drawing.Size(1310, 388);
            this.dgvSEGatherInfo.TabIndex = 0;
            this.dgvSEGatherInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSEGatherInfo_CellClick);
            this.dgvSEGatherInfo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSEGatherInfo_DataError);
            // 
            // SEGatherCode
            // 
            this.SEGatherCode.DataPropertyName = "SEGatherCode";
            this.SEGatherCode.HeaderText = "单据编号";
            this.SEGatherCode.MinimumWidth = 10;
            this.SEGatherCode.Name = "SEGatherCode";
            this.SEGatherCode.ReadOnly = true;
            this.SEGatherCode.Width = 200;
            // 
            // SEGatherDate
            // 
            this.SEGatherDate.DataPropertyName = "SEGatherDate";
            this.SEGatherDate.HeaderText = "单据日期";
            this.SEGatherDate.MinimumWidth = 10;
            this.SEGatherDate.Name = "SEGatherDate";
            this.SEGatherDate.ReadOnly = true;
            this.SEGatherDate.Width = 200;
            // 
            // OperatorCode
            // 
            this.OperatorCode.DataPropertyName = "OperatorCode";
            this.OperatorCode.HeaderText = "操作员";
            this.OperatorCode.MinimumWidth = 10;
            this.OperatorCode.Name = "OperatorCode";
            this.OperatorCode.ReadOnly = true;
            this.OperatorCode.Width = 200;
            // 
            // SEOutCode
            // 
            this.SEOutCode.DataPropertyName = "SEOutCode";
            this.SEOutCode.HeaderText = "出库单号";
            this.SEOutCode.MinimumWidth = 10;
            this.SEOutCode.Name = "SEOutCode";
            this.SEOutCode.ReadOnly = true;
            this.SEOutCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SEOutCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SEOutCode.Width = 200;
            // 
            // SEOutDate
            // 
            this.SEOutDate.DataPropertyName = "SEOutDate";
            this.SEOutDate.HeaderText = "出库日期";
            this.SEOutDate.MinimumWidth = 10;
            this.SEOutDate.Name = "SEOutDate";
            this.SEOutDate.ReadOnly = true;
            this.SEOutDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SEOutDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SEOutDate.Width = 200;
            // 
            // CustomerCode
            // 
            this.CustomerCode.DataPropertyName = "CustomerCode";
            this.CustomerCode.HeaderText = "客    户";
            this.CustomerCode.MinimumWidth = 10;
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.ReadOnly = true;
            this.CustomerCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerCode.Width = 200;
            // 
            // SEMoney
            // 
            this.SEMoney.DataPropertyName = "SEMoney";
            this.SEMoney.HeaderText = "收款金额";
            this.SEMoney.MinimumWidth = 10;
            this.SEMoney.Name = "SEMoney";
            this.SEMoney.ReadOnly = true;
            this.SEMoney.Width = 200;
            // 
            // AccountCode
            // 
            this.AccountCode.DataPropertyName = "AccountCode";
            this.AccountCode.HeaderText = "结算账户";
            this.AccountCode.MinimumWidth = 10;
            this.AccountCode.Name = "AccountCode";
            this.AccountCode.ReadOnly = true;
            this.AccountCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AccountCode.Width = 200;
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "EmployeeCode";
            this.EmployeeCode.HeaderText = "收 款 人";
            this.EmployeeCode.MinimumWidth = 10;
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.ReadOnly = true;
            this.EmployeeCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmployeeCode.Width = 200;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.MinimumWidth = 10;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 200;
            // 
            // IsFlag
            // 
            this.IsFlag.DataPropertyName = "IsFlag";
            this.IsFlag.HeaderText = "审核状态";
            this.IsFlag.MinimumWidth = 10;
            this.IsFlag.Name = "IsFlag";
            this.IsFlag.ReadOnly = true;
            this.IsFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsFlag.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.cbxEmployeeCode);
            this.groupBox1.Controls.Add(this.cbxAccountCode);
            this.groupBox1.Controls.Add(this.txtSEMoney);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpSEOutDate);
            this.groupBox1.Controls.Add(this.btnChoice);
            this.groupBox1.Controls.Add(this.txtSEOutCode);
            this.groupBox1.Controls.Add(this.cbxIsFlag);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxCustomerCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxOperatorCode);
            this.groupBox1.Controls.Add(this.dtpSEGatherDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSEGatherCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1342, 320);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "销售收款单信息";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(144, 262);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(6);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(730, 35);
            this.txtRemark.TabIndex = 112;
            // 
            // cbxEmployeeCode
            // 
            this.cbxEmployeeCode.Enabled = false;
            this.cbxEmployeeCode.FormattingEnabled = true;
            this.cbxEmployeeCode.Location = new System.Drawing.Point(1060, 186);
            this.cbxEmployeeCode.Margin = new System.Windows.Forms.Padding(6);
            this.cbxEmployeeCode.Name = "cbxEmployeeCode";
            this.cbxEmployeeCode.Size = new System.Drawing.Size(248, 32);
            this.cbxEmployeeCode.TabIndex = 111;
            // 
            // cbxAccountCode
            // 
            this.cbxAccountCode.Enabled = false;
            this.cbxAccountCode.FormattingEnabled = true;
            this.cbxAccountCode.Location = new System.Drawing.Point(606, 186);
            this.cbxAccountCode.Margin = new System.Windows.Forms.Padding(6);
            this.cbxAccountCode.Name = "cbxAccountCode";
            this.cbxAccountCode.Size = new System.Drawing.Size(248, 32);
            this.cbxAccountCode.TabIndex = 110;
            // 
            // txtSEMoney
            // 
            this.txtSEMoney.Location = new System.Drawing.Point(144, 186);
            this.txtSEMoney.Margin = new System.Windows.Forms.Padding(6);
            this.txtSEMoney.MaxLength = 9;
            this.txtSEMoney.Name = "txtSEMoney";
            this.txtSEMoney.ReadOnly = true;
            this.txtSEMoney.Size = new System.Drawing.Size(248, 35);
            this.txtSEMoney.TabIndex = 109;
            this.txtSEMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSEMoney_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 108;
            this.label7.Text = "出库日期";
            // 
            // dtpSEOutDate
            // 
            this.dtpSEOutDate.Enabled = false;
            this.dtpSEOutDate.Location = new System.Drawing.Point(606, 108);
            this.dtpSEOutDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpSEOutDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpSEOutDate.Name = "dtpSEOutDate";
            this.dtpSEOutDate.Size = new System.Drawing.Size(248, 35);
            this.dtpSEOutDate.TabIndex = 107;
            // 
            // btnChoice
            // 
            this.btnChoice.Enabled = false;
            this.btnChoice.Font = new System.Drawing.Font("宋体", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoice.Location = new System.Drawing.Point(396, 108);
            this.btnChoice.Margin = new System.Windows.Forms.Padding(6);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(40, 40);
            this.btnChoice.TabIndex = 106;
            this.btnChoice.Text = "...";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // txtSEOutCode
            // 
            this.txtSEOutCode.Location = new System.Drawing.Point(144, 108);
            this.txtSEOutCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtSEOutCode.MaxLength = 10;
            this.txtSEOutCode.Name = "txtSEOutCode";
            this.txtSEOutCode.ReadOnly = true;
            this.txtSEOutCode.Size = new System.Drawing.Size(248, 35);
            this.txtSEOutCode.TabIndex = 105;
            // 
            // cbxIsFlag
            // 
            this.cbxIsFlag.Enabled = false;
            this.cbxIsFlag.FormattingEnabled = true;
            this.cbxIsFlag.Location = new System.Drawing.Point(1060, 262);
            this.cbxIsFlag.Margin = new System.Windows.Forms.Padding(6);
            this.cbxIsFlag.Name = "cbxIsFlag";
            this.cbxIsFlag.Size = new System.Drawing.Size(248, 32);
            this.cbxIsFlag.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(942, 270);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 101;
            this.label12.Text = "审核状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 99;
            this.label10.Text = "出库单号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 270);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 95;
            this.label8.Text = "备    注";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 93;
            this.label5.Text = "收款金额";
            // 
            // cbxCustomerCode
            // 
            this.cbxCustomerCode.Enabled = false;
            this.cbxCustomerCode.FormattingEnabled = true;
            this.cbxCustomerCode.Location = new System.Drawing.Point(1060, 108);
            this.cbxCustomerCode.Margin = new System.Windows.Forms.Padding(6);
            this.cbxCustomerCode.Name = "cbxCustomerCode";
            this.cbxCustomerCode.Size = new System.Drawing.Size(248, 32);
            this.cbxCustomerCode.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(942, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 90;
            this.label6.Text = "收 款 人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 89;
            this.label2.Text = "结算账户";
            // 
            // cbxOperatorCode
            // 
            this.cbxOperatorCode.Enabled = false;
            this.cbxOperatorCode.FormattingEnabled = true;
            this.cbxOperatorCode.Location = new System.Drawing.Point(1060, 30);
            this.cbxOperatorCode.Margin = new System.Windows.Forms.Padding(6);
            this.cbxOperatorCode.Name = "cbxOperatorCode";
            this.cbxOperatorCode.Size = new System.Drawing.Size(248, 32);
            this.cbxOperatorCode.TabIndex = 82;
            // 
            // dtpSEGatherDate
            // 
            this.dtpSEGatherDate.Enabled = false;
            this.dtpSEGatherDate.Location = new System.Drawing.Point(606, 30);
            this.dtpSEGatherDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpSEGatherDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpSEGatherDate.Name = "dtpSEGatherDate";
            this.dtpSEGatherDate.Size = new System.Drawing.Size(248, 35);
            this.dtpSEGatherDate.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(942, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 70;
            this.label3.Text = "操 作 员";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 77;
            this.label9.Text = "单据日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(942, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 71;
            this.label4.Text = "客    户";
            // 
            // txtSEGatherCode
            // 
            this.txtSEGatherCode.Location = new System.Drawing.Point(144, 30);
            this.txtSEGatherCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtSEGatherCode.MaxLength = 10;
            this.txtSEGatherCode.Name = "txtSEGatherCode";
            this.txtSEGatherCode.ReadOnly = true;
            this.txtSEGatherCode.Size = new System.Drawing.Size(248, 35);
            this.txtSEGatherCode.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 69;
            this.label1.Text = "单据编号";
            // 
            // FormSEGather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1374, 832);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormSEGather";
            this.Text = "销售收款单";
            this.Load += new System.EventHandler(this.FormSEGather_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSEGatherInfo)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolCheck;
        private System.Windows.Forms.ToolStripButton toolUnCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labCondation;
        private System.Windows.Forms.ToolStripComboBox cbxCondition;
        private System.Windows.Forms.ToolStripTextBox txtKeyWord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton txtOK;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSEGatherInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtSEMoney;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtpSEOutDate;
        private System.Windows.Forms.Button btnChoice;
        public System.Windows.Forms.TextBox txtSEOutCode;
        private System.Windows.Forms.ComboBox cbxIsFlag;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbxCustomerCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxOperatorCode;
        private System.Windows.Forms.DateTimePicker dtpSEGatherDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSEGatherCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEGatherCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEGatherDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEOutCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEOutDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEMoney;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccountCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewComboBoxColumn IsFlag;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cbxEmployeeCode;
        private System.Windows.Forms.ComboBox cbxAccountCode;
    }
}