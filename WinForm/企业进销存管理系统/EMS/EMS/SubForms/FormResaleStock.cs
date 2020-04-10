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
    public partial class FormResaleStock : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormResaleStock()
        {
            InitializeComponent();
        }

        private void BtnEixt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormResaleStock_Load(object sender, EventArgs e)
        {
            doperate.cboxBind("select BillCode from tb_SaleStock where BillCode like '%XS%'", "tb_SaleStock", "BillCode", cbbBillCode);
            txtBillDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtHandle.Text = FormLogin.L_UserName;
            DataSet ds = null;//创建数据集对象
            string P_Str_newBillCode = "";//记录新的单据编号
            int P_Int_newBillCode = 0;//记录单据编号中的数字码
            ds = datacon.getds("select * from tb_SaleStock where BillCode like '%TH%'", "tb_SaleStock");//获取所有进货单信息
            if (ds.Tables[0].Rows.Count == 0)//判断数据集中是否有值
            {
                txtBillCode.Text = DateTime.Now.ToString("yyyyMMdd") + "TH" + "1000001";//生成新的单据编号
            }
            else
            {
                P_Str_newBillCode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["BillCode"]);//获取已经存在的最大编号
                P_Int_newBillCode = Convert.ToInt32(P_Str_newBillCode.Substring(10, 7)) + 1;//获取一个最新的数字码
                P_Str_newBillCode = DateTime.Now.ToString("yyyyMMdd") + "TH" + P_Int_newBillCode.ToString();//获取最新单据编号
                txtBillCode.Text = P_Str_newBillCode;//将单据编号显示在文本框中
            }
        }

        private void CbbBillCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = datacon.getds("select Unit from tb_SaleStock where BillCode='" + cbbBillCode.Text + "'", "tb_SaleStock");
                txtUnits.Text = ds.Tables[0].Rows[0][0].ToString();
                DataSet ds2 = datacon.getds("select GoodsCode,GoodsName,Standard,Num,Price,Money from tb_SaleStockDetail where BillCode='" + cbbBillCode.Text + "'", "tb_SaleStockDetail");
                DataTable dt = ds2.Tables["tb_SaleStockDetail"];
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
            catch
            {

            }
        }

        private void Txtpayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBalance.Text = Convert.ToString(Convert.ToSingle(txtFullPayment.Text) - Convert.ToSingle(txtpayment.Text));//自动计算差额
            }
            catch (Exception ex)
            {
                MessageBox.Show("录入非法字符！！！" + ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpayment.Focus();//使实付金额文本框获得鼠标焦点
            }
        }

        private void DgvStockList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)//计算－－统计商品金额
            {
                try
                {
                    //计算商品总金额
                    float tsum = Convert.ToSingle(dgvStockList[3, e.RowIndex].Value.ToString()) * Convert.ToSingle(dgvStockList[4, e.RowIndex].Value.ToString());
                    dgvStockList[5, e.RowIndex].Value = tsum.ToString();//显示商品总金额
                }
                catch
                {
                }
            }
        }

        private void DgvStockList_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            try
            {
                float tqty = 0;//记录进货数量
                float tsum = 0;//记录应付金额
                for (int i = 0; i <= dgvStockList.RowCount; i++)//遍历DataGridView控件中的所有行
                {
                    tsum = tsum + Convert.ToSingle(dgvStockList[5, i].Value.ToString());//计算应付金额
                    tqty = tqty + Convert.ToSingle(dgvStockList[3, i].Value.ToString());//计算进货数量
                    txtFullPayment.Text = tsum.ToString();//显示应付金额
                    txtStockQty.Text = tqty.ToString();//显示进货数量
                }
            }
            catch { }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //列表中数据不能为空
                if (Convert.ToString(dgvStockList[3, 0].Value) == string.Empty || Convert.ToString(dgvStockList[4, 0].Value) == string.Empty || Convert.ToString(dgvStockList[5, 0].Value) == string.Empty)
                {
                    MessageBox.Show("请核实列表中数据：‘数量’、‘单价’、‘金额’不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //应付金额不能为空
                if (txtFullPayment.Text.Trim() == "0")
                {
                    MessageBox.Show("应付金额不能为‘０’！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string billcode = txtBillCode.Text;
                string billdate = txtBillDate.Text;
                string handler = txtHandle.Text;
                string unit = txtUnits.Text;
                string remark = txtRemark.Text;
                string fullpayment = txtFullPayment.Text;
                string payment = txtpayment.Text;
                //数据插入进货表
                datacon.getcom("insert into tb_SaleStock(BillCode,BillDate,Handler,Unit,Remark,FullPayment,Payment) " +
                    "values('" + billcode + "','" + billdate + "','" + handler + "','" + unit + "','" + remark + "','" + fullpayment + "','" + payment + "')");
                for (int i = 0; i < dgvStockList.RowCount - 1; i++)
                {
                    string goodscode = dgvStockList[0, i].Value.ToString();
                    string goodsname = dgvStockList[1, i].Value.ToString();
                    string standard = dgvStockList[2, i].Value.ToString();
                    string num = dgvStockList[3, i].Value.ToString();
                    string price = dgvStockList[4, i].Value.ToString();
                    string money = dgvStockList[5, i].Value.ToString();
                    //循环插入明细表
                    datacon.getcom("insert into tb_SaleStockDetail(BillCode,GoodsCode,GoodsName,Standard,Num,Price,Money) " +
                        "values('" + billcode + "','" + goodscode + "','" + goodsname + "','" + standard + "','" + num + "','" + price + "','" + money + "')");

                    DataSet dsgoods = datacon.getds("select * from tb_Stock where GoodsCode='" + goodscode + "'", "tb_Stock");
                    string s_num = dsgoods.Tables[0].Rows[0]["StockNum"].ToString();//库存数量
                    string r_num = Convert.ToString(Convert.ToInt32(s_num) + Convert.ToInt32(num));
                    datacon.getcom("update tb_Stock set StockNum='" + r_num + "' where GoodsCode='" + goodscode + "'");
                }
                MessageBox.Show("销售退货单-数据录入成功！");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
