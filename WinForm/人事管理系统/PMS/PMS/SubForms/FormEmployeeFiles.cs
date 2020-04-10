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
    public partial class FormEmployeeFiles : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormEmployeeFiles()
        {
            InitializeComponent();
        }

        private void FormEmployeeFiles_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = datacon.getcon();
            SqlCommand cmd = new SqlCommand("select count(*) from tb_Employee", sqlcon);
            sqlcon.Open();
            int i = (int)cmd.ExecuteScalar();
            sqlcon.Close();
            labelNum.Text = i + "人";
            DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,EmployeeSex as 性别,EmployeeDept as 所属部门,Political as 政治面貌,CardID as 身份证号,Birthday as 出生日期,FamousRace as 民族,Marriage as 婚姻状况,Post as 职务,Phone as 手机号码,Education as 学历,Wages as 工资,EntryDate as 入职日期,EditTime as 编辑时间 from tb_Employee", "tb_Employee");
            dataGridView1.DataSource = ds.Tables["tb_Employee"];
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormAddEmployee FAE = new FormAddEmployee();
            FAE.ShowDialog();
            FormEmployeeFiles_Load(sender, e);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int a = dataGridView1.CurrentRow.Index;
                    string YGID = dataGridView1.Rows[a].Cells["员工编号"].Value.ToString();
                    doperate.Get_Image(YGID, pictureBox1);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count == 0)
                {
                    MessageBox.Show("请选择要删除的数据！");
                }
                else
                {
                    int a = dataGridView1.CurrentRow.Index;
                    string YGID = dataGridView1.Rows[a].Cells["员工编号"].Value.ToString();
                    datacon.getcom("delete from tb_Employee where EmployeeID='" + YGID + "'");
                    MessageBox.Show("删除信息成功！");
                    FormEmployeeFiles_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridView1.CurrentRow.Index;
                string YGName = dataGridView1.Rows[a].Cells["员工姓名"].Value.ToString();
                SubForms.FormEmployeeInfo FEI = new FormEmployeeInfo();
                FEI.YGName = YGName;
                FEI.YGID = dataGridView1.Rows[a].Cells["员工编号"].Value.ToString();
                FEI.ShowDialog();
                FormEmployeeFiles_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Trim() == "")
            {
                DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,EmployeeSex as 性别,EmployeeDept as 所属部门,Political as 政治面貌,CardID as 身份证号,Birthday as 出生日期,FamousRace as 民族,Marriage as 婚姻状况,Post as 职务,Phone as 手机号码,Education as 学历,Wages as 工资,EntryDate as 入职日期,EditTime as 编辑时间 from tb_Employee", "tb_Employee");
                dataGridView1.DataSource = ds.Tables["tb_Employee"];
            }
            else
            {
                DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,EmployeeSex as 性别,EmployeeDept as 所属部门,Political as 政治面貌,CardID as 身份证号,Birthday as 出生日期,FamousRace as 民族,Marriage as 婚姻状况,Post as 职务,Phone as 手机号码,Education as 学历,Wages as 工资,EntryDate as 入职日期,EditTime as 编辑时间 from tb_Employee where EmployeeName like '%"+toolStripTextBox1.Text.Trim()+"%'", "tb_Employee");
                dataGridView1.DataSource = ds.Tables["tb_Employee"];
            }
        }
    }
}
