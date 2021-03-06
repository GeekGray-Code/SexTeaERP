﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SexTeaERP.ComClass;
using SexTeaERP.DataClass;
using System.Data.SqlClient;

namespace SexTeaERP.Purchase
{
    public partial class FormPUPay : Form
    {
        DataBase db = new DataBase();
        CommonUse commUse = new CommonUse();

        public FormPUPay()
        {
            InitializeComponent();
        }

        private void ControlStatus()
        {
            //工具栏按钮状态切换
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            commUse.CortrolButtonEnabled(toolAdd, this);
            commUse.CortrolButtonEnabled(toolAmend, this);
            commUse.CortrolButtonEnabled(toolDelete, this);
            commUse.CortrolButtonEnabled(toolCheck, this);
            commUse.CortrolButtonEnabled(toolUnCheck, this);

            //窗体控件状态切换
            //this.txtPUInCode.ReadOnly = !this.txtPUInCode.ReadOnly;
            this.btnChoice.Enabled = !this.btnChoice.Enabled;
            this.txtPUMoney.ReadOnly = !this.txtPUMoney.ReadOnly;
            this.cbxAccountCode.Enabled = !this.cbxAccountCode.Enabled;
            this.cbxEmployeeCode.Enabled = !this.cbxEmployeeCode.Enabled;
            this.txtRemark.ReadOnly = !this.txtRemark.ReadOnly;
        }

        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {
            this.txtPUPayCode.Text = "";
            this.dtpPUPayDate.Value = Convert.ToDateTime("1900-01-01");
            this.cbxOperatorCode.SelectedIndex = -1;
            this.txtPUInCode.Text = "";
            this.dtpPUInDate.Value = Convert.ToDateTime("1900-01-01");
            this.cbxSupplierCode.SelectedIndex = -1;
            this.txtPUMoney.Text = "";
            this.cbxAccountCode.SelectedIndex = -1;
            this.cbxEmployeeCode.SelectedIndex = -1;
            this.txtRemark.Text = "";
            this.cbxIsFlag.SelectedIndex = -1;
        }

        private void BindToolStripComboBox()
        {
            this.cbxCondition.Items.Add("单据编号");
            this.cbxCondition.Items.Add("单据日期");
        }

