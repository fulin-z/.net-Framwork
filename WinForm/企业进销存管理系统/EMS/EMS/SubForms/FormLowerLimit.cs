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
    public partial class FormLowerLimit : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        public FormLowerLimit()
        {
            InitializeComponent();
        }

        private void FormLowerLimit_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("SELECT GoodsCode as 商品编号, GoodsName as 商品名称, StockNum as 库存数量,upperlimit as 库存上限,lowerlimit as 库存下限 from tb_stock WHERE (StockNum < lowerlimit) and lowerlimit > 0", "tb_stock");
            dgvStockList.DataSource = ds.Tables["tb_Stock"];
        }
    }
}
