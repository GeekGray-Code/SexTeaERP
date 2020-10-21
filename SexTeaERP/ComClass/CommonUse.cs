using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
using CrystalDecisions.Shared; //TableLogOnInfo
using CrystalDecisions.CrystalReports.Engine; //ReportDocument
using SexTeaERP.SystemManagement;
using SexTeaERP.DataClass;

namespace SexTeaERP.ComClass
{
    /// <summary>
    /// 公共的通用类，提供一些通用的方法
    /// </summary>
    public class CommonUse
    {
        DataBase db = new DataBase();

        public CommonUse()
        {
            
        }

        /// <summary>
        /// TreeView控件绑定到数据源
        /// </summary>
        /// <param name="tv">TreeView控件</param>
        /// <param name="imgList">ImageList控件</param>
        /// <param name="rootName">根节点的文本属性值</param>
        /// <param name="strTable">要绑定的数据表</param>
        /// <param name="strCode">数据表的代码列</param>
        /// <param name="strName">数据表的名称列</param>
        public void BuildTree(TreeView tv,ImageList imgList,string rootName, string strTable, string strCode, string strName)
        {
            string strSql = null;
            DataSet ds = null;
            DataTable dt = null;
            TreeNode rootNode = null;
            TreeNode childNode = null;

            strSql  = "select "+strCode+" , "+strName+" from "+strTable;
            tv.Nodes.Clear();
            tv.ImageList = imgList;
            //创建根节点
            rootNode = new TreeNode();
            rootNode.Tag = null;
            rootNode.Text = rootName;
            rootNode.ImageIndex = 1;
            rootNode.SelectedImageIndex = 0;

            try
            {
                ds = db.GetDataSet(strSql, strTable);
                dt = ds.Tables[strTable];

                foreach (DataRow row in dt.Rows)
                {
                    //创建子节点
                    childNode = new TreeNode();
                    childNode.Tag = row[strCode];
                    childNode.Text = row[strName].ToString();
                    childNode.ImageIndex = 1;
                    childNode.SelectedImageIndex = 0;
                    rootNode.Nodes.Add(childNode);
                }

                tv.Nodes.Add(rootNode);
                tv.ExpandAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }
        }

        /// <summary>
        /// 清空DataGridView
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        public void DataGridViewReset(DataGridView dgv)
        {
            if (dgv.DataSource != null)
            {
                //若DataGridView绑定的数据源为DataTable
                if (dgv.DataSource.GetType() == typeof(DataTable))
                {
                    DataTable dt = dgv.DataSource as DataTable;
                    dt.Clear();
                }

                //若DataGridView绑定的数据源为BindingSource
                if (dgv.DataSource.GetType() == typeof(BindingSource))
                {
                    BindingSource bs = dgv.DataSource as BindingSource;
                    DataTable dt = bs.DataSource as DataTable;
                    dt.Clear();
                }
            }
        }
        
