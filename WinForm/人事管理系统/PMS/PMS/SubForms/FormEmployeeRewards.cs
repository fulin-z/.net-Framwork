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
    public partial class FormEmployeeRewards : Form
    {
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        DataBase.DataCon datacon = new DataBase.DataCon();
        public FormEmployeeRewards()
        {
            InitializeComponent();
        }

        private void FormEmployeeRewards_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,Dept as 所属部门,EmployeeJF as '" + "奖/罚" + "',EmployeeJFContent as '" + "奖/罚内容" + "',Rewards as 奖励金额,Punishments as 罚款金额,JFDate as 奖罚日期,CLPeople as 处理人,CLTime as 处理时间 from tb_Rewards", "tb_Rewards");
            dataGridView1.DataSource = ds.Tables["tb_Rewards"];
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormAddJF FAJF = new FormAddJF();
            FAJF.ShowDialog();
            FormEmployeeRewards_Load(sender, e);
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
                    string ID = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                    datacon.getcom("delete from tb_Rewards where ID='" + ID + "'");
                    MessageBox.Show("删除信息成功！");
                    FormEmployeeRewards_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Trim() == "")
            {
                DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,Dept as 所属部门,EmployeeJF as '" + "奖/罚" + "',EmployeeJFContent as '" + "奖/罚内容" + "',Rewards as 奖励金额,Punishments as 罚款金额,JFDate as 奖罚日期,CLPeople as 处理人,CLTime as 处理时间 from tb_Rewards", "tb_Rewards");
                dataGridView1.DataSource = ds.Tables["tb_Rewards"];
            }
            else
            {
                DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,Dept as 所属部门,EmployeeJF as '" + "奖/罚" + "',EmployeeJFContent as '" + "奖/罚内容" + "',Rewards as 奖励金额,Punishments as 罚款金额,JFDate as 奖罚日期,CLPeople as 处理人,CLTime as 处理时间 from tb_Rewards where EmployeeName like '%"+toolStripTextBox1.Text.Trim()+"%'", "tb_Rewards");
                dataGridView1.DataSource = ds.Tables["tb_Rewards"];
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormChangeJF FCJF = new FormChangeJF();
            int a = dataGridView1.CurrentRow.Index;
            FCJF.YGName = dataGridView1.Rows[a].Cells["员工姓名"].Value.ToString();
            FCJF.YGID = dataGridView1.Rows[a].Cells["员工编号"].Value.ToString();
            FCJF.ID = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
            FCJF.ShowDialog();
            FormEmployeeRewards_Load(sender, e);
        }
    }
}
