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
    public partial class FormSaleBill : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public string b_billcode;
        public FormSaleBill()
        {
            InitializeComponent();
        }

        private void FormSaleBill_Load(object sender, EventArgs e)
        {
            txtBillCode.Text = b_billcode;
            DataSet ds = datacon.getds("select * from tb_SaleStock where BillCode='" + b_billcode + "'", "tb_SaleStock");
            ds.Dispose();
            txtBillDate.Text = ds.Tables[0].Rows[0][2].ToString();
            txtHandle.Text = ds.Tables[0].Rows[0][3].ToString();
            txtUnit.Text = ds.Tables[0].Rows[0][4].ToString();
            txtRemark.Text = ds.Tables[0].Rows[0][5].ToString();
            txtFullPayment.Text = ds.Tables[0].Rows[0][6].ToString();
            txtpayment.Text = ds.Tables[0].Rows[0][7].ToString();
            txtBalance.Text = Convert.ToString(Convert.ToSingle(txtFullPayment.Text) - Convert.ToSingle(txtpayment.Text));
            DataSet ds2 = datacon.getds("select GoodsCode,GoodsName,Standard,Num,Price,Money from tb_SaleStockDetail where BillCode='" + b_billcode + "'", "tb_SaleStockDetail");
            ds2.Dispose();
            DataTable dt = ds2.Tables[0];
            dgvStockList.DataSource = dt;
            this.dgvStockList.AutoGenerateColumns = false;
            this.dgvStockList.Columns["Column1"].DataPropertyName = dt.Columns["GoodsCode"].ToString();
            this.dgvStockList.Columns["GoodsCode"].Visible = false;
            this.dgvStockList.Columns["Column2"].DataPropertyName = dt.Columns["GoodsName"].ToString();
            this.dgvStockList.Columns["GoodsName"].Visible = false;
            this.dgvStockList.Columns["Column3"].DataPropertyName = dt.Columns["Standard"].ToString();
            this.dgvStockList.Columns["Standard"].Visible = false;
            this.dgvStockList.Columns["Column4"].DataPropertyName = dt.Columns["Num"].ToString();
            this.dgvStockList.Columns["Num"].Visible = false;
            this.dgvStockList.Columns["Column5"].DataPropertyName = dt.Columns["Price"].ToString();
            this.dgvStockList.Columns["Price"].Visible = false;
            this.dgvStockList.Columns["Column6"].DataPropertyName = dt.Columns["Money"].ToString();
            this.dgvStockList.Columns["Money"].Visible = false;
        }

        private void DgvStockList_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            try
            {
                float tqty = 0;//记录进货数量
                for (int i = 0; i <= dgvStockList.RowCount; i++)//遍历DataGridView控件中的所有行
                {
                    tqty = tqty + Convert.ToSingle(dgvStockList[3, i].Value.ToString());//计算进货数量
                    txtStockQty.Text = tqty.ToString();//显示进货数量
                }
            }
            catch { }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
