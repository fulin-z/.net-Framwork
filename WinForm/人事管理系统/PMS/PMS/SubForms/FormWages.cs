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
    public partial class FormWages : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public string YDate;
        public FormWages()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormWages_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                toolStripComboBox1.Items.Add(i + "月");
            }
            DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,EmployeeSex as 员工性别,Dept as 所属部门,Post as 职务,BaseWages as 基本工资,Rewards as 所得奖励,Punishments as 所得罚款,YFWages as 应发工资,Tax as 个人所得税,SFWages as 实发工资,People as 结算人,DateTime as 结算时间 from tb_Wages", "tb_Wages");
            dataGridView1.DataSource = ds.Tables["tb_Wages"];
        }

        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            YDate = toolStripComboBox1.SelectedItem.ToString().Substring(0, 1);//1-12
            if (toolStripComboBox1.Text == "")
            {
                DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,EmployeeSex as 员工性别,Dept as 所属部门,Post as 职务,BaseWages as 基本工资,Rewards as 所得奖励,Punishments as 所得罚款,YFWages as 应发工资,Tax as 个人所得税,SFWages as 实发工资,People as 结算人,DateTime as 结算时间 from tb_Wages", "tb_Wages");
                dataGridView1.DataSource = ds.Tables["tb_Wages"];
            }
            else
            {
                DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,EmployeeSex as 员工性别,Dept as 所属部门,Post as 职务,BaseWages as 基本工资,Rewards as 所得奖励,Punishments as 所得罚款,YFWages as 应发工资,Tax as 个人所得税,SFWages as 实发工资,People as 结算人,DateTime as 结算时间 from tb_Wages where Date='" + YDate + "'", "tb_Wages");
                dataGridView1.DataSource = ds.Tables["tb_Wages"];
            }
        }
    }
}
