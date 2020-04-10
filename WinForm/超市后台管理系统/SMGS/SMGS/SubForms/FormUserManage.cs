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

namespace SMGS.SubForms
{
    public partial class FormUserManage : Form
    {
        database.DataCon datacon = new database.DataCon();
        database.DataOperate doperate = new database.DataOperate();
        public FormUserManage()
        {
            InitializeComponent();
        }

        private void FormUserManage_Load(object sender, EventArgs e)
        {
            DataSet myds = datacon.getds("select ID as 用户编号,UserName as 用户名,UserPwd as 用户密码,"
                + "UserRight as 用户权限 from tb_User", "tb_User");
            dgvUInfo.DataSource = myds.Tables["tb_User"];
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUName.Text == "" || txtUPwd.Text == "" || cboxURight.Text == "")
                {
                    MessageBox.Show("新增用户信息不完全！请完善信息！");
                }
                else
                {
                    SqlConnection sqlcon = datacon.getcon();
                    SqlCommand cmd = new SqlCommand("select * from tb_User where UserName = '" + txtUName.Text + "'", sqlcon);
                    sqlcon.Open();
                    SqlDataReader sqlread = cmd.ExecuteReader();
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该用户已经存在！");
                    }
                    else
                    {
                        datacon.getcom("insert into tb_User(UserName,UserPwd,UserRight) values('" + txtUName.Text + "','" + txtUPwd.Text + "','" + cboxURight.Text + "')");
                        MessageBox.Show("用户信息添加成功！");
                        FormUserManage_Load(sender, e);
                    }
                }
                FormUserManage_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                datacon.getcom("delete from tb_User where ID="
                    + Convert.ToString(dgvUInfo[0, dgvUInfo.CurrentCell.RowIndex].Value).Trim() + "");
                MessageBox.Show("删除用户信息成功！");
                FormUserManage_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUName.Text == "" && txtUPwd.Text == "" && cboxURight.Text == "")
                {
                    MessageBox.Show("请输入修改信息！");
                }
                else
                {
                    datacon.getcom("update tb_User set UserName='" + txtUName.Text + "',UserPwd = '" + txtUPwd.Text + "'" +
                   ",UserRight='" + cboxURight.Text + "' where ID= '" + Convert.ToInt32(dgvUInfo[0, dgvUInfo.CurrentCell.RowIndex].Value) + "'");
                    MessageBox.Show("信息修改成功！");
                    FormUserManage_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
