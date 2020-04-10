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
    public partial class FormAddEmployee : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormAddEmployee()
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
                if (txtYGNum.Text == "" || txtYGName.Text == "" || cbbYGSex.Text == "" || comboBoxZZMM.Text == "" || txtSFZH.Text == "" || cboxYGminzu.Text == "" || cbbYGHunyin.Text == "" || txtYGzhiwu.Text == "" || txtYGPhone.Text == "" || comboBoxXL.Text == "" || txtYGPay.Text == "")
                {
                    MessageBox.Show("员工信息填写不完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_Employee where EmployeeID='" + txtYGNum.Text + "'");
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该员工编号已存在！");
                    }
                    else
                    {
                        datacon.getcom("insert into tb_Employee(EmployeeID,EmployeeName,EmployeeSex,EmployeeDept,Political,CardID,Birthday,FamousRace,Marriage,Post,Phone,Education,Wages,EntryDate,EditTime) " +
                            "values('" + txtYGNum.Text + "','" + txtYGName.Text + "','" + cbbYGSex.Text + "','" + cbbYGBumen.Text + "','" + comboBoxZZMM.Text + "','" + txtSFZH.Text + "','" + txtYGBirthday.Text + "','" + cboxYGminzu.Text + "','" + cbbYGHunyin.Text + "','" + txtYGzhiwu.Text + "','" + txtYGPhone.Text + "','" + comboBoxXL.Text + "','" + txtYGPay.Text + "','" + txtYGJiuzhi.Text + "','" + DateTime.Now + "')");
                        doperate.SaveImage(txtYGNum.Text.Trim(), openFileDialog1);
                        MessageBox.Show("员工信息添加成功！");
                        txtYGNum.Text = "";
                        txtYGName.Text = "";
                        txtSFZH.Text = "";
                        txtYGzhiwu.Text = "";
                        txtYGPhone.Text = "";
                        txtYGPay.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

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

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            doperate.cboxBind("select DeptName from tb_Department", "tb_Department", "DeptName", cbbYGBumen);
        }
    }
}
