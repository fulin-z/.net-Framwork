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

namespace EMS
{
    public partial class FormLogin : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        public static string L_UserName;//记录登录用户名
        public static string L_UserPwd;//记录登录密码
        public static string L_UserRight;//记录登录用户权限
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Trim() == "" || txtPWD.Text.Trim() == "")
                {
                    MessageBox.Show("用户名或密码不可为空！");
                }
                else
                {
                    string M_UserName = txtUserName.Text.Trim();
                    string M_UserPwd = txtPWD.Text.Trim();
                    SqlDataReader sqlread = datacon.getread("select * from tb_User where UserName='" + M_UserName + "' and UserPwd='" + M_UserPwd + "'");
                    if (sqlread.Read())
                    {
                        L_UserName = M_UserName;
                        L_UserPwd = M_UserPwd;
                        L_UserRight = sqlread["UserRight"].ToString();
                        string L_Time = DateTime.Now.ToString();
                        datacon.getcom("update tb_User set LoginTime='" + L_Time + "' where UserName='" + M_UserName + "'");
                        FormMain fmain = new FormMain();
                        this.Hide();
                        fmain.Show();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码输入错误！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
