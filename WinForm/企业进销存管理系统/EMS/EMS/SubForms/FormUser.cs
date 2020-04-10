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
    public partial class FormUser : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select ID as 编号,UserName as 用户名,UserPwd as 用户密码,UserRight as 用户权限,LoginTime as 最近登录时间 from tb_User", "tb_User");
            dataGridView1.DataSource = ds.Tables["tb_User"];
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxUserName.Text.Trim() == "" || txtboxPwd.Text.Trim() == "" || cbbRight.Text == "")
                {
                    MessageBox.Show("用户信息填写不完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_User where UserName='" + txtboxUserName.Text.Trim() + "'");
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该用户已存在！");
                    }
                    else
                    {
                        datacon.getcom("insert into tb_User(UserName,UserPwd,UserRight) values" +
                            "('" + txtboxUserName.Text.Trim() + "','" + txtboxPwd.Text.Trim() + "','" + cbbRight.Text + "')");
                        MessageBox.Show("用户信息添加成功！");
                        txtboxUserName.Text = "";
                        txtboxPwd.Text = "";
                        FormUser_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxUserName.Text == "" || txtboxPwd.Text == "" || cbbRight.Text == "")
                {
                    MessageBox.Show("用户信息不完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_User where UserName='" + txtboxUserName.Text + "'");
                    if (sqlread.Read())
                    {
                        datacon.getcom("update tb_User set UserPwd='" + txtboxPwd.Text + "',UserRight='" + cbbRight.Text + "' where UserName='" + txtboxUserName.Text + "'");
                        MessageBox.Show("用户信息修改成功！");
                        txtboxUserName.Text = "";
                        txtboxPwd.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("该用户不存在！");
                    }
                    FormUser_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = dataGridView1.CurrentRow.Index;
                txtboxUserName.Text = dataGridView1.Rows[a].Cells["用户名"].Value.ToString();
                txtboxPwd.Text = dataGridView1.Rows[a].Cells["用户密码"].Value.ToString();
                cbbRight.SelectedItem = dataGridView1.Rows[a].Cells["用户权限"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridView1.CurrentRow.Index;
                string ID = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                datacon.getcom("delete from tb_User where ID="
                    + ID + "");
                MessageBox.Show("删除用户信息成功！");
                FormUser_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
