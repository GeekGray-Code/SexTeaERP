using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SexTeaERP.DataClass;
using SexTeaERP.ComClass;
using System.Data.SqlClient;
using SexTeaERP;
using CCWin;

namespace SexTeaERP
{
    public partial class LoginNewForm : CCSkinMain
    {
        DataBase db = new DataBase();
        SqlDataReader sdr = null;

        public LoginNewForm()
        {
            InitializeComponent();
        }

        private void LoginNewForm_Load(object sender, EventArgs e)
        {

        }

        private void wtbUid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wtbPwd.Focus();
            }
        }

        private void wtbPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginSkBtns_Click(sender, e);
            }
        }

        private void LoginSkBtns_Click(object sender, EventArgs e)
        {
            this.errorInfo.Clear();

            if (String.IsNullOrEmpty(this.wtbUid.Text.Trim()))
            {
                try
                {
                    this.errorInfo.SetError(this.wtbUid, "用户编码不能为空！");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }
                finally
                {

                }
            }

            if (String.IsNullOrEmpty(this.wtbPwd.Text.Trim()))
            {
                try
                {
                    this.errorInfo.SetError(this.wtbPwd, "用户密码不能为空！");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }
                finally
                {

                }
            }

            string strSql = "select * from SYOperator where OperatorCode = '" + wtbUid.Text.Trim() + "' and PassWord = '" + wtbPwd.Text.Trim() + "'";

            try
            {
                sdr = db.GetDataReader(strSql);
                sdr.Read();
                if (sdr.HasRows)
                {
                    AppMain AppForm = new AppMain();
                    this.Hide();
                    PropertyClass.OperatorCode = sdr["OperatorCode"].ToString();
                    PropertyClass.OperatorName = sdr["OperatorName"].ToString();
                    PropertyClass.PassWord = sdr["PassWord"].ToString();
                    PropertyClass.IsAdmin = sdr["IsAdmin"].ToString();
                    AppForm.Show();
                }
                else
                {
                    MessageBox.Show("用户编码或用户密码不正确！", "软件提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
            finally
            {
                sdr.Close();
            }
        }

        private void ResetSkBtn_Click(object sender, EventArgs e)
        {
            wtbUid.Text = "";
            wtbPwd.Text = "";
        }

        private void QuitSkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
