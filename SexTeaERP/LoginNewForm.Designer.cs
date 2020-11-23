namespace SexTeaERP
{
    partial class LoginNewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginNewForm));
            this.LoginSkBtns = new CCWin.SkinControl.SkinButton();
            this.wtbUid = new CCWin.SkinControl.SkinWaterTextBox();
            this.QuitSkBtn = new CCWin.SkinControl.SkinButton();
            this.ResetSkBtn = new CCWin.SkinControl.SkinButton();
            this.wtbPwd = new CCWin.SkinControl.SkinWaterTextBox();
            this.errorInfo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginSkBtns
            // 
            this.LoginSkBtns.BackColor = System.Drawing.Color.Transparent;
            this.LoginSkBtns.BaseColor = System.Drawing.Color.Black;
            this.LoginSkBtns.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.LoginSkBtns.DownBack = null;
            this.LoginSkBtns.ForeColorSuit = true;
            this.LoginSkBtns.Location = new System.Drawing.Point(104, 256);
            this.LoginSkBtns.MouseBack = null;
            this.LoginSkBtns.Name = "LoginSkBtns";
            this.LoginSkBtns.NormlBack = null;
            this.LoginSkBtns.Size = new System.Drawing.Size(81, 39);
            this.LoginSkBtns.TabIndex = 0;
            this.LoginSkBtns.Text = "登录";
            this.LoginSkBtns.UseVisualStyleBackColor = false;
            this.LoginSkBtns.Click += new System.EventHandler(this.LoginSkBtns_Click);
            // 
            // wtbUid
            // 
            this.wtbUid.Location = new System.Drawing.Point(209, 139);
            this.wtbUid.Name = "wtbUid";
            this.wtbUid.Size = new System.Drawing.Size(145, 35);
            this.wtbUid.TabIndex = 0;
            this.wtbUid.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.wtbUid.WaterText = "账号/用户名";
            this.wtbUid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wtbUid_KeyDown);
            // 
            // QuitSkBtn
            // 
            this.QuitSkBtn.BackColor = System.Drawing.Color.Transparent;
            this.QuitSkBtn.BaseColor = System.Drawing.Color.Black;
            this.QuitSkBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.QuitSkBtn.DownBack = null;
            this.QuitSkBtn.ForeColorSuit = true;
            this.QuitSkBtn.Location = new System.Drawing.Point(370, 256);
            this.QuitSkBtn.MouseBack = null;
            this.QuitSkBtn.Name = "QuitSkBtn";
            this.QuitSkBtn.NormlBack = null;
            this.QuitSkBtn.Size = new System.Drawing.Size(81, 39);
            this.QuitSkBtn.TabIndex = 3;
            this.QuitSkBtn.Text = "退出";
            this.QuitSkBtn.UseVisualStyleBackColor = false;
            this.QuitSkBtn.Click += new System.EventHandler(this.QuitSkBtn_Click);
            // 
            // ResetSkBtn
            // 
            this.ResetSkBtn.BackColor = System.Drawing.Color.Transparent;
            this.ResetSkBtn.BaseColor = System.Drawing.Color.Black;
            this.ResetSkBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ResetSkBtn.DownBack = null;
            this.ResetSkBtn.ForeColorSuit = true;
            this.ResetSkBtn.Location = new System.Drawing.Point(234, 256);
            this.ResetSkBtn.MouseBack = null;
            this.ResetSkBtn.Name = "ResetSkBtn";
            this.ResetSkBtn.NormlBack = null;
            this.ResetSkBtn.Size = new System.Drawing.Size(81, 39);
            this.ResetSkBtn.TabIndex = 4;
            this.ResetSkBtn.Text = "重置";
            this.ResetSkBtn.UseVisualStyleBackColor = false;
            this.ResetSkBtn.Click += new System.EventHandler(this.ResetSkBtn_Click);
            // 
            // wtbPwd
            // 
            this.wtbPwd.Location = new System.Drawing.Point(209, 191);
            this.wtbPwd.Name = "wtbPwd";
            this.wtbPwd.PasswordChar = '*';
            this.wtbPwd.Size = new System.Drawing.Size(145, 35);
            this.wtbPwd.TabIndex = 1;
            this.wtbPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.wtbPwd.WaterText = "密码";
            this.wtbPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wtbPwd_KeyDown);
            // 
            // errorInfo
            // 
            this.errorInfo.ContainerControl = this;
            // 
            // LoginNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(546, 357);
            this.Controls.Add(this.wtbPwd);
            this.Controls.Add(this.ResetSkBtn);
            this.Controls.Add(this.QuitSkBtn);
            this.Controls.Add(this.wtbUid);
            this.Controls.Add(this.LoginSkBtns);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginNewForm";
            this.Text = "SexyTeaERP管理系统---Login";
            this.Load += new System.EventHandler(this.LoginNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton LoginSkBtns;
        private CCWin.SkinControl.SkinWaterTextBox wtbUid;
        private CCWin.SkinControl.SkinButton QuitSkBtn;
        private CCWin.SkinControl.SkinButton ResetSkBtn;
        private CCWin.SkinControl.SkinWaterTextBox wtbPwd;
        private System.Windows.Forms.ErrorProvider errorInfo;
    }
}