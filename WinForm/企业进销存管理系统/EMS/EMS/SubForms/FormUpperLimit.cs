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
    public partial class FormUpperLimit : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        public FormUpperLimit()
        {
            InitializeComponent();
        }

        private void FormUpperLimit_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select GoodsCode as 商品编号, GoodsName as 商品名称, StockNum as 库存数量,UpperLimit as 库存上限,LowerLimit as 库存下限 FROM tb_Stock WHERE (UpperLimit < StockNum) and UpperLimit>0", "tb_Stock");
            dgvStockList.DataSource = ds.Tables["tb_Stock"];
        }
    }
}
