using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.SubForms
{
    public partial class FormUserPwd : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        public FormUserPwd()
        {
            InitializeComponent();
        }

        private void FormUserPwd_Load(object sender, EventArgs e)
        {
            txtboxUserName.Text = FormLogin.L_UserName;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSure_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxNewPwd.Text.Trim() != txtboxNNewPwd.Text.Trim())
                {
                    MessageBox.Show("两次新密码输入不一致，请重试！");
                }
                else if (txtboxOldPwd.Text.Trim() == "" || txtboxNewPwd.Text.Trim() == "")
                {
                    MessageBox.Show("密码不可为空！");
                }
                else if (txtboxOldPwd.Text.Trim() == txtboxNewPwd.Text.Trim())
                {
                    MessageBox.Show("新密码不可与旧密码相同！");
                }
                else
                {
                    if (txtboxOldPwd.Text.Trim() != FormLogin.L_UserPwd)
                    {
                        MessageBox.Show("旧密码输入错误！");
                    }
                    else
                    {
                        datacon.getcom("update tb_User set UserPwd='" + txtboxNewPwd.Text.Trim() + "' where UserName='" + txtboxUserName.Text + "'");
                        MessageBox.Show("密码修改成功，请重新登录！");
                        Application.Restart();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
