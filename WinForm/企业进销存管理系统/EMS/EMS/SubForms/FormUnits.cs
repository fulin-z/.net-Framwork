using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.SubForms
{
    public partial class FormUnits : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormUnits()
        {
            InitializeComponent();
        }

        private void TlBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TlBtnCancel_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtTax.Text = "";
            txtLinkMan.Text = "";
            txtAddress.Text = "";
            txtAccounts.Text = "";
            txtTel.Text = "";
        }

        private void FormUnits_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select ID as 编号,UnitCode as 单位编号,FullName as 单位全称,Tax as 税号,Tel as 单位电话,LinkMan as 联系人,Accounts as 开户行及账号,Adress as 单位地址,EditMan as 编辑人,EditTime as 编辑时间 from tb_Units order by UnitCode", "tb_Units");
            dgvUnitsList.DataSource = ds.Tables["tb_Units"];
            string P_Str_newUnitcode = "";
            int P_Int_newUnitcode = 0;
            if (ds.Tables[0].Rows.Count == 0)
            {
                txtUnitCode.Text = "U1001";
            }
            else
            {
                P_Str_newUnitcode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["单位编号"]);
                P_Int_newUnitcode = Convert.ToInt32(P_Str_newUnitcode.Substring(1, 4)) + 1;
                P_Str_newUnitcode = "U" + P_Int_newUnitcode.ToString();
                txtUnitCode.Text = P_Str_newUnitcode;
            }
        }

        private void TlBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtTax.Text == "" || txtTel.Text == "" || txtLinkMan.Text == "" || txtAccounts.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("请将信息填写完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_Units where FullName='" + txtFullName.Text + "'");
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该单位名称已存在！");
                    }
                    else
                    {
                        SqlDataReader sqlread2 = datacon.getread("select * from tb_Units where UnitCode='" + txtUnitCode.Text + "'");
                        if (sqlread2.Read())
                        {
                            MessageBox.Show("该单位编号已存在！");
                        }
                        else
                        {
                            datacon.getcom("insert into tb_Units(UnitCode,FullName,Tax,Tel,LinkMan,Accounts,Adress,EditMan,EditTime) " +
                            "values('" + txtUnitCode.Text + "','" + txtFullName.Text + "','" + txtTax.Text + "','" + txtTel.Text + "','" + txtLinkMan.Text + "','" + txtAccounts.Text + "','" + txtAddress.Text + "','" + FormLogin.L_UserName + "','" + DateTime.Now + "')");
                            MessageBox.Show("单位信息添加成功！");
                            txtFullName.Text = "";
                            txtTax.Text = "";
                            txtLinkMan.Text = "";
                            txtAddress.Text = "";
                            txtAccounts.Text = "";
                            txtTel.Text = "";
                            FormUnits_Load(sender, e);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TlBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader sqlreader = datacon.getread("select * from tb_Units where UnitCode='" + txtUnitCode.Text + "'");
                if (sqlreader.Read())
                {
                    datacon.getcom("delete from tb_Units where UnitCode='" + txtUnitCode.Text + "'");
                    MessageBox.Show("单位信息删除成功！");
                    FormUnits_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("该单位编号不存在！");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvUnitsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = dgvUnitsList.CurrentRow.Index;
                txtUnitCode.Text = dgvUnitsList.Rows[a].Cells["单位编号"].Value.ToString();
                txtFullName.Text = dgvUnitsList.Rows[a].Cells["单位全称"].Value.ToString();
                txtTax.Text = dgvUnitsList.Rows[a].Cells["税号"].Value.ToString();
                txtTel.Text = dgvUnitsList.Rows[a].Cells["单位电话"].Value.ToString();
                txtLinkMan.Text = dgvUnitsList.Rows[a].Cells["联系人"].Value.ToString();
                txtAccounts.Text = dgvUnitsList.Rows[a].Cells["开户行及账号"].Value.ToString();
                txtAddress.Text = dgvUnitsList.Rows[a].Cells["单位地址"].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TlBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtTax.Text == "" || txtTel.Text == "" || txtLinkMan.Text == "" || txtAccounts.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("请将信息填写完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_Units where UnitCode='" + txtUnitCode.Text + "'");
                    if (sqlread.Read())
                    {
                        datacon.getcom("update tb_Units set FullName='" + txtFullName.Text + "',Tax='" + txtTax.Text + "',Tel='" + txtTel.Text + "',LinkMan='" + txtLinkMan.Text + "',Accounts='" + txtAccounts.Text + "',Adress='" + txtAddress.Text + "',EditMan='" + FormLogin.L_UserName + "',EditTime='" + DateTime.Now + "' where Unitcode='" + txtUnitCode.Text + "'");
                        MessageBox.Show("单位信息修改成功！");
                        txtFullName.Text = "";
                        txtTax.Text = "";
                        txtLinkMan.Text = "";
                        txtAddress.Text = "";
                        txtAccounts.Text = "";
                        txtTel.Text = "";
                        FormUnits_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("该单位编号不存在！");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TlBtnFind_Click(object sender, EventArgs e)
        {
            if (tlCmbUnitsType.Text == string.Empty)
            {
                MessageBox.Show("查询类别不能为空！");
            }
            else
            {
                if (tlTxtFindUnits.Text.Trim() == string.Empty)
                {
                    DataSet ds = datacon.getds("select ID as 编号,UnitCode as 单位编号,FullName as 单位全称,Tax as 税号,Tel as 单位电话,LinkMan as 联系人,Accounts as 开户行及账号,Adress as 单位地址,EditMan as 编辑人,EditTime as 编辑时间 from tb_Units order by UnitCode", "tb_Units");
                    dgvUnitsList.DataSource = ds.Tables["tb_Units"];
                }
                else
                {
                    DataSet ds2 = null;
                    if (tlCmbUnitsType.Text == "单位编号")  //按单位编号查询
                    {
                        ds2 = datacon.getds("select ID as 编号,UnitCode as 单位编号,FullName as 单位全称,Tax as 税号,Tel as 单位电话,LinkMan as 联系人,Accounts as 开户行及账号,Adress as 单位地址,EditMan as 编辑人,EditTime as 编辑时间 from tb_Units where UnitCode like '%"+tlTxtFindUnits.Text+"%' order by UnitCode", "tb_Units");
                        dgvUnitsList.DataSource = ds2.Tables["tb_Units"];
                    }
                    else                 //按单位名称查询
                    {
                        ds2 = datacon.getds("select ID as 编号,UnitCode as 单位编号,FullName as 单位全称,Tax as 税号,Tel as 单位电话,LinkMan as 联系人,Accounts as 开户行及账号,Adress as 单位地址,EditMan as 编辑人,EditTime as 编辑时间 from tb_Units where FullName like '%"+tlTxtFindUnits.Text+"%' order by UnitCode", "tb_Units");
                        dgvUnitsList.DataSource = ds2.Tables["tb_Units"];
                    }
                }
            }
        }
    }
}
