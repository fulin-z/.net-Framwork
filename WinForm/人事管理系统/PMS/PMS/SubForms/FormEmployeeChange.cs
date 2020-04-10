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
    public partial class FormEmployeeChange : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormEmployeeChange()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormAddEmployeeChange FAEC = new FormAddEmployeeChange();
            FAEC.ShowDialog();
            FormEmployeeChange_Load(sender, e);
        }

        private void FormEmployeeChange_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,OldDept as 原部门,NewDept as 现部门,OldPost as 原职务,NewPost as 现职务,OldWages as 原工资,NewWages as 现工资,EditContent as 调动说明,EditDate as 调动日期 from tb_Change", "tb_Change");
            dataGridView1.DataSource = ds.Tables["tb_Change"];
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
                    datacon.getcom("delete from tb_Change where ID='" + ID + "'");
                    MessageBox.Show("删除信息成功！");
                    FormEmployeeChange_Load(sender, e);
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
                DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,OldDept as 原部门,NewDept as 现部门,OldPost as 原职务,NewPost as 现职务,OldWages as 原工资,NewWages as 现工资,EditContent as 调动说明,EditDate as 调动日期 from tb_Change", "tb_Change");
                dataGridView1.DataSource = ds.Tables["tb_Change"];
            }
            else
            {
                DataSet ds = datacon.getds("select ID as 编号,EmployeeID as 员工编号,EmployeeName as 员工姓名,OldDept as 原部门,NewDept as 现部门,OldPost as 原职务,NewPost as 现职务,OldWages as 原工资,NewWages as 现工资,EditContent as 调动说明,EditDate as 调动日期 from tb_Change where EmployeeName like '%"+toolStripTextBox1.Text+"%'", "tb_Change");
                dataGridView1.DataSource = ds.Tables["tb_Change"];
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormEditEmployeeChange FEEC = new FormEditEmployeeChange();
            int a = dataGridView1.CurrentRow.Index;
            FEEC.YGName = dataGridView1.Rows[a].Cells["员工姓名"].Value.ToString();
            FEEC.ID = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
            FEEC.ShowDialog();
            FormEmployeeChange_Load(sender, e);
        }
    }
}
