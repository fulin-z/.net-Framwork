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
    public partial class FormSettlementWage : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public string Ydate;
        public FormSettlementWage()
        {
            InitializeComponent();
        }

        private void 按姓名查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSettlementWage_Load(object sender, EventArgs e)
        {
            txtYbasepay.Text = "0";
            for (int i = 1; i <= 12; i++)
            {
                toolStripComboBox1.Items.Add(i + "月");
            }
            doperate.cboxBind("select EmployeeID from tb_Employee", "tb_Employee", "EmployeeID", cbbYnum);
            txtPeople.Text = FormLogin.L_UserName;
        }

        private void CbbYnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader sqlread = datacon.getread("select * from tb_Employee where EmployeeID='" + cbbYnum.Text + "'");
                if (sqlread.Read())
                {
                    txtYname.Text = sqlread["EmployeeName"].ToString();
                    txtYsex.Text = sqlread["EmployeeSex"].ToString();
                    txtYdep.Text = sqlread["EmployeeDept"].ToString();
                    txtYzhiwu.Text = sqlread["Post"].ToString();
                    txtYbasepay.Text = sqlread["Wages"].ToString();
                }
                DataSet ds = datacon.getds("select * from tb_Rewards where EmployeeID='" + cbbYnum.Text + "'", "tb_Rewards");
                SqlConnection conn = datacon.getcon();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from tb_Rewards where EmployeeID='" + cbbYnum.Text + "'", conn);
                int i = (int)cmd.ExecuteScalar();
                conn.Close();
                if (i > 0)
                {
                    if (ds.Tables[0].Rows[0][8].ToString().Substring(5, 1) == Ydate)
                    {
                        txtYjiangli.Text = ds.Tables[0].Rows[0][6].ToString();
                        txtYfakuan.Text = ds.Tables[0].Rows[0][7].ToString();
                    }
                    else
                    {
                        txtYfakuan.Text = "0";
                        txtYjiangli.Text = "0";
                    }
                }
                else
                {
                    txtYfakuan.Text = "0";
                    txtYjiangli.Text = "0";
                }
                decimal yingfa = Convert.ToDecimal(txtYbasepay.Text) + Convert.ToDecimal(txtYjiangli.Text) - Convert.ToDecimal(txtYfakuan.Text);
                txtYyingfa.Text = Convert.ToString(yingfa);
                decimal GRSDShui = doperate.GRSDS(Convert.ToInt32(yingfa));
                txtYshui.Text = Convert.ToString(GRSDShui);
                decimal shifa = Convert.ToDecimal(yingfa) - Convert.ToDecimal(GRSDShui);
                txtYshifa.Text = Convert.ToString(shifa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbYnum.Enabled = true;
            Ydate = toolStripComboBox1.SelectedItem.ToString().Substring(0, 1);//1-12
            MessageBox.Show(toolStripComboBox1.SelectedItem.ToString());
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolStripComboBox1.Text == "")
                {
                    MessageBox.Show("请选择月份！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_Wages where EmployeeID='" + cbbYnum.Text + "' and Date='" + Ydate + "'");
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该员工" + Ydate + "月工资已发放！");
                    }
                    else
                    {
                        datacon.getcom("insert into tb_Wages(EmployeeID,EmployeeName,EmployeeSex,Dept,Post,BaseWages,Rewards,Punishments,YFWages,Tax,SFWages,People,DateTime,Date) " +
                            "values('" + cbbYnum.Text + "','" + txtYname.Text + "','" + txtYsex.Text + "','" + txtYdep.Text + "','" + txtYzhiwu.Text + "','" + txtYbasepay.Text + "','" + txtYjiangli.Text + "','" + txtYfakuan.Text + "','" + txtYyingfa.Text + "','" + txtYshui.Text + "','" + txtYshifa.Text + "','" + txtPeople.Text + "','" + DateTime.Now + "','" + Ydate + "')");
                        MessageBox.Show("该员工" + Ydate + "月工资发放成功！");
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
