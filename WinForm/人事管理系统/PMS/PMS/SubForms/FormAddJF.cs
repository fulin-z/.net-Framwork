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

namespace PMS.SubForms
{
    public partial class FormAddJF : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormAddJF()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbbUserJFType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbUserJFType.Text == "奖励")
            {
                txtFK.Enabled = false;
                txtFK.Text = "0";
                txtJL.Enabled = true;
            }
            else
            {
                txtJL.Enabled = false;
                txtJL.Text = "0";
                txtFK.Enabled = true;
            }
        }

        private void FormAddJF_Load(object sender, EventArgs e)
        {
            doperate.cboxBind("select EmployeeID from tb_Employee", "tb_Employee", "EmployeeID", cbbUserNum);
        }

        private void CbbUserNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader sqlread = datacon.getread("select * from tb_Employee where EmployeeID='" + cbbUserNum.Text + "'");
                if (sqlread.Read())
                {
                    txtName.Text = sqlread["EmployeeName"].ToString();
                    txtDept.Text = sqlread["EmployeeDept"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbUserJFType.Text == "" || txtJFcontent.Text == "")
                {
                    MessageBox.Show("请将信息填写完整！");
                }
                else
                {
                    if (cbbUserJFType.Text == "奖励")
                    {
                        if (txtJL.Text == "")
                        {
                            MessageBox.Show("请输入奖励金额！");
                        }
                        else if (txtJL.Text == "0")
                        {
                            MessageBox.Show("金额不可为0！");
                        }
                        else
                        {
                            SqlDataReader sqlread = datacon.getread("select * from tb_Rewards where EmployeeID='" + cbbUserNum.Text + "'");
                            if (sqlread.Read())
                            {
                                MessageBox.Show("该员工已有奖罚，请直接修改！");
                            }
                            else
                            {
                                datacon.getcom("insert into tb_Rewards(EmployeeID,EmployeeName,Dept,EmployeeJF,EmployeeJFContent,Rewards,Punishments,JFDate,CLPeople,CLTime) " +
                                "values('" + cbbUserNum.Text + "','" + txtName.Text + "','" + txtDept.Text + "','" + cbbUserJFType.Text + "','" + txtJFcontent.Text + "','" + txtJL.Text + "','" + txtFK.Text + "','" + txtJFdate.Text + "','" + FormLogin.L_UserName + "','" + DateTime.Now + "')");
                                MessageBox.Show("奖罚发布成功！");
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        if (txtFK.Text == "")
                        {
                            MessageBox.Show("请输入罚款金额！");
                        }
                        else if (txtFK.Text == "0")
                        {
                            MessageBox.Show("金额不可为0！");
                        }
                        else
                        {
                            SqlDataReader sqlread = datacon.getread("select * from tb_Rewards where EmployeeID='" + cbbUserNum.Text + "'");
                            if (sqlread.Read())
                            {
                                MessageBox.Show("该员工已有奖罚，请直接修改！");
                            }
                            else
                            {
                                datacon.getcom("insert into tb_Rewards(EmployeeID,EmployeeName,Dept,EmployeeJF,EmployeeJFContent,Rewards,Punishments,JFDate,CLPeople,CLTime) " +
                                "values('" + cbbUserNum.Text + "','" + txtName.Text + "','" + txtDept.Text + "','" + cbbUserJFType.Text + "','" + txtJFcontent.Text + "','" + txtJL.Text + "','" + txtFK.Text + "','" + txtJFdate.Text + "','" + FormLogin.L_UserName + "','" + DateTime.Now + "')");
                                MessageBox.Show("奖罚发布成功！");
                                this.Close();
                            }
                        }
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
