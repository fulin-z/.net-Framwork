using SMGS.database;
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

namespace SMGS
{
    public partial class FormLogin : Form
    {
        public static string L_name;        //记录登录用户名字
        public static string L_pwd;         //记录登录用户密码
        public static string L_right;       //记录登录用户的权限
        database.DataCon datacon =new database.DataCon();
        database.DataOperate doperate = new database.DataOperate();
        public FormLogin()
        {
            InitializeComponent();
        }

        public void CboxUName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlcon = datacon.getcon();
            SqlCommand cmd = new SqlCommand("select UserRight from tb_User where UserName = '"+ cboxUName.Text + "'", sqlcon);
            sqlcon.Open();
            SqlDataReader sqlread = cmd.ExecuteReader();
            if (sqlread.Read())
            {
                labURight.Text = sqlread["UserRight"].ToString();
                L_right = labURight.Text;
            }
            sqlread.Close();
        }

        public void FormLogin_Load(object sender, EventArgs e)
        {
            doperate.cboxBind("select UserName from tb_User", "tb_User", "UserName", cboxUName);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = datacon.getcon();
            SqlCommand cmd = new SqlCommand("select UserPwd from tb_User where UserName = '" + cboxUName.Text + "'", sqlcon);
            sqlcon.Open();
            SqlDataReader sqlread = cmd.ExecuteReader();
            if (sqlread.Read())
            {
                L_pwd = sqlread["UserPwd"].ToString();
                if(L_pwd == txtPwd.Text)
                {
                    datacon.getcom("update tb_User set StatusCode=1 where UserName = '" + cboxUName.Text + "'");
                    FormMain fmain = new FormMain();
                    this.Hide();
                    fmain.Show();
                }
                else
                {
                    MessageBox.Show("密码错误！请重试！");
                }
            }
            sqlread.Close();
        }
    }
}
