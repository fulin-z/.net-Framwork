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
    public partial class FormEditEmployeeChange : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public string YGName;
        public string ID;
        public FormEditEmployeeChange()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditEmployeeChange_Load(object sender, EventArgs e)
        {
            this.Text = "[ " + YGName + " ]" + "的调动信息";
            doperate.cboxBind("select DeptName from tb_Department", "tb_Department", "DeptName", cbbdep2);
            DataSet ds = datacon.getds("select * from tb_Change where ID='" + ID + "'", "tb_Change");
            ds.Dispose();
            txtNum.Text = ds.Tables[0].Rows[0][1].ToString();
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtdep1.Text = ds.Tables[0].Rows[0][3].ToString();
            cbbdep2.Text = ds.Tables[0].Rows[0][4].ToString();
            txtjob1.Text = ds.Tables[0].Rows[0][5].ToString();
            txtjob2.Text = ds.Tables[0].Rows[0][6].ToString();
            txtpay1.Text = ds.Tables[0].Rows[0][7].ToString();
            txtNewPay.Text = ds.Tables[0].Rows[0][8].ToString();
            txtdate.Text = ds.Tables[0].Rows[0][9].ToString();
            txtexplain.Text = ds.Tables[0].Rows[0][10].ToString();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtjob2.Text.Trim() == "" || txtNewPay.Text.Trim() == "" || txtexplain.Text.Trim() == "")
                {
                    MessageBox.Show("请将信息填写完整！");
                }
                else
                {
                    datacon.getcom("update tb_Change set NewDept='" + cbbdep2.Text + "',NewPost='" + txtjob2.Text + "',NewWages='" + txtNewPay.Text + "',EditContent='" + txtexplain.Text + "' where ID='" + ID + "'");
                    datacon.getcom("update tb_Employee set EmployeeDept='" + cbbdep2.Text + "',Post='" + txtjob2.Text + "',Wages='" + txtNewPay.Text + "' where EmployeeID='" + txtNum.Text + "'");
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
