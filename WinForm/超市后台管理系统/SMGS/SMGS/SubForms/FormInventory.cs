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
    public partial class FormInventory : Form
    {
        database.DataCon datacon = new database.DataCon();
        public FormInventory()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 剩余数量,Measure as 计量单位,GoodsPrice as 商品单价,"
                + "Remark as 备注 from tb_Warehouse", "tb_Warehouse");
            dgvGInfo.DataSource = myds.Tables["tb_Warehouse"];
        }

        private void BtnLook_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxLCondition.Text == "")
                {
                    FormInventory_Load(sender, e);
                }
                else
                {
                    if (cboxLCondition.Text == "商品编号")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 剩余数量,Measure as 计量单位,GoodsPrice as 商品单价,"
                + "Remark as 备注 from tb_Warehouse where GoodsID='" + txtLKWord.Text.Trim() + "'", "tb_Warehouse");
                        dgvGInfo.DataSource = myds.Tables["tb_Warehouse"];
                    }
                    if (cboxLCondition.Text == "商品名称")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 剩余数量,Measure as 计量单位,GoodsPrice as 商品单价,"
                + "Remark as 备注 from tb_Warehouse where GoodsName='" + txtLKWord.Text.Trim() + "'", "tb_Warehouse");
                        dgvGInfo.DataSource = myds.Tables["tb_Warehouse"];
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
