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
    public partial class FormStockStatus : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormStockStatus()
        {
            InitializeComponent();
        }

        private void TlbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStockStatus_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select GoodsCode as 商品编号,GoodsName as 商品名称,Type as 商品型号,Standard as 商品规格,Unit as 所属单位,Produce as 商品产地,StockNum as 库存数量,BuyPrice as 最近一次进价,SalePrice as 最近一次售价,UpperLimit as 库存上限,LowerLimit as 库存下限 from tb_Stock", "tb_Stock");
            dgvStockList.DataSource = ds.Tables["tb_Stock"];
        }

        private void TlbtnSetStockLimit_Click(object sender, EventArgs e)
        {
            FormSetStockLimit FSSL = new FormSetStockLimit();
            int a = dgvStockList.CurrentRow.Index;
            FSSL.goodscode = dgvStockList.Rows[a].Cells["商品编号"].Value.ToString();
            FSSL.goodsname = dgvStockList.Rows[a].Cells["商品名称"].Value.ToString();
            FSSL.ShowDialog();
            FormStockStatus_Load(sender, e);
        }
    }
}
