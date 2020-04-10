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
    public partial class FormUser : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        public FormUser()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textboxUserName.Text.Trim() == "" || textboxPwd.Text.Trim() == "" || comboBoxRight.Text == "")
                {
                    MessageBox.Show("用户信息填写不完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_User where UserName='" + textboxUserName.Text.Trim() + "'");
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该用户已存在！");
                    }
                    else
                    {
                        datacon.getcom("insert into tb_User(UserName,UserPwd,UserRight) values" +
                            "('" + textboxUserName.Text.Trim() + "','" + textboxPwd.Text.Trim() + "','" + comboBoxRight.Text + "')");
                        MessageBox.Show("用户信息添加成功！");
                        textboxUserName.Text = "";
                        textboxPwd.Text = "";
                        FormUser_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select ID as 编号,UserName as 用户名,UserPwd as 用户密码,UserRight as 用户权限,LoginTime as 最近登录时间 from tb_User", "tb_User");
            dataGridViewUser.DataSource = ds.Tables["tb_User"];
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                datacon.getcom("delete from tb_User where ID="
                    + Convert.ToString(dataGridViewUser[0, dataGridViewUser.CurrentCell.RowIndex].Value).Trim() + "");
                MessageBox.Show("删除用户信息成功！");
                FormUser_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textboxUserName.Text == "" || textboxPwd.Text == "" || comboBoxRight.Text == "")
                {
                    MessageBox.Show("用户信息不完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_User where UserName='" + textboxUserName.Text + "'");
                    if (sqlread.Read())
                    {
                        datacon.getcom("update tb_User set UserPwd='" + textboxPwd.Text + "',UserRight='" + comboBoxRight.Text + "' where UserName='" + textboxUserName.Text + "'");
                        MessageBox.Show("用户信息修改成功！");
                        textboxUserName.Text = "";
                        textboxPwd.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("该用户不存在！");
                    }
                    FormUser_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string name = dataGridViewUser.SelectedCells[0].Value.ToString();
                string str = "select * from tb_User where UserName='" + name + "'";
                DataSet ds = datacon.getds(str, "tb_User");
                ds.Dispose();
                textboxUserName.Text = ds.Tables[0].Rows[0][1].ToString();
                textboxPwd.Text = ds.Tables[0].Rows[0][2].ToString();
                comboBoxRight.SelectedItem = ds.Tables[0].Rows[0][4].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
