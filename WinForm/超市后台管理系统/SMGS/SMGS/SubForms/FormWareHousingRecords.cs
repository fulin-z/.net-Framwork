using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMGS.SubForms
{
    public partial class FormWareHousingRecords : Form
    {
        database.DataCon datacon = new database.DataCon();
        public FormWareHousingRecords()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormWareHousingRecords_Load(object sender, EventArgs e)
        {
            DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,SupplierName as 供应商名称,GoodsNumber as 入库数量,Measure as 计量单位,GoodsPrice as 商品单价,"
                + "Total as 进货总金额,Remark as 备注,Handler as 经手人,HandTime as 经办时间 from tb_Warehouse", "tb_Warehouse");
            dgvISInfo.DataSource = myds.Tables["tb_Warehouse"];
        }

        private void BtnLook_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxLCondition.Text == "")
                {
                    FormWareHousingRecords_Load(sender, e);
                }
                else
                {
                    if (cboxLCondition.Text == "商品编号")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,SupplierName as 供应商名称,GoodsNumber as 入库数量,Measure as 计量单位,GoodsPrice as 商品单价,"
                + "Total as 进货总金额,Remark as 备注,Handler as 经手人,HandTime as 经办时间 from tb_Warehouse where GoodsID= '" + txtLKWord.Text.Trim() + "'", "tb_Warehouse");
                        dgvISInfo.DataSource = myds.Tables["tb_Warehouse"];
                    }
                    if (cboxLCondition.Text == "商品名称")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,SupplierName as 供应商名称,GoodsNumber as 入库数量,Measure as 计量单位,GoodsPrice as 商品单价,"
                + "Total as 进货总金额,Remark as 备注,Handler as 经手人,HandTime as 经办时间 from tb_Warehouse where GoodsName= '" + txtLKWord.Text.Trim() + "'", "tb_Warehouse");
                        dgvISInfo.DataSource = myds.Tables["tb_Warehouse"];
                    }
                    if (cboxLCondition.Text == "供应商名称")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,SupplierName as 供应商名称,GoodsNumber as 入库数量,Measure as 计量单位,GoodsPrice as 商品单价,"
                + "Total as 进货总金额,Remark as 备注,Handler as 经手人,HandTime as 经办时间 from tb_Warehouse where SupplierName= '" + txtLKWord.Text.Trim() + "'", "tb_Warehouse");
                        dgvISInfo.DataSource = myds.Tables["tb_Warehouse"];
                    }
                    if (cboxLCondition.Text == "经手人")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,SupplierName as 供应商名称,GoodsNumber as 入库数量,Measure as 计量单位,GoodsPrice as 商品单价,"
                + "Total as 进货总金额,Remark as 备注,Handler as 经手人,HandTime as 经办时间 from tb_Warehouse where Handler= '" + txtLKWord.Text.Trim() + "'", "tb_Warehouse");
                        dgvISInfo.DataSource = myds.Tables["tb_Warehouse"];
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
