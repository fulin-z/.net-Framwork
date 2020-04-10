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
    public partial class FormReturnRecords : Form
    {
        database.DataCon datacon = new database.DataCon();
        database.DataOperate doperate = new database.DataOperate();
        public FormReturnRecords()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReturnRecords_Load(object sender, EventArgs e)
        {
            DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 退货数量,Measure as 计量单位,GoodsPrice as 商品单价,Total as 总金额,Handler as 经手人,Remark as 备注,HandTime as 退货时间 from tb_GoodsReturn", "tb_GoodsReturn");
            dgvGInfo.DataSource = myds.Tables["tb_GoodsReturn"];
        }

        private void BtnLook_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxLCondition.Text == "")
                {
                    FormReturnRecords_Load(sender, e);
                }
                else
                {
                    if (cboxLCondition.Text == "经手人")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 退货数量,Measure as 计量单位,GoodsPrice as 商品单价,Total as 总金额,Handler as 经手人,Remark as 备注,HandTime as 退货时间 from tb_GoodsReturn where Handler='" + txtLKWord.Text.Trim() + "'", "tb_GoodsReturn");
                        dgvGInfo.DataSource = myds.Tables["tb_GoodsReturn"];
                    }
                    if (cboxLCondition.Text == "商品编号")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 退货数量,Measure as 计量单位,GoodsPrice as 商品单价,Total as 总金额,Handler as 经手人,Remark as 备注,HandTime as 退货时间 from tb_GoodsReturn where GoodsID='" + txtLKWord.Text.Trim() + "'", "tb_GoodsReturn");
                        dgvGInfo.DataSource = myds.Tables["tb_GoodsReturn"];
                    }
                    if (cboxLCondition.Text == "商品名称")
                    {
                        DataSet myds = datacon.getds("select ID as 编号,GoodsID as 商品编号,GoodsName as 商品名称,GoodsNumber as 退货数量,Measure as 计量单位,GoodsPrice as 商品单价,Total as 总金额,Handler as 经手人,Remark as 备注,HandTime as 退货时间 from tb_GoodsReturn where GoodsName='" + txtLKWord.Text.Trim() + "'", "tb_GoodsReturn");
                        dgvGInfo.DataSource = myds.Tables["tb_GoodsReturn"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
