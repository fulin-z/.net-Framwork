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
    public partial class FormTradeDealings : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormTradeDealings()
        {
            InitializeComponent();
        }

        private void TlBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTradeDealings_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select BillCode,Unit,BillDate from tb_BuyStock", "tb_BuyStock");
            DataTable dt = ds.Tables["tb_BuyStock"];
            dgvBillList.DataSource = dt;
            this.dgvBillList.AutoGenerateColumns = false;
            this.dgvBillList.Columns["Column1"].DataPropertyName = dt.Columns["BillCode"].ToString();
            this.dgvBillList.Columns["BillCode"].Visible = false;
            this.dgvBillList.Columns["Column2"].DataPropertyName = dt.Columns["Unit"].ToString();
            this.dgvBillList.Columns["Unit"].Visible = false;
            this.dgvBillList.Columns["Column3"].DataPropertyName = dt.Columns["BillDate"].ToString();
            this.dgvBillList.Columns["BillDate"].Visible = false;
        }

        private void TlBtnFind_Click(object sender, EventArgs e)
        {
            if (tlCmbBillType.Text == string.Empty)
            {
                MessageBox.Show("查询类别不能为空！");
            }
            else
            {
                if (tlTxtFindBill.Text.Trim() == string.Empty)
                {
                    DataSet ds = datacon.getds("select BillCode,Unit,BillDate from tb_BuyStock", "tb_BuyStock");
                    DataTable dt = ds.Tables["tb_BuyStock"];
                    dgvBillList.DataSource = dt;
                    this.dgvBillList.AutoGenerateColumns = false;
                    this.dgvBillList.Columns["Column1"].DataPropertyName = dt.Columns["BillCode"].ToString();
                    this.dgvBillList.Columns["BillCode"].Visible = false;
                    this.dgvBillList.Columns["Column2"].DataPropertyName = dt.Columns["Unit"].ToString();
                    this.dgvBillList.Columns["Unit"].Visible = false;
                    this.dgvBillList.Columns["Column3"].DataPropertyName = dt.Columns["BillDate"].ToString();
                    this.dgvBillList.Columns["BillDate"].Visible = false;
                }
                else
                {
                    DataSet ds2 = null;
                    if (tlCmbBillType.Text == "单据编号")
                    {
                        ds2 = datacon.getds("select BillCode,Unit,BillDate from tb_BuyStock where BillCode like'%"+tlTxtFindBill.Text.Trim()+"%'", "tb_BuyStock");
                        DataTable dt = ds2.Tables["tb_BuyStock"];
                        dgvBillList.DataSource = dt;
                        this.dgvBillList.AutoGenerateColumns = false;
                        this.dgvBillList.Columns["Column1"].DataPropertyName = dt.Columns["BillCode"].ToString();
                        this.dgvBillList.Columns["BillCode"].Visible = false;
                        this.dgvBillList.Columns["Column2"].DataPropertyName = dt.Columns["Unit"].ToString();
                        this.dgvBillList.Columns["Unit"].Visible = false;
                        this.dgvBillList.Columns["Column3"].DataPropertyName = dt.Columns["BillDate"].ToString();
                        this.dgvBillList.Columns["BillDate"].Visible = false;
                    }
                    else if (tlCmbBillType.Text == "录单日期")
                    {
                        ds2 = datacon.getds("select BillCode,Unit,BillDate from tb_BuyStock where BillDate like '%"+tlTxtFindBill.Text.Trim()+"%'", "tb_BuyStock");
                        DataTable dt = ds2.Tables["tb_BuyStock"];
                        dgvBillList.DataSource = dt;
                        this.dgvBillList.AutoGenerateColumns = false;
                        this.dgvBillList.Columns["Column1"].DataPropertyName = dt.Columns["BillCode"].ToString();
                        this.dgvBillList.Columns["BillCode"].Visible = false;
                        this.dgvBillList.Columns["Column2"].DataPropertyName = dt.Columns["Unit"].ToString();
                        this.dgvBillList.Columns["Unit"].Visible = false;
                        this.dgvBillList.Columns["Column3"].DataPropertyName = dt.Columns["BillDate"].ToString();
                        this.dgvBillList.Columns["BillDate"].Visible = false;
                    }
                    else
                    {
                        ds2 = datacon.getds("select BillCode,Unit,BillDate from tb_BuyStock where Unit like '%"+tlTxtFindBill.Text.Trim()+"%'", "tb_BuyStock");
                        DataTable dt = ds2.Tables["tb_BuyStock"];
                        dgvBillList.DataSource = dt;
                        this.dgvBillList.AutoGenerateColumns = false;
                        this.dgvBillList.Columns["Column1"].DataPropertyName = dt.Columns["BillCode"].ToString();
                        this.dgvBillList.Columns["BillCode"].Visible = false;
                        this.dgvBillList.Columns["Column2"].DataPropertyName = dt.Columns["Unit"].ToString();
                        this.dgvBillList.Columns["Unit"].Visible = false;
                        this.dgvBillList.Columns["Column3"].DataPropertyName = dt.Columns["BillDate"].ToString();
                        this.dgvBillList.Columns["BillDate"].Visible = false;
                    }
                }
            }
        }

        private void DgvBillList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgvBillList.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn )
                {
                    int a = e.RowIndex;
                    SubForms.FormBuyBill FBB = new FormBuyBill();
                    FBB.b_billcode = dgvBillList.Rows[a].Cells[0].Value.ToString();
                    if (FBB.b_billcode == "")
                    {
                        MessageBox.Show("无单据信息！");
                    }
                    else
                    {
                        string txt = dgvBillList.Rows[a].Cells[0].Value.ToString();
                        if (txt.Contains("JH"))
                        {
                            FBB.ShowDialog();
                        }
                        if (txt.Contains("TH"))
                        {
                            FormRebuyBill FRB = new FormRebuyBill();
                            FRB.r_billcode = dgvBillList.Rows[a].Cells[0].Value.ToString();
                            FRB.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
