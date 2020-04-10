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
    public partial class FormEvaluation : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormEvaluation()
        {
            InitializeComponent();
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormAddEvaluation FAE = new FormAddEvaluation();
            FAE.ShowDialog();
            FormEvaluation_Load(sender, e);
        }

        private void FormEvaluation_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,Dept as 所属部门,Contents as 考评内容,Result as 考评结果,Core as 考评分数,People as 考评人,EvaluationDate as 考评日期,EvaluationTime as 考评时间 from tb_Evaluation", "tb_Evaluation");
            dataGridView1.DataSource = ds.Tables["tb_Evaluation"];
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Trim() == "")
            {
                DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,Dept as 所属部门,Contents as 考评内容,Result as 考评结果,Core as 考评分数,People as 考评人,EvaluationDate as 考评日期,EvaluationTime as 考评时间 from tb_Evaluation", "tb_Evaluation");
                dataGridView1.DataSource = ds.Tables["tb_Evaluation"];
            }
            else
            {
                DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,Dept as 所属部门,Contents as 考评内容,Result as 考评结果,Core as 考评分数,People as 考评人,EvaluationDate as 考评日期,EvaluationTime as 考评时间 from tb_Evaluation where EmployeeName like '%"+toolStripTextBox1.Text.Trim()+"%'", "tb_Evaluation");
                dataGridView1.DataSource = ds.Tables["tb_Evaluation"];
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
                    string ID = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                    datacon.getcom("delete from tb_Evaluation where ID='" + ID + "'");
                    MessageBox.Show("删除信息成功！");
                    FormEvaluation_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormChangeEvaluation FCE = new FormChangeEvaluation();
            int a = dataGridView1.CurrentRow.Index;
            FCE.YGID = dataGridView1.Rows[a].Cells["员工编号"].Value.ToString();
            FCE.ID = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
            FCE.YGName = dataGridView1.Rows[a].Cells["员工姓名"].Value.ToString();
            FCE.ShowDialog();
            FormEvaluation_Load(sender, e);
        }
    }
}
