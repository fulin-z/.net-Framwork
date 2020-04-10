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
    public partial class FormAddEvaluation : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormAddEvaluation()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddEvaluation_Load(object sender, EventArgs e)
        {
            doperate.cboxBind("select EmployeeID from tb_Employee", "tb_Employee", "EmployeeID", cbbnum);
            txtkp.Text = FormLogin.L_UserName;
        }

        private void Cbbnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader sqlread = datacon.getread("select * from tb_Employee where EmployeeID='" + cbbnum.Text + "'");
                if (sqlread.Read())
                {
                    txtname.Text = sqlread["EmployeeName"].ToString();
                    txtdep.Text = sqlread["EmployeeDept"].ToString();
                }
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
                if (txtcontent.Text.Trim() == "" || txtresult.Text.Trim() == "" || txtscore.Text.Trim() == "")
                {
                    MessageBox.Show("请将信息填写完整！");
                }
                else
                {
                    datacon.getcom("insert into tb_Evaluation(EmployeeID,EmployeeName,Dept,Contents,Result,Core,People,EvaluationDate,EvaluationTime) " +
                        "values('" + cbbnum.Text + "','" + txtname.Text + "','" + txtdep.Text + "','" + txtcontent.Text + "','" + txtresult.Text + "','" + txtscore.Text + "','" + txtkp.Text + "','" + txtkpdate.Text + "','" + DateTime.Now + "')");
                    MessageBox.Show("添加成功！");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
