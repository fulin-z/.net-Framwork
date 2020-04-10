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
    public partial class FormDeptManagement : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        public TreeNode tn;
        public FormDeptManagement()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormAddDept FAD = new FormAddDept();
            FAD.ShowDialog();
            treeViewDept.Nodes.Clear();
            FormDeptManagement_Load(sender, e);
        }

        public void FormDeptManagement_Load(object sender, EventArgs e)
        {
            tn = treeViewDept.Nodes.Add("所有部门");//父节点
            SqlDataReader sqlread = datacon.getread("select * from tb_Department");
            while (sqlread.Read())
            {
                tn.Nodes.Add(sqlread["DeptName"].ToString());//子节点
            }
            treeViewDept.ExpandAll();
            treeViewDept.SelectedNode = treeViewDept.Nodes[0];//设置窗体加载时，treeview控件的父节点被选中
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewDept.SelectedNode.Text == "所有部门")
            {
                MessageBox.Show("不能修改根目录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string depName = treeViewDept.SelectedNode.Text;
                FormChangeDept changedep = new FormChangeDept();
                changedep.name = depName;
                changedep.ShowDialog();
            }
            treeViewDept.Nodes.Clear();
            FormDeptManagement_Load(sender, e);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewDept.SelectedNode.Text == "所有部门")
            {
                MessageBox.Show("不能删除根目录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string depname = treeViewDept.SelectedNode.Text;
                datacon.getcom("delete from tb_Department where DeptName='" + depname + "'");
                MessageBox.Show("部门删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                treeViewDept.Nodes.Clear();
                FormDeptManagement_Load(sender, e);
            }
        }
    }
}