        /// <summary>
        /// 在DataGridView控件的指定位置插入行
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        /// <param name="bs">BindingSource组件</param>
        /// <param name="dt">DataTable内存数据表</param>
        /// <param name="intPosIndex">指定位置的索引值</param>
        /// <returns>DataGridViewRow对象的引用</returns>
        public DataGridViewRow DataGridViewInsertRow(DataGridView dgv, BindingSource bs, DataTable dt, int intPosIndex)
        {
            DataGridViewRow dgvr = null;

            try
            {
                DataRow dr = dt.NewRow(); //基于某个DataTable的结构( 列结构仍然使用初始时产生的结构(如：sda.Fill(dt)) )，创建一个DataRow对象
                dt.Rows.InsertAt(dr, intPosIndex); //在数据源中插入新创建的DataRow对象
                bs.DataSource = dt;
                dgv.DataSource = bs;
                dgvr = dgv.Rows[intPosIndex];
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dgvr;
        }

        /// <summary>
        /// 在DataGridView控件的末尾添加行
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        /// <param name="bs">BingdingSource组件</param>
        /// <param name="dt">DataTable内存数据表</param>
        /// <returns>DataGridViewRow对象的引用</returns>
        public DataGridViewRow DataGridViewInsertRowAtEnd(DataGridView dgv, BindingSource bs, DataTable dt)
        {
            DataGridViewRow dgvr = null;

            try
            {
                DataRow dr = dt.NewRow(); 
                dt.Rows.Add(dr); //在结尾添加数据行对象
                bs.DataSource = dt;
                dgv.DataSource = bs;
                dgvr = dgv.Rows[dgv.RowCount - 1];
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dgvr;
        }

        /// <summary>
        /// ComboBox或DataGridViewComboBoxColumn绑定到数据源
        /// </summary>
        /// <param name="obj">要绑定数据源的控件</param>
        /// <param name="strValueColumn">ValueMember属性要绑定的列名称</param>
        /// <param name="strTextColumn">DisplayMember属性要绑定的列名称</param>
        /// <param name="strSql">SQL查询语句</param>
        /// <param name="strTable">数据表的名称</param>
        public void BindComboBox(Object obj, string strValueColumn, string strTextColumn, string strSql, string strTable) //Component —替换—> Object
        {
            try
            {
                string strType = obj.GetType().ToString();
                strType = strType.Substring(strType.LastIndexOf(".") + 1);
                
                //判断控件的类型
                switch (strType)
                {
                    case "ComboBox":

                        ComboBox cbx = (ComboBox)obj;
                        cbx.BeginUpdate();
                        cbx.DataSource = db.GetDataSet(strSql, strTable).Tables[strTable];
                        cbx.DisplayMember = strTextColumn;
                        cbx.ValueMember = strValueColumn;
                        cbx.EndUpdate();
                        break;

                    case "DataGridViewComboBoxColumn":

                        DataGridViewComboBoxColumn dgvcbx = (DataGridViewComboBoxColumn)obj;
                        dgvcbx.DataSource = db.GetDataSet(strSql, strTable).Tables[strTable];
                        dgvcbx.DisplayMember = strTextColumn;
                        dgvcbx.ValueMember = strValueColumn;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

       

        /// <summary>
        /// 控制可编辑控件的键盘输入，该方法限定控件只可以接收表示非负整数的字符
        /// </summary>
        /// <param name="e">为 KeyPress 事件提供数据</param>
        public void InputInteger(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != "")
            {
                //把Handled设为true，取消KeyPress事件，防止控件处理按键
                e.Handled = true;
            }
        }

        /// <summary>
        /// 获取数据库系统的时间
        /// </summary>
        /// <returns>数据库系统时间</returns>
        public DateTime GetDBTime()
        {
            DateTime dtDBTime;

            try
            {
                dtDBTime = Convert.ToDateTime(db.GetSingleObject("SELECT GETDATE()"));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }

            return dtDBTime;
        }

        /// <summary>
        /// 生成单据代码
        /// </summary>
        /// <param name="strTable">数据表</param>
        /// <param name="strBillCodeColumn">数据表中表示代码的列</param>
        /// <param name="strBillDateColumn">数据表中表示日期的列</param>
        /// <param name="dtBillDate">生成单据的日期</param>
        /// <returns>单据的代码</returns>
        public string BuildBillCode(string strTable, string strBillCodeColumn,string strBillDateColumn,DateTime dtBillDate)
        {
            string strSql;
            string strBillDate;
            string strMaxSeqNum;
            string strNewSeqNum;
            string strBillCode;

            try
            {
                strBillDate = dtBillDate.ToString("yyyyMMdd");
                strSql = "SELECT  SUBSTRING(MAX(" + strBillCodeColumn + "),10,4) FROM " + strTable + " WHERE " + strBillDateColumn + " = '" + dtBillDate.ToString("yyyy-MM-dd")+"'";
                strMaxSeqNum = db.GetSingleObject(strSql) as string;

                if (String.IsNullOrEmpty(strMaxSeqNum))
                {
                    strMaxSeqNum = "0000";
                }

                strNewSeqNum = (Convert.ToInt32(strMaxSeqNum) + 1).ToString("0000");
                strBillCode = strBillDate + "-" + strNewSeqNum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }

            return strBillCode;
        }

        /// <summary>
        /// 通过若干条领料单记录计算平均单价
        /// </summary>
        /// <param name="strPRProduceCode">生产单号</param>
        /// <param name="strInvenCode">存货代码</param>
        /// <returns>平均单价</returns>
        public decimal GetAvePriceBySTGetMaterial(string strPRProduceCode, string strInvenCode)
        {
            string strSql = null;
            decimal decAvePrice;

            strSql = "SELECT SUM(UnitPrice * Quantity) / SUM(Quantity) FROM STGetMaterial WHERE BillType = '1' AND IsFlag = '1'  AND PRProduceCode = '" + strPRProduceCode + "' AND InvenCode = '" + strInvenCode + "'";

            try
            {
               decAvePrice = Convert.ToDecimal(db.GetSingleObject(strSql));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }

            return decAvePrice;
        }

        /// <summary>
        /// DataGridView导出到Excel
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        /// <param name="strTitle">导出的Excel标题</param>
        public void DataGridViewExportToExcel(DataGridView dgv,string strTitle)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = false;
            saveFileDialog.FileName = strTitle+".xls";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) //导出时，点击【取消】按钮
            {
                return;
            }

            Stream myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
            
            string strHeaderText = "";

            try
            {   
                //写标题
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        strHeaderText += "\t";
                    }

                    strHeaderText += dgv.Columns[i].HeaderText;
                }

                sw.WriteLine(strHeaderText);
                
                //写内容
                string strItemValue = "";

                for (int j = 0; j < dgv.RowCount; j++)
                {
                    strItemValue = "";

                    for (int k = 0; k < dgv.ColumnCount; k++)
                    {
                        if (k > 0)
                        {
                            strItemValue += "\t";
                        }

                        strItemValue += dgv.Rows[j].Cells[k].Value.ToString();
                    }

                    sw.WriteLine(strItemValue); //把dgv的每一行的信息写为sw的每一行
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"软件提示");
                throw ex;
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }

        /// <summary>
        /// 判断数据表中记录的主键值是否存在外键约束
        /// </summary>
        /// <param name="strPrimaryTable">主键表</param>
        /// <param name="strPrimaryValue">数据表中某条记录主键的值</param>
        /// <returns></returns>
        public bool IsExistConstraint(string strPrimaryTable,string strPrimaryValue)
        {
            bool booIsExist = false;
            string strSql = null;
            string strForeignColumn = null;
            string strForeignTable = null;
            SqlDataReader sdr = null;

            try
            {
                //创建SqlParameter对象，并赋值
                SqlParameter param = new SqlParameter("@PrimaryTable", SqlDbType.VarChar);
                param.Value = strPrimaryTable;
               //创建泛型
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(param);
                //把泛型中的元素复制到数组中
                SqlParameter[] inputParameters = parameters.ToArray();
                //通过存储过程得到外键表的相关数据
                DataTable dt = db.GetDataTable("P_QueryForeignConstraint", inputParameters);
                
                //循环这些相关数据
                foreach (DataRow dr in dt.Rows)
                {
                    strForeignTable = dr["ForeignTable"].ToString();
                    strForeignColumn = dr["ForeignColumn"].ToString();
                    strSql = "Select " + strForeignColumn + " From " + strForeignTable + " Where " + strForeignColumn + " = '" + strPrimaryValue + "'";
                    sdr = db.GetDataReader(strSql);

                    if (sdr.HasRows)
                    {
                        booIsExist = true;
                        sdr.Close();
                        //跳出循环
                        break;
                    }

                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"软件提示");
                throw ex;
            }

            return booIsExist;
        }

        /// <summary>
        /// 通过控制按钮的Enabled属性来达到控制操作权限的目的
        /// </summary>
        /// <param name="iComp">Button或ToolStripButton按钮</param>
        /// <param name="form">被打开的窗体</param>
        public void CortrolButtonEnabled(IComponent iComp, Form form)
        {
            string strRightTag = null;
            Button btn = null;
            ToolStripButton tsb = null;

            //若是“Button”
            if (iComp.GetType() == typeof(Button))
            {
                btn = (Button)iComp;
                strRightTag = btn.Name.Substring(3);
            }
            
            //若是“ToolStripButton”
            if (iComp.GetType() == typeof(ToolStripButton))
            {
                tsb = (ToolStripButton)iComp;
                strRightTag = tsb.Name.Substring(4);
            }

            //系统管理员不受限制
            if (PropertyClass.IsAdmin == "1")
            {
                if (btn != null)
                {
                    btn.Enabled = true;
                }
                else
                {
                    tsb.Enabled = !tsb.Enabled;
                }
            }
            else
            {
                string strSql = "Select IsRight From SYAssignRight Where OperatorCode = '" + PropertyClass.OperatorCode + "' ";
                strSql += "and ModuleTag = '" + form.Tag.ToString() + "'and RightTag = '" + strRightTag + "'";

                try
                {
                    DataTable dt = db.GetDataTable(strSql, "SYAssignRight");

                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        DataColumn dc = dt.Columns["IsRight"];

                        if (dr[dc].ToString() == "1") //若具有权限
                        {
                            if (btn != null)
                            {
                                btn.Enabled = true;
                            }
                            else
                            {
                                tsb.Enabled = !tsb.Enabled;
                            }
                        }
                        else //若无权限
                        {
                            if (btn != null)
                            {
                                btn.Enabled = false;
                            }
                            else
                            {
                                tsb.Enabled = tsb.Enabled;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }
            }
        }
        
        /// <summary>
        /// 打开Form窗体
        /// </summary>
        /// <param name="menuItem">菜单项的引用</param>
        /// <param name="form">要打开的窗体的引用</param>
        public void ShowForm(ToolStripMenuItem menuItem, Form form)
        {
            switch (menuItem.Tag.ToString())
            {
               

                case "910":

                    FormSYOperator formSYOperator = new FormSYOperator();
                    formSYOperator.MdiParent = form;
                    formSYOperator.StartPosition = FormStartPosition.CenterScreen;
                    formSYOperator.Tag = menuItem.Tag.ToString();
                    formSYOperator.Show();
                    break;

                case "920":

                    FormPassWord formPassWord = new FormPassWord();
                    formPassWord.MdiParent = form;
                    formPassWord.StartPosition = FormStartPosition.CenterScreen;
                    formPassWord.Tag = menuItem.Tag.ToString();
                    formPassWord.Show();
                    break;

                case "930":

                    FormAssignRight formAssignRight = new FormAssignRight();
                    formAssignRight.MdiParent = form;
                    formAssignRight.StartPosition = FormStartPosition.CenterScreen;
                    formAssignRight.Tag = menuItem.Tag.ToString();
                    formAssignRight.Show();
                    break;

                default:

                    break;
            }
        }
    }
}
