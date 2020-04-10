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
    public partial class FormEmployeeInfo : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormEmployeeInfo()
        {
            InitializeComponent();
        }
        public string YGName;
        public string YGID;
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYGNum.Text == "" || txtYGName.Text == "" || cbbYGSex.Text == "" || comboBoxZZMM.Text == "" || txtSFZH.Text == "" || cboxYGminzu.Text == "" || cbbYGHunyin.Text == "" || txtYGzhiwu.Text == "" || txtYGPhone.Text == "" || comboBoxXL.Text == "" || txtYGPay.Text == "")
                {
                    MessageBox.Show("员工信息填写不完整！");
                }
                else
                {
                    datacon.getcom("update tb_Employee set EmployeeName='" + txtYGName.Text + "',EmployeeSex='" + cbbYGSex.Text + "',EmployeeDept='" + cbbYGBumen.Text + "',Political='" + comboBoxZZMM.Text + "',CardID='" + txtSFZH.Text + "',Birthday='" + txtYGBirthday.Text + "',FamousRace='" + cboxYGminzu.Text + "',Marriage='" + cbbYGHunyin.Text + "',Post='" + txtYGzhiwu.Text + "',Phone='" + txtYGPhone.Text + "',Education='" + comboBoxXL.Text + "',Wages='" + txtYGPay.Text + "',EntryDate='" + txtYGJiuzhi.Text + "',EditTime='" + DateTime.Now + "' where EmployeeID='" + YGID + "'");
                    if(openFileDialog1.FileName== "openFileDialog1") { }
                    else
                    {
                        doperate.SaveImage(YGID, openFileDialog1);
                    }
                    MessageBox.Show("员工信息修改成功！");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormEmployeeInfo_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "[ " + YGName + " ]的个人信息";
                doperate.cboxBind("select DeptName from tb_Department", "tb_Department", "DeptName", cbbYGBumen);
                DataSet ds = datacon.getds("select * from tb_Employee where EmployeeID='" + YGID + "'", "tb_Employee");
                ds.Dispose();
                txtYGNum.Text = ds.Tables[0].Rows[0][1].ToString();
                txtYGName.Text = ds.Tables[0].Rows[0][2].ToString();
                cbbYGSex.Text = ds.Tables[0].Rows[0][3].ToString();
                cbbYGBumen.Text = ds.Tables[0].Rows[0][4].ToString();
                comboBoxZZMM.Text = ds.Tables[0].Rows[0][5].ToString();
                txtSFZH.Text = ds.Tables[0].Rows[0][6].ToString();
                txtYGBirthday.Text = ds.Tables[0].Rows[0][7].ToString();
                cboxYGminzu.Text = ds.Tables[0].Rows[0][8].ToString();
                cbbYGHunyin.Text = ds.Tables[0].Rows[0][9].ToString();
                txtYGzhiwu.Text = ds.Tables[0].Rows[0][10].ToString();
                txtYGPhone.Text = ds.Tables[0].Rows[0][11].ToString();
                comboBoxXL.Text = ds.Tables[0].Rows[0][12].ToString();
                txtYGPay.Text = ds.Tables[0].Rows[0][13].ToString();
                txtYGJiuzhi.Text = ds.Tables[0].Rows[0][14].ToString();
                doperate.Get_Image(YGID, pictureBox1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                doperate.Read_Image(openFileDialog1, pictureBox1);
            }
            catch
            {
                MessageBox.Show("加载图片出错");
            }
        }
    }
}
