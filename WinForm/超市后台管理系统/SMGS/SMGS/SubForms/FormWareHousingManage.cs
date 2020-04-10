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
    public partial class FormWareHousingManage : Form
    {
        database.DataCon datacon = new database.DataCon();
        database.DataOperate doperate = new database.DataOperate();
        public FormWareHousingManage()
        {
            InitializeComponent();
        }

        private void FormWareHousingManage_Load(object sender, EventArgs e)
        {
            txtHandler.Text = FormMain.L_UserName;
            doperate.cboxBind("select SupplierName from tb_Supplier", "tb_Supplier", "SupplierName", cboxSPName);
            DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,SupplierName as 供应商名称,GoodsNumber as 入库数量,Measure as 计量单位,GoodsPrice as 商品单价,"
                + "Total as 进货总金额,Remark as 备注,Handler as 经手人,HandTime as 经办时间 from tb_Warehouse", "tb_Warehouse");
            dgvISManage.DataSource = myds.Tables["tb_Warehouse"];
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                datacon.getcom("delete from tb_Warehouse where ID="
                    + Convert.ToString(dgvISManage[0, dgvISManage.CurrentCell.RowIndex].Value).Trim() + "");
                MessageBox.Show("删除商品信息成功！");
                FormWareHousingManage_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGoodsID.Text == "" || txtGoodsName.Text == "" || cboxSPName.Text == "" || txtGoodsNum.Text == "" || cboxMeasure.Text == "" || txtGoodsPrice.Text == "" || txtHandler.Text == "")
                {
                    MessageBox.Show("商品信息不完整！");
                }
                else
                {
                    SqlConnection sqlcon = datacon.getcon();
                    SqlCommand cmd = new SqlCommand("select * from tb_Warehouse where GoodsID='" + txtGoodsID.Text.Trim() + "'", sqlcon);
                    sqlcon.Open();
                    SqlDataReader sqlread = cmd.ExecuteReader();
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该商品已存在！");
                    }
                    else
                    {
                        datacon.getcom("insert into tb_Warehouse(GoodsID,GoodsName,SupplierName,GoodsNumber,Measure,GoodsPrice,Total,Handler,Remark,HandTime) values" +
                            "('" + txtGoodsID.Text.Trim() + "','" + txtGoodsName.Text.Trim() + "','" + cboxSPName.Text + "','" + txtGoodsNum.Text.Trim() + "'" +
                            ",'" + cboxMeasure.Text + "','" + txtGoodsPrice.Text.Trim() + "','" + txtTotal.Text + "','" + txtHandler.Text + "','" + txtRemark.Text.Trim() + "','" + DateTime.Now + "')");
                        MessageBox.Show("商品信息入库成功！");
                        FormWareHousingManage_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtTotal_Click(object sender, EventArgs e)
        {
            if (txtGoodsPrice.Text != "" && txtGoodsNum.Text != "")
            {
                txtTotal.Text = (Convert.ToDouble(txtGoodsPrice.Text) * Convert.ToInt32(txtGoodsNum.Text)).ToString();
            }
        }
    }
}
