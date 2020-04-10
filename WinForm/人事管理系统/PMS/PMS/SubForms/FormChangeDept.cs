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
    public partial class FormChangeDept : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        public string name;
        public FormChangeDept()
        {
            InitializeComponent();
        }

        private void ButtonCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChangeDept_Load(object sender, EventArgs e)
        {
            textBoxDeptName.Text = name;
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            try
            {
                datacon.getcom("update tb_Department set DeptName='" + textBoxDeptName.Text.Trim() + "' where DeptName='" + name + "'");
                MessageBox.Show("部门信息修改成功！");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
