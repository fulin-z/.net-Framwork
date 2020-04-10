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
    public partial class FormAddEmployeeChange : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormAddEmployeeChange()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddEmployeeChange_Load(object sender, EventArgs e)
        {
            doperate.cboxBind("select EmployeeID from tb_Employee", "tb_Employee", "EmployeeID", cbbnum);
            doperate.cboxBind("select DeptName from tb_Department", "tb_Department", "DeptName", cbbdep2);
        }

        private void Cbbnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader sqlread = datacon.getread("select * from tb_Employee where EmployeeID='" + cbbnum.Text + "'");
                if (sqlread.Read())
                {
                    txtname.Text = sqlread["EmployeeName"].ToString();
                    txtdep1.Text = sqlread["EmployeeDept"].ToString();
                    txtjob1.Text = sqlread["Post"].ToString();
                    txtpay1.Text = sqlread["Wages"].ToString();
                }
                cbbdep2.Text = txtdep1.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtexplain.Text.Trim() == "" || txtjob2.Text.Trim() == "" || txtNewPay.Text.Trim() == "")
                {
                    MessageBox.Show("请将信息补充完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_Change where EmployeeID='" + cbbnum.Text + "'");
                    if (sqlread.Read())
                    {
                        MessageBox.Show("已存在该员工的调动信息，请直接前往修改！");
                    }
                    else
                    {
                        datacon.getcom("insert into tb_Change(EmployeeID,EmployeeName,OldDept,NewDept,OldPost,NewPost,OldWages,NewWages,EditDate,EditContent) " +
                        "values('" + cbbnum.Text + "','" + txtname.Text + "','" + txtdep1.Text + "','" + cbbdep2.Text + "','" + txtjob1.Text + "','" + txtjob2.Text + "','" + txtpay1.Text + "','" + txtNewPay.Text + "','" + txtdate.Text + "','" + txtexplain.Text + "')");
                        datacon.getcom("update tb_Employee set EmployeeDept='" + cbbdep2.Text + "',Post='" + txtjob2.Text + "',Wages='" + txtNewPay.Text + "' where EmployeeID='" + cbbnum.Text + "'");
                        MessageBox.Show("员工调动成功！");
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
