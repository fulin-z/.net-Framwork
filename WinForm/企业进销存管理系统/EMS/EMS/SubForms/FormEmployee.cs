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
    public partial class FormEmployee : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select ID as 编号,EmployeeCode as 职员编号,FullName as 职员姓名,Sex as 职员性别,Dept as 所在部门,Tel as 联系电话,Remark as 备注,EditMan as 编辑人,EditTime as 编辑时间 from tb_Employee order by EmployeeCode", "tb_Employee");
            dgvEmployeeList.DataSource = ds.Tables["tb_Employee"];
            string P_Str_newUnitcode = "";
            int P_Int_newUnitcode = 0;
            if (ds.Tables[0].Rows.Count == 0)
            {
                txtEmpployCode.Text = "E1001";
            }
            else
            {
                P_Str_newUnitcode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["职员编号"]);
                P_Int_newUnitcode = Convert.ToInt32(P_Str_newUnitcode.Substring(1, 4)) + 1;
                P_Str_newUnitcode = "E" + P_Int_newUnitcode.ToString();
                txtEmpployCode.Text = P_Str_newUnitcode;
            }
        }

        private void TlBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || cmbSex.Text == "" || txtDept.Text == "" || txtTel.Text == "" || txtRemark.Text == "" || txtEmpployCode.Text == "")
                {
                    MessageBox.Show("请将信息填写完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_Employee where FullName='" + txtFullName.Text + "'");
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该职员姓名已存在！");
                    }
                    else
                    {
                        SqlDataReader sqlread2 = datacon.getread("select * from tb_Employee where EmployeeCode='" + txtEmpployCode.Text + "'");
                        if (sqlread2.Read())
                        {
                            MessageBox.Show("该职员编号已存在！");
                        }
                        else
                        {
                            datacon.getcom("insert into tb_Employee(EmployeeCode,FullName,Sex,Dept,Tel,Remark,EditMan,EditTime) " +
                            "values('" + txtEmpployCode.Text + "','" + txtFullName.Text + "','" + cmbSex.Text + "','" + txtDept.Text + "','" + txtTel.Text + "','" + txtRemark.Text + "','" + FormLogin.L_UserName + "','" + DateTime.Now + "')");
                            MessageBox.Show("职员信息添加成功！");
                            txtFullName.Text = "";
                            txtDept.Text = "";
                            txtTel.Text = "";
                            txtRemark.Text = "";
                            FormEmployee_Load(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TlBtnCancel_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtDept.Text = "";
            txtTel.Text = "";
            txtRemark.Text = "";
        }

        private void DgvEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = dgvEmployeeList.CurrentRow.Index;
                txtEmpployCode.Text = dgvEmployeeList.Rows[a].Cells["职员编号"].Value.ToString();
                txtFullName.Text = dgvEmployeeList.Rows[a].Cells["职员姓名"].Value.ToString();
                cmbSex.Text = dgvEmployeeList.Rows[a].Cells["职员性别"].Value.ToString();
                txtDept.Text = dgvEmployeeList.Rows[a].Cells["所在部门"].Value.ToString();
                txtTel.Text = dgvEmployeeList.Rows[a].Cells["联系电话"].Value.ToString();
                txtRemark.Text = dgvEmployeeList.Rows[a].Cells["备注"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TlBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader sqlreader = datacon.getread("select * from tb_Employee where EmployeeCode='" + txtEmpployCode.Text + "'");
                if (sqlreader.Read())
                {
                    datacon.getcom("delete from tb_Employee where EmployeeCode='" + txtEmpployCode.Text + "'");
                    MessageBox.Show("职员信息删除成功！");
                    FormEmployee_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("该职员编号不存在！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TlBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TlBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || cmbSex.Text == "" || txtDept.Text == "" || txtTel.Text == "" || txtRemark.Text == "")
                {
                    MessageBox.Show("请将信息填写完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_Employee where EmployeeCode='" + txtEmpployCode.Text + "'");
                    if (sqlread.Read())
                    {
                        datacon.getcom("update tb_Employee set FullName='" + txtFullName.Text + "',Sex='" + cmbSex.Text + "',Dept='" + txtDept.Text + "',Tel='" + txtTel.Text + "',Remark='" + txtRemark.Text + "',EditMan='" + FormLogin.L_UserName + "',EditTime='" + DateTime.Now + "' where EmployeeCode='" + txtEmpployCode.Text + "'");
                        MessageBox.Show("职员信息修改成功！");
                        txtFullName.Text = "";
                        txtDept.Text = "";
                        txtTel.Text = "";
                        txtRemark.Text = "";
                        FormEmployee_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("该职员编号不存在！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TlBtnFind_Click(object sender, EventArgs e)
        {
            if (tlCmbEmployeeType.Text == string.Empty)
            {
                MessageBox.Show("查询类别不能为空！");
            }
            else
            {
                if (tlTxtFindEmployee.Text.Trim() == string.Empty)
                {
                    DataSet ds = datacon.getds("select ID as 编号,EmployeeCode as 职员编号,FullName as 职员姓名,Sex as 职员性别,Dept as 所在部门,Tel as 联系电话,Remark as 备注,EditMan as 编辑人,EditTime as 编辑时间 from tb_Employee order by EmployeeCode", "tb_Employee");
                    dgvEmployeeList.DataSource = ds.Tables["tb_Employee"];
                }
                else
                {
                    DataSet ds2 = null;
                    if (tlCmbEmployeeType.Text == "职员编号")
                    {
                        ds2 = datacon.getds("select ID as 编号,EmployeeCode as 职员编号,FullName as 职员姓名,Sex as 职员性别,Dept as 所在部门,Tel as 联系电话,Remark as 备注,EditMan as 编辑人,EditTime as 编辑时间 from tb_Employee where EmployeeCode like '%"+tlTxtFindEmployee.Text+"%' order by EmployeeCode", "tb_Employee");
                        dgvEmployeeList.DataSource = ds2.Tables["tb_Employee"];
                    }
                    else
                    {
                        ds2 = datacon.getds("select ID as 编号,EmployeeCode as 职员编号,FullName as 职员姓名,Sex as 职员性别,Dept as 所在部门,Tel as 联系电话,Remark as 备注,EditMan as 编辑人,EditTime as 编辑时间 from tb_Employee where FullName like '%"+tlTxtFindEmployee.Text+"%' order by EmployeeCode", "tb_Employee");
                        dgvEmployeeList.DataSource = ds2.Tables["tb_Employee"];
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text.Trim() == "")
                {
                    MessageBox.Show("职员姓名不可为空！");
                }
                else
                {
                    SqlDataReader read = datacon.getread("select * from tb_Employee where FullName='" + txtFullName.Text + "'");
                    if (read.Read())
                    {
                        SqlDataReader read2 = datacon.getread("select * from tb_User where UserName='" + txtFullName.Text + "'");
                        if (read2.Read())
                        {
                            MessageBox.Show("该职员已分配账号！");
                        }
                        else
                        {
                            string pwd = "123";
                            string right = "操作用户";
                            datacon.getcom("insert into tb_User(UserName,UserPwd,UserRight) values('" + txtFullName.Text + "','" + pwd + "','" + right + "')");
                            MessageBox.Show("账号已创建！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该职员不存在！");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
