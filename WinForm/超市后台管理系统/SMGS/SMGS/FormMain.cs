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
    public partial class FormMain : Form
    {
        private Timer timer;
        database.DataCon datacon = new database.DataCon();
        public static string L_UserName;
        public static string L_UserRight;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer = new Timer();   //定义计时器
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            SqlConnection sqlcon = datacon.getcon();
            SqlCommand cmd = new SqlCommand("select UserName,UserRight from tb_User where StatusCode = 1", sqlcon);
            sqlcon.Open();
            SqlDataReader sqlread = cmd.ExecuteReader();
            if (sqlread.Read())
            {
                labelUser.Text = sqlread["UserName"].ToString();
                labelRight.Text = sqlread["UserRight"].ToString();
                L_UserName = labelUser.Text;
                L_UserRight = labelRight.Text;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            datacon.getcom("update tb_User set StatusCode=0 where UserName = '" + labelUser.Text + "'");
            Application.Exit();
        }

        private void BtnUM_Click(object sender, EventArgs e)
        {
            if (L_UserRight == "管理员")
            {
                SubForms.FormUserManage UM = new SubForms.FormUserManage();
                UM.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足！");
            }
        }

        private void BtnRI_Click(object sender, EventArgs e)
        {
            if (L_UserRight == "管理员")
            {
                SubForms.FormRightManage RM = new SubForms.FormRightManage();
                RM.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足！");
            }
        }

        private void BtnEP_Click(object sender, EventArgs e)
        {
            SubForms.FormChangePwd CP = new SubForms.FormChangePwd();
            CP.ShowDialog();
        }

        private void BtnGM_Click(object sender, EventArgs e)
        {

        }

        private void BtnPI_Click(object sender, EventArgs e)
        {
            if (L_UserRight == "管理员")
            {
                SubForms.FormSupplierManage SM = new SubForms.FormSupplierManage();
                SM.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足！");
            }
        }

        private void BtnGI_Click(object sender, EventArgs e)
        {

        }

        private void BtnIS_Click(object sender, EventArgs e)
        {
            if (FormMain.L_UserRight == "管理员")
            {
                SubForms.FormWareHousingManage WHM = new SubForms.FormWareHousingManage();
                WHM.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足！");
            }
        }

        private void BtnGOL_Click(object sender, EventArgs e)
        {
            if (FormMain.L_UserRight == "管理员")
            {
                SubForms.FormWareHousingRecords WHR = new SubForms.FormWareHousingRecords();
                WHR.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足！");
            }
        }

        private void BtnCM_Click(object sender, EventArgs e)
        {
            SubForms.FormInventory It = new SubForms.FormInventory();
            It.ShowDialog();
        }

        private void BtnOS_Click(object sender, EventArgs e)
        {
            SubForms.FormGoodsSale GS = new SubForms.FormGoodsSale();
            GS.ShowDialog();
        }

        private void BtnGIL_Click(object sender, EventArgs e)
        {
            if (FormMain.L_UserRight == "管理员")
            {
                SubForms.FormSaleRecords SR = new SubForms.FormSaleRecords();
                SR.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足！");
            }
        }

        private void BtnBR_Click(object sender, EventArgs e)
        {
            SubForms.FormGoodsReturn GR = new SubForms.FormGoodsReturn();
            GR.ShowDialog();
        }

        private void BtnWG_Click(object sender, EventArgs e)
        {
            if (FormMain.L_UserRight == "管理员")
            {
                SubForms.FormReturnRecords RR = new SubForms.FormReturnRecords();
                RR.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足！");
            }
        }
    }
}
