namespace SexTeaERP
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.errInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // errInfo
            // 
            this.errInfo.ContainerControl = this;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(359, 208);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(6);
            this.txtPwd.MaxLength = 20;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(282, 35);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.Location = new System.Drawing.Point(359, 156);
            this.txtCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(282, 35);
            this.txtCode.TabIndex = 0;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(209, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户名称：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(209, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "用户密码：";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginBtn.ForeColor = System.Drawing.Color.Cyan;
            this.loginBtn.Location = new System.Drawing.Point(213, 295);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(123, 49);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "登录";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.Transparent;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QuitBtn.ForeColor = System.Drawing.Color.Red;
            this.QuitBtn.Location = new System.Drawing.Point(518, 295);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(123, 49);
            this.QuitBtn.TabIndex = 10;
            this.QuitBtn.Text = "退出";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Transparent;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetBtn.ForeColor = System.Drawing.Color.Lime;
            this.ResetBtn.Location = new System.Drawing.Point(359, 295);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(123, 49);
            this.ResetBtn.TabIndex = 11;
            this.ResetBtn.Text = "重置";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 538);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SexTeaERP管理系统------登录窗口";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errInfo;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}

