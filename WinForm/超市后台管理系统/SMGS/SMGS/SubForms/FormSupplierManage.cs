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

namespace SMGS.SubForms
{
    public partial class FormSupplierManage : Form
    {
        database.DataCon datacon = new database.DataCon();
        database.DataOperate doperate = new database.DataOperate();
        public FormSupplierManage()
        {
            InitializeComponent();
        }

        private void FormSupplierManage_Load(object sender, EventArgs e)
        {
            DataSet myds = datacon.getds("select ID as 供应商编号,SupplierName as 供应商名称,Contacts as 负责人,"
                + "ContactPhone as 联系电话,Remark as 备注,Editer as 修改人,EditTime as 修改日期 from tb_Supplier", "tb_Supplier");
            dgvPInfo.DataSource = myds.Tables["tb_Supplier"];
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPName.Text.Trim() == "" || txtPLeader.Text.Trim() == "" || txtPPhone.Text.Trim() == "")
                {
                    MessageBox.Show("供应商信息输入不完整，请完善信息！");
                }
                else
                {
                    SqlConnection sqlcon = datacon.getcon();
                    SqlCommand cmd = new SqlCommand("select * from tb_Supplier where SupplierName = '" + txtPName.Text + "'", sqlcon);
                    sqlcon.Open();
                    SqlDataReader sqlread = cmd.ExecuteReader();
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该供应商已经存在！");
                    }
                    else
                    {

                        datacon.getcom("insert into tb_Supplier(SupplierName,Contacts,ContactPhone,Remark,Editer,EditTime) values" +
                            "('" + txtPName.Text + "','" + txtPLeader.Text + "','" + txtPPhone.Text + "','" + txtPRemark.Text + "','" + FormMain.L_UserName + "','" + DateTime.Now + "')");
                        MessageBox.Show("供应商信息添加成功！");
                        FormSupplierManage_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                datacon.getcom("delete from tb_Supplier where ID="
                    + Convert.ToString(dgvPInfo[0, dgvPInfo.CurrentCell.RowIndex].Value).Trim() + "");
                MessageBox.Show("删除供应商信息成功！");
                FormSupplierManage_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPName.Text == "" && txtPLeader.Text == "" && txtPPhone.Text == "")
                {
                    MessageBox.Show("请输入修改信息！");
                }
                else
                {
                    datacon.getcom("update tb_Supplier set SupplierName='" + txtPName.Text + "',Contacts = '" + txtPLeader.Text + "'" +
                   ",ContactPhone='" + txtPPhone.Text + "',Remark='" + txtPRemark.Text + "',Editer='" + FormMain.L_UserName + "',EditTime='" + DateTime.Now + "' where ID= '" + Convert.ToInt32(dgvPInfo[0, dgvPInfo.CurrentCell.RowIndex].Value) + "'");
                    MessageBox.Show("信息修改成功！");
                    FormSupplierManage_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
