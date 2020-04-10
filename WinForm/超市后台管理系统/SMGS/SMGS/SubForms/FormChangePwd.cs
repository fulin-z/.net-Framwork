using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMGS.SubForms
{
    public partial class FormChangePwd : Form
    {
        database.DataCon datacon = new database.DataCon();
        public FormChangePwd()
        {
            InitializeComponent();
        }

        private void FormChangePwd_Load(object sender, EventArgs e)
        {
            txtUName.Text = FormMain.L_UserName;
        }

        private void BtnSure_Click(object sender, EventArgs e)
        {
            if (txtUNPwd.Text.Trim() != txtFUNPwd.Text.Trim())
            {
                MessageBox.Show("两次输入密码不一致，请重新输入！");
            }
            else if (txtUNPwd.Text.Trim() == "" || txtFUNPwd.Text.Trim() == "")
            {
                MessageBox.Show("密码不可为空！");
            }
            else
            {
                if (txtUOPwd.Text.Trim() != FormLogin.L_pwd)
                {
                    MessageBox.Show("用户旧密码输入错误，请重新输入！");
                }
                else
                {
                    datacon.getcom("update tb_User set UserPwd='" + txtUNPwd.Text.Trim() + "'where UserName='" + txtUName.Text.Trim() + "'");
                    MessageBox.Show("密码修改成功！");
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
