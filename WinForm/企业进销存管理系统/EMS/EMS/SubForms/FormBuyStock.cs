using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.SubForms
{
    public partial class FormBuyStock : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormBuyStock()
        {
            InitializeComponent();
        }

        private void FormBuyStock_Load(object sender, EventArgs e)
        {
            txtBillDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtHandle.Text = FormLogin.L_UserName;
            doperate.cboxBind("select FullName from tb_Units", "tb_Units", "FullName", cbbUnit);
            DataSet ds = null;//创建数据集对象
            string P_Str_newBillCode = "";//记录新的单据编号
            int P_Int_newBillCode = 0;//记录单据编号中的数字码
            ds = datacon.getds("select * from tb_BuyStock", "tb_BuyStock");//获取所有进货单信息
            if (ds.Tables[0].Rows.Count == 0)//判断数据集中是否有值
            {
                txtBillCode.Text = DateTime.Now.ToString("yyyyMMdd") + "JH" + "1000001";//生成新的单据编号
            }
            else
            {
                P_Str_newBillCode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["BillCode"]);//获取已经存在的最大编号
                P_Int_newBillCode = Convert.ToInt32(P_Str_newBillCode.Substring(10, 7)) + 1;//获取一个最新的数字码
                P_Str_newBillCode = DateTime.Now.ToString("yyyyMMdd") + "JH" + P_Int_newBillCode.ToString();//获取最新单据编号
                txtBillCode.Text = P_Str_newBillCode;//将单据编号显示在文本框中
            }
        }

        private void CbbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = datacon.getds("select GoodsCode as 商品编号,FullName as 商品名称,Standard as 商品规格 from tb_Goods where Unit='" + cbbUnit.Text + "'", "tb_Goods");
                DataTable dt = ds.Tables["tb_Goods"];
                dgvStockList.DataSource = dt;
                this.dgvStockList.AutoGenerateColumns = false;
                this.dgvStockList.Columns["Column1"].DataPropertyName = dt.Columns["商品编号"].ToString();
                this.dgvStockList.Columns["商品编号"].Visible = false;
                this.dgvStockList.Columns["Column2"].DataPropertyName = dt.Columns["商品名称"].ToString();
                this.dgvStockList.Columns["商品名称"].Visible = false;
                this.dgvStockList.Columns["Column3"].DataPropertyName = dt.Columns["商品规格"].ToString();
                this.dgvStockList.Columns["商品规格"].Visible = false;
                txtStockQty.Text = "0";
                txtFullPayment.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (e.ColumnIndex == 4)
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                string unit = cbbUnit.Text;
                string remark = txtRemark.Text;
                string fullpayment = txtFullPayment.Text;
                string payment = txtpayment.Text;
                //数据插入进货表
                datacon.getcom("insert into tb_BuyStock(BillCode,BillDate,Handler,Unit,Remark,FullPayment,Payment) " +
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
                    datacon.getcom("insert into tb_BuyStockDetail(BillCode,GoodsCode,GoodsName,Standard,Num,Price,Money) " +
                        "values('" + billcode + "','" + goodscode + "','" + goodsname + "','" + standard + "','" + num + "','" + price + "','" + money + "')");
                    DataSet dsgoods = datacon.getds("select * from tb_Goods where GoodsCode='" + goodscode + "'", "tb_Goods");

                    string s_goodscode = goodscode;
                    string s_goodsname = dsgoods.Tables[0].Rows[0]["FullName"].ToString();
                    string s_type = dsgoods.Tables[0].Rows[0]["Type"].ToString();
                    string s_standard = dsgoods.Tables[0].Rows[0]["Standard"].ToString();
                    string s_unit = dsgoods.Tables[0].Rows[0]["Unit"].ToString();
                    string s_produce = dsgoods.Tables[0].Rows[0]["Produce"].ToString();
                    SqlDataReader read = datacon.getread("select * from tb_Stock where GoodsCode='" + goodscode + "'");
                    string s_stocknum;
                    if (read.Read())
                    {
                        string s_old_num = read["StockNum"].ToString();
                        s_stocknum = Convert.ToString(Convert.ToInt32(num) + Convert.ToInt32(s_old_num));
                        datacon.getcom("update tb_Stock set StockNum='" + s_stocknum + "' where GoodsCode='" + goodscode + "'");
                    }
                    else
                    {
                        s_stocknum = num;
                        string s_buyprice = price;
                        //库存表
                        datacon.getcom("insert into tb_Stock(GoodsCode,GoodsName,Type,Standard,Unit,Produce,StockNum,BuyPrice) " +
                            "values('" + s_goodscode + "','" + s_goodsname + "','" + s_type + "','" + s_standard + "','" + s_unit + "','" + s_produce + "','" + s_stocknum + "','" + s_buyprice + "')");
                    }
                }
                MessageBox.Show("进货单-数据录入成功！");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
