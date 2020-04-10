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
    public partial class FormChangeJF : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormChangeJF()
        {
            InitializeComponent();
        }

        public string YGName;
        public string YGID;
        public string ID;
        private void FormChangeJF_Load(object sender, EventArgs e)
        {
            this.Text = "[ " + YGName + " ]" + "的奖罚信息";
            DataSet ds = datacon.getds("select * from tb_Rewards where EmployeeID='" + YGID + "'", "tb_Rewards");
            ds.Dispose();
            txtYGNum.Text = YGID;
            cbbUserJFType.Text = ds.Tables[0].Rows[0][4].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDept.Text = ds.Tables[0].Rows[0][3].ToString();
            txtJFcontent.Text = ds.Tables[0].Rows[0][5].ToString();
            txtJL.Text = ds.Tables[0].Rows[0][6].ToString();
            txtFK.Text = ds.Tables[0].Rows[0][7].ToString();
            txtJFdate.Text = ds.Tables[0].Rows[0][8].ToString();
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

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbUserJFType.Text == "奖励")
                {
                    if (txtJFcontent.Text.Trim() == "")
                    {
                        MessageBox.Show("请将信息填写完整！");
                    }
                    else if (txtJL.Text.Trim() == "0")
                    {
                        MessageBox.Show("金额不可为0！");
                    }
                    else
                    {
                        datacon.getcom("update tb_Rewards set EmployeeJF='" + cbbUserJFType.Text + "',EmployeeJFContent='" + txtJFcontent.Text + "',Rewards='" + txtJL.Text + "',Punishments='" + txtFK.Text + "' where ID='" + ID + "'");
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                }
                else
                {
                    if (txtJFcontent.Text.Trim() == "")
                    {
                        MessageBox.Show("请将信息填写完整！");
                    }
                    else if (txtFK.Text.Trim() == "0")
                    {
                        MessageBox.Show("金额不可为0！");
                    }
                    else
                    {
                        datacon.getcom("update tb_Rewards set EmployeeJF='" + cbbUserJFType.Text + "',EmployeeJFContent='" + txtJFcontent.Text + "',Punishments='" + txtFK.Text + "',Rewards='" + txtJL.Text + "' where ID='" + ID + "'");
                        MessageBox.Show("修改成功！");
                        this.Close();
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
