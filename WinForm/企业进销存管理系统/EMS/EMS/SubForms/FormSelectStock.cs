using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.SubForms
{
    public partial class FormSelectStock : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();

        public FormSaleStock salestock;

        public int M_int_CurrentRow;
        public string M_str_object = "";
        public FormSelectStock()
        {
            InitializeComponent();
        }

        private void FormSelectStock_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select GoodsCode as 商品编号,GoodsName as 商品名称,Standard as 商品规格,BuyPrice as 最近一次进价,SalePrice as 最近一次售价,StockNum as 库存数量 from tb_Stock", "tb_Stock");
            dgvSelectStockList.DataSource = ds.Tables["tb_Stock"];
        }

        private void DgvSelectStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (M_str_object == "SaleStock")
            {
                salestock.dgvStockList[0, M_int_CurrentRow].Value = dgvSelectStockList[0, e.RowIndex].Value.ToString();
                salestock.dgvStockList[1, M_int_CurrentRow].Value = dgvSelectStockList[1, e.RowIndex].Value.ToString();
                salestock.dgvStockList[2, M_int_CurrentRow].Value = dgvSelectStockList[2, e.RowIndex].Value.ToString();
                salestock.dgvStockList[4, M_int_CurrentRow].Value = dgvSelectStockList[4, e.RowIndex].Value.ToString();
                salestock.dgvStockList[6, M_int_CurrentRow].Value = dgvSelectStockList[5, e.RowIndex].Value.ToString();
                this.Close();
            }
        }
    }
}