        /// <summary>
        /// 设置控件的显示值
        /// </summary>
        private void FillControls()
        {
            this.txtPUPayCode.Text = this.dgvPUPayInfo[0, this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            this.dtpPUPayDate.Value = Convert.ToDateTime(this.dgvPUPayInfo[1, this.dgvPUPayInfo.CurrentCell.RowIndex].Value);
            this.cbxOperatorCode.SelectedValue = this.dgvPUPayInfo[2, this.dgvPUPayInfo.CurrentCell.RowIndex].Value;  
            this.txtPUInCode.Text = this.dgvPUPayInfo[3, this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            this.dtpPUInDate.Value = Convert.ToDateTime(this.dgvPUPayInfo[4, this.dgvPUPayInfo.CurrentCell.RowIndex].Value);
            this.cbxSupplierCode.SelectedValue = this.dgvPUPayInfo[5, this.dgvPUPayInfo.CurrentCell.RowIndex].Value;
            this.txtPUMoney.Text = this.dgvPUPayInfo[6, this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            this.cbxAccountCode.SelectedValue = this.dgvPUPayInfo[7, this.dgvPUPayInfo.CurrentCell.RowIndex].Value;
            this.cbxEmployeeCode.SelectedValue = this.dgvPUPayInfo[8, this.dgvPUPayInfo.CurrentCell.RowIndex].Value;
            this.txtRemark.Text = this.dgvPUPayInfo[9, this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            this.cbxIsFlag.SelectedValue = this.dgvPUPayInfo[10, this.dgvPUPayInfo.CurrentCell.RowIndex].Value;
        }

        /// <summary>
        /// DataGridView控件绑定到数据源
        /// </summary>
        /// <param name="strWhere">Where条件子句</param>
        private void BindDataGridView(string strWhere)
        {
            string strSql = null;

            strSql = "SELECT * ";
            strSql += "FROM PUPay " + strWhere; ;

            try
            {
                this.dgvPUPayInfo.DataSource = db.GetDataSet(strSql, "PUPay").Tables["PUPay"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        /// <summary>
        /// 设置参数值
        /// </summary>
        private void ParametersAddValue()
        {
            db.Cmd.Parameters.Clear();
            db.Cmd.Parameters.AddWithValue("@PUPayCode", txtPUPayCode.Text.Trim());
            db.Cmd.Parameters.AddWithValue("@PUPayDate", dtpPUPayDate.Value);

            if (cbxOperatorCode.SelectedValue == null)
            {
                db.Cmd.Parameters.AddWithValue("@OperatorCode", DBNull.Value);
            }
            else
            {
                db.Cmd.Parameters.AddWithValue("@OperatorCode", cbxOperatorCode.SelectedValue.ToString());
            }

            db.Cmd.Parameters.AddWithValue("@PUInCode", txtPUInCode.Text.Trim());
            db.Cmd.Parameters.AddWithValue("@PUInDate", dtpPUInDate.Value);

            if (cbxSupplierCode.SelectedValue == null)
            {
                db.Cmd.Parameters.AddWithValue("@SupplierCode", DBNull.Value);
            }
            else
            {
                db.Cmd.Parameters.AddWithValue("@SupplierCode", cbxSupplierCode.SelectedValue.ToString());
            }

            if (String.IsNullOrEmpty(txtPUMoney.Text.Trim()))
            {
                db.Cmd.Parameters.AddWithValue("@PUMoney", 0);
            }
            else
            {
                db.Cmd.Parameters.AddWithValue("@PUMoney", Decimal.Round(Convert.ToDecimal(txtPUMoney.Text.Trim()),2));
            }

            if (cbxAccountCode.SelectedValue == null)
            {
                db.Cmd.Parameters.AddWithValue("@AccountCode", DBNull.Value);
            }
            else
            {
                db.Cmd.Parameters.AddWithValue("@AccountCode", cbxAccountCode.SelectedValue.ToString());
            }

            if (cbxEmployeeCode.SelectedValue == null)
            {
                db.Cmd.Parameters.AddWithValue("@EmployeeCode", DBNull.Value);
            }
            else
            {
                db.Cmd.Parameters.AddWithValue("@EmployeeCode", cbxEmployeeCode.SelectedValue.ToString());
            }

            db.Cmd.Parameters.AddWithValue("@Remark", txtRemark.Text.Trim());

            if (cbxIsFlag.SelectedValue == null)
            {
                db.Cmd.Parameters.AddWithValue("@IsFlag", DBNull.Value);
            }
            else
            {
                db.Cmd.Parameters.AddWithValue("@IsFlag", cbxIsFlag.SelectedValue.ToString());
            }            
        }

        private void FormPUPay_Load(object sender, EventArgs e)
        {
            //权限
            commUse.CortrolButtonEnabled(toolAdd, this);
            commUse.CortrolButtonEnabled(toolAmend, this);
            commUse.CortrolButtonEnabled(toolDelete, this);
            commUse.CortrolButtonEnabled(toolCheck, this);
            commUse.CortrolButtonEnabled(toolUnCheck, this);

            //ComboBox绑定到数据源
            commUse.BindComboBox(cbxOperatorCode, "OperatorCode", "OperatorName", "select OperatorCode,OperatorName from SYOperator", "SYOperator");
            commUse.BindComboBox(cbxSupplierCode, "SupplierCode", "SupplierName", "select SupplierCode,SupplierName from BSSupplier", "BSSupplier");   
            commUse.BindComboBox(cbxAccountCode, "AccountCode", "AccountName", "select AccountCode,AccountName from BSAccount", "BSAccount");      
            commUse.BindComboBox(cbxEmployeeCode, "EmployeeCode", "EmployeeName", "select EmployeeCode,EmployeeName from BSEmployee", "BSEmployee");
            commUse.BindComboBox(cbxIsFlag, "Code", "Name", "select * from INCheckFlag", "INCheckFlag");

            //DataGridViewComboBoxColumn绑定到数据源
            commUse.BindComboBox(this.dgvPUPayInfo.Columns["OperatorCode"], "OperatorCode", "OperatorName", "select OperatorCode,OperatorName from SYOperator", "SYOperator");
            commUse.BindComboBox(this.dgvPUPayInfo.Columns["SupplierCode"], "SupplierCode", "SupplierName", "select SupplierCode,SupplierName from BSSupplier", "BSSupplier");
            commUse.BindComboBox(this.dgvPUPayInfo.Columns["AccountCode"], "AccountCode", "AccountName", "select AccountCode,AccountName from BSAccount", "BSAccount");
            commUse.BindComboBox(this.dgvPUPayInfo.Columns["EmployeeCode"], "EmployeeCode", "EmployeeName", "select EmployeeCode,EmployeeName from BSEmployee", "BSEmployee");
            commUse.BindComboBox(this.dgvPUPayInfo.Columns["IsFlag"], "Code", "Name", "select * from INCheckFlag", "INCheckFlag");
            //
            BindDataGridView("");
            this.BindToolStripComboBox();
            this.cbxCondition.SelectedIndex = 0;
            toolStrip1.Tag = "";
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            toolStrip1.Tag = "ADD"; //添加标识

            dtpPUPayDate.Value = DateTime.Today;
            cbxOperatorCode.SelectedValue = PropertyClass.OperatorCode;
            cbxIsFlag.SelectedValue = "0";

            txtPUPayCode.Text = commUse.BuildBillCode("PUPay", "PUPayCode", "PUPayDate", dtpPUPayDate.Value);
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            toolStrip1.Tag = "EDIT"; //修改标识

        }

        private void dgvPUPayInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (toolStrip1.Tag.ToString() == "EDIT" && dgvPUPayInfo.RowCount > 0)
            {
                if (this.dgvPUPayInfo[10, this.dgvPUPayInfo.CurrentRow.Index].Value.ToString() == "1")
                {
                    MessageBox.Show("该记录已审核，不允许编辑！", "软件提示");
                    return;
                }

                FillControls();
            }
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            toolStrip1.Tag = "";
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPUMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            commUse.InputNumeric(e, sender as Control);
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            FormBrowsePUInStore formBrowsePUInStore = new FormBrowsePUInStore();
            formBrowsePUInStore.Owner = this;
            formBrowsePUInStore.ShowDialog();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            string strCode = null;

            if(String.IsNullOrEmpty(txtPUPayCode.Text.Trim()))
            {
                MessageBox.Show("单据编号不许为空！", "软件提示");
                txtPUPayCode.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtPUInCode.Text.Trim()))
            {
                MessageBox.Show("入库单号不许为空！", "软件提示");
                txtPUInCode.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtPUMoney.Text.Trim()))
            {
                MessageBox.Show("付款金额不许为空！", "软件提示");
                txtPUMoney.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(txtPUMoney.Text.Trim()) == 0)
                {
                    MessageBox.Show("付款金额不能等于零", "软件提示");
                    txtPUMoney.Focus();
                    return;
                }
            }

            if (cbxAccountCode.SelectedValue == null)
            {
                MessageBox.Show("结算账户不许为空！", "软件提示");
                cbxAccountCode.Focus();
                return;
            }

            //添加
            if (toolStrip1.Tag.ToString() == "ADD")
            {
                try
                {
                    strCode = "INSERT INTO PUPay(PUPayCode,PUPayDate,OperatorCode,PUInCode,PUInDate,SupplierCode,PUMoney,AccountCode,EmployeeCode,Remark,IsFlag) ";
                    strCode += "VALUES(@PUPayCode,@PUPayDate,@OperatorCode,@PUInCode,@PUInDate,@SupplierCode,@PUMoney,@AccountCode,@EmployeeCode,@Remark,@IsFlag)";

                    ParametersAddValue();

                    if (db.ExecDataBySql(strCode) > 0)
                    {
                        MessageBox.Show("保存成功！", "软件提示");
                        this.BindDataGridView("");
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("保存失败！", "软件提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }
            }

            //修改
            if (toolStrip1.Tag.ToString() == "EDIT")
            {
                string strPUPayCode = txtPUPayCode.Text.Trim();

                //更新数据库
                try
                {
                    strCode = "UPDATE PUPay SET PUPayCode = @PUPayCode,PUPayDate = @PUPayDate,OperatorCode = @OperatorCode, PUInCode = @PUInCode,PUInDate = @PUInDate,";
                    strCode += "SupplierCode = @SupplierCode,PUMoney = @PUMoney,AccountCode = @AccountCode,";
                    strCode += "EmployeeCode = @EmployeeCode,Remark = @Remark,IsFlag = @IsFlag ";
                    strCode += "WHERE PUPayCode = '" + strPUPayCode + "'";

                    ParametersAddValue();

                    if (db.ExecDataBySql(strCode) > 0)
                    {
                        MessageBox.Show("保存成功！", "软件提示");
                        this.BindDataGridView("");
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("保存失败！", "软件提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }
            }

            toolStrip1.Tag = "";
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            string strPUPayCode = null; //单据编码
            string strSql = null;
            string strIsFlag = null; //审核标记

            if (this.dgvPUPayInfo.RowCount <= 0)
            {
                return;
            }

            strPUPayCode = this.dgvPUPayInfo["PUPayCode", this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            strIsFlag = this.dgvPUPayInfo["IsFlag", this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();

            if (strIsFlag == "1")
            {
                MessageBox.Show("该单据已审核，不许删除！", "软件提示");
                return;
            }

            strSql = "DELETE FROM PUPay WHERE PUPayCode = '" + strPUPayCode + "'";

            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    if (db.ExecDataBySql(strSql) > 0)
                    {
                        MessageBox.Show("删除成功！", "软件提示");
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "软件提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }

                this.BindDataGridView("");
            }
        }

        private void toolCheck_Click(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            string strCode = null;
            List<string> strSqls = new List<string>();

            decimal decMoney;
            string strPUPayCode = null; //单据编码
            string strIsFlag = null; //审核标记
            string strAccountCode = null; //帐号代码

            string strPUPaySql = null; //表示提交PUPay表的SQL语句
            string strAccountSql = null; //表示提交BSAccount表的SQL语句

            if (dgvPUPayInfo.RowCount == 0)
            {
                return;
            }

            strPUPayCode = this.dgvPUPayInfo["PUPayCode", this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            strAccountCode = this.dgvPUPayInfo["AccountCode", this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            strIsFlag = this.dgvPUPayInfo["IsFlag", this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            decMoney = Convert.ToDecimal(this.dgvPUPayInfo["PUMoney", this.dgvPUPayInfo.CurrentCell.RowIndex].Value);

            if (strIsFlag == "1")
            {
                MessageBox.Show("该单据已审核过，不许再次审核！", "软件提示");
                return;
            }

            strCode = "Select AccMoney From BSAccount Where AccountCode = '" + strAccountCode + "'";

            try
            {
                sdr = db.GetDataReader(strCode);
                sdr.Read();

                //付款时，判断账户金额
                if (sdr.GetDecimal(0) < decMoney)
                {
                    MessageBox.Show("帐户金额不足！", "软件提示");
                    sdr.Close();
                    return;
                }

                //关闭SqlDataReader对象(同时关闭db.Conn对象)
                sdr.Close();

                strAccountSql = "UPDATE BSAccount SET AccMoney = Accmoney - " + decMoney + " WHERE AccountCode = '" + strAccountCode + "'";
                strPUPaySql = "UPDATE PUPay SET IsFlag = '1' WHERE PUPayCode = '" + strPUPayCode + "'";

                strSqls.Add(strAccountSql);
                strSqls.Add(strPUPaySql);

                if (db.ExecDataBySqls(strSqls))
                {
                    MessageBox.Show("审核成功！", "软件提示");
                }
                else
                {
                    MessageBox.Show("审核失败！", "软件提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }

            this.BindDataGridView("");
        }

        private void toolUnCheck_Click(object sender, EventArgs e)
        {
            List<string> strSqls = new List<string>();

            decimal decMoney;
            string strPUPayCode = null; //单据编号
            string strIsFlag = null; //审核标记
            string strAccountCode = null; //帐户代码

            string strPUPaySql = null; //表示提交PUPay表的SQL语句
            string strAccountSql = null; //表示提交BSAccount表的SQL语句

            if (dgvPUPayInfo.RowCount == 0)
            {
                return;
            }

            strPUPayCode = this.dgvPUPayInfo["PUPayCode", this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            strAccountCode = this.dgvPUPayInfo["AccountCode", this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            strIsFlag = this.dgvPUPayInfo["IsFlag", this.dgvPUPayInfo.CurrentCell.RowIndex].Value.ToString();
            decMoney = Convert.ToDecimal(this.dgvPUPayInfo["PUMoney", this.dgvPUPayInfo.CurrentCell.RowIndex].Value);

            if (strIsFlag == "0")
            {
                MessageBox.Show("该单据未审核，无需弃审！", "软件提示");
                return;
            }

            strAccountSql = "UPDATE BSAccount SET AccMoney = Accmoney + " + decMoney + " WHERE AccountCode = '" + strAccountCode + "'";
            strPUPaySql = "UPDATE PUPay SET IsFlag = '0' WHERE PUPayCode = '" + strPUPayCode + "'";

            strSqls.Add(strAccountSql);
            strSqls.Add(strPUPaySql);

            try
            {
                if (db.ExecDataBySqls(strSqls))
                {
                    MessageBox.Show("弃审成功！", "软件提示");
                }
                else
                {
                    MessageBox.Show("弃审失败！", "软件提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }

            this.BindDataGridView("");
        }

        private void txtOK_Click(object sender, EventArgs e)
        {
            string strWhere = String.Empty;
            string strConditonName = String.Empty;

            strConditonName = this.cbxCondition.Items[this.cbxCondition.SelectedIndex].ToString();
            switch (strConditonName)
            {
                case "单据编号":

                    strWhere = " WHERE PUPayCode LIKE '%" + txtKeyWord.Text.Trim() + "%'";
                    this.BindDataGridView(strWhere);
                    break;

                case "单据日期":

                    strWhere = " WHERE SUBSTRING(CONVERT(VARCHAR(20),PUPayDate,20),1,10) LIKE '%" + txtKeyWord.Text.Trim() + "%'";
                    this.BindDataGridView(strWhere);
                    break;

                default:
                    break;
            }
        }

        private void dgvPUPayInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
