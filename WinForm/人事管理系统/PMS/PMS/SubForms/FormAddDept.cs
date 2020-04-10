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
    public partial class FormAddDept : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        public FormAddDept()
        {
            InitializeComponent();
        }

        private void ButtonCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDeptName.Text.Trim() == "" )
                {
                    MessageBox.Show("部门名称不可为空！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_Department where DeptName='" + textBoxDeptName.Text.Trim() + "'");
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该部门已存在！");
                    }
                    else
                    {
                        datacon.getcom("insert into tb_Department(DeptName,Editer,EditTime) values" +
                            "('" + textBoxDeptName.Text.Trim() + "','" + FormLogin.L_UserName + "','" + DateTime.Now.ToString() + "')");
                        MessageBox.Show("部门信息添加成功！");
                        textBoxDeptName.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormAddDept_Load(object sender, EventArgs e)
        {
        }
    }
}
