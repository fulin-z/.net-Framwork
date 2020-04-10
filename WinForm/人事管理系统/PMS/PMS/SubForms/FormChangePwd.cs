using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.SubForms
{
    public partial class FormChangePwd : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        public FormChangePwd()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChangePwd_Load(object sender, EventArgs e)
        {
            textboxUserName.Text = FormLogin.L_UserName;
        }

        private void BtnSure_Click(object sender, EventArgs e)
        {
            try
            {
                if (textboxNewPwd.Text.Trim() != textboxNNewPwd.Text.Trim())
                {
                    MessageBox.Show("两次密码输入不一致，请重试！");
                }
                else if (textboxOldPwd.Text.Trim() == "" || textboxNewPwd.Text.Trim() == "")
                {
                    MessageBox.Show("密码不可为空！");
                }
                else
                {
                    if (textboxOldPwd.Text.Trim() != FormLogin.L_UserPwd)
                    {
                        MessageBox.Show("旧密码输入错误！");
                    }
                    else
                    {
                        datacon.getcom("update tb_User set UserPwd='" + textboxNewPwd.Text.Trim() + "' where UserName='" + textboxUserName.Text + "'");
                        MessageBox.Show("密码修改成功，请重新登录！");
                        Application.Restart();
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
