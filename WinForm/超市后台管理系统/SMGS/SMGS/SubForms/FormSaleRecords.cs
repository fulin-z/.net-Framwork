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
    public partial class FormSaleRecords : Form
    {
        database.DataCon datacon = new database.DataCon();
        public FormSaleRecords()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSaleRecords_Load(object sender, EventArgs e)
        {
            DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 出售数量,Measure as 计量单位,GoodsPrice as 商品单价,Total as 总金额,Handler as 经手人,Remark as 备注,HandTime as 出售时间 from tb_GoodsSale", "tb_GoodsSale");
            dgvGInfo.DataSource = myds.Tables["tb_GoodsSale"];
        }

        private void BtnLook_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxLCondition.Text == "")
                {
                    FormSaleRecords_Load(sender, e);
                }
                else
                {
                    if (cboxLCondition.Text == "经手人")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 出售数量,Measure as 计量单位,GoodsPrice as 商品单价,Total as 总金额,Handler as 经手人,Remark as 备注,HandTime as 出售时间 from tb_GoodsSale where Handler='" + txtLKWord.Text.Trim() + "'", "tb_GoodsSale");
                        dgvGInfo.DataSource = myds.Tables["tb_GoodsSale"];
                    }
                    if (cboxLCondition.Text == "商品编号")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 出售数量,Measure as 计量单位,GoodsPrice as 商品单价,Total as 总金额,Handler as 经手人,Remark as 备注,HandTime as 出售时间 from tb_GoodsSale where GoodsID='" + txtLKWord.Text.Trim() + "'", "tb_GoodsSale");
                        dgvGInfo.DataSource = myds.Tables["tb_GoodsSale"];
                    }
                    if (cboxLCondition.Text == "商品名称")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 出售数量,Measure as 计量单位,GoodsPrice as 商品单价,Total as 总金额,Handler as 经手人,Remark as 备注,HandTime as 出售时间 from tb_GoodsSale where GoodsName='" + txtLKWord.Text.Trim() + "'", "tb_GoodsSale");
                        dgvGInfo.DataSource = myds.Tables["tb_GoodsSale"];
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
