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
    public partial class FormGoods : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormGoods()
        {
            InitializeComponent();
        }

        private void TlBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TlBtnCancel_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtType.Text = "";
            txtStandard.Text = "";
            txtProduce.Text = "";
        }

        private void FormGoods_Load(object sender, EventArgs e)
        {
            DataSet ds = datacon.getds("select ID as 编号,GoodsCode as 商品编号,FullName as 商品全称,Type as 商品型号,Standard as 商品规格,Unit as 所属单位,Produce as 商品产地,EditMan as 编辑人,EditTime as 编辑时间 from tb_Goods order by GoodsCode", "tb_Goods");
            dgvStockList.DataSource = ds.Tables["tb_Goods"];
            doperate.cboxBind("select FullName from tb_Units", "tb_Units", "FullName", cbbUnit);
            string P_Str_newUnitcode = "";
            int P_Int_newUnitcode = 0;
            if (ds.Tables[0].Rows.Count == 0)
            {
                txtGoodsCode.Text = "G1001";
            }
            else
            {
                P_Str_newUnitcode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["商品编号"]);
                P_Int_newUnitcode = Convert.ToInt32(P_Str_newUnitcode.Substring(1, 4)) + 1;
                P_Str_newUnitcode = "G" + P_Int_newUnitcode.ToString();
                txtGoodsCode.Text = P_Str_newUnitcode;
            }
        }

        private void TlBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtType.Text == "" || txtStandard.Text == "" || cbbUnit.Text == "" || txtProduce.Text == "" || txtGoodsCode.Text=="")
                {
                    MessageBox.Show("请将信息填写完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_Goods where FullName='" + txtFullName.Text + "'");
                    if (sqlread.Read())
                    {
                        MessageBox.Show("该商品名称已存在！");
                    }
                    else
                    {
                        SqlDataReader sqlread2 = datacon.getread("select * from tb_Goods where GoodsCode='" + txtGoodsCode.Text + "'");
                        if (sqlread2.Read())
                        {
                            MessageBox.Show("该商品编号已存在！");
                        }
                        else
                        {
                            datacon.getcom("insert into tb_Goods(GoodsCode,FullName,Type,Standard,Unit,Produce,EditMan,EditTime) " +
                            "values('" + txtGoodsCode.Text + "','" + txtFullName.Text + "','" + txtType.Text + "','" + txtStandard.Text + "','" + cbbUnit.Text + "','" + txtProduce.Text + "','" + FormLogin.L_UserName + "','" + DateTime.Now + "')");
                            MessageBox.Show("商品信息添加成功！");
                            txtFullName.Text = "";
                            txtType.Text = "";
                            txtStandard.Text = "";
                            txtProduce.Text = "";
                            FormGoods_Load(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvStockList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = dgvStockList.CurrentRow.Index;
                txtGoodsCode.Text = dgvStockList.Rows[a].Cells["商品编号"].Value.ToString();
                txtFullName.Text = dgvStockList.Rows[a].Cells["商品全称"].Value.ToString();
                txtType.Text = dgvStockList.Rows[a].Cells["商品型号"].Value.ToString();
                txtStandard.Text = dgvStockList.Rows[a].Cells["商品规格"].Value.ToString();
                cbbUnit.Text = dgvStockList.Rows[a].Cells["所属单位"].Value.ToString();
                txtProduce.Text = dgvStockList.Rows[a].Cells["商品产地"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TlBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader sqlreader = datacon.getread("select * from tb_Goods where GoodsCode='" + txtGoodsCode.Text + "'");
                if (sqlreader.Read())
                {
                    datacon.getcom("delete from tb_Goods where GoodsCode='" + txtGoodsCode.Text + "'");
                    MessageBox.Show("商品信息删除成功！");
                    FormGoods_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("该商品编号不存在！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TlBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtType.Text == "" || txtStandard.Text == "" || cbbUnit.Text == "" || txtProduce.Text == "")
                {
                    MessageBox.Show("请将信息填写完整！");
                }
                else
                {
                    SqlDataReader sqlread = datacon.getread("select * from tb_Goods where GoodsCode='" + txtGoodsCode.Text + "'");
                    if (sqlread.Read())
                    {
                        datacon.getcom("update tb_Goods set FullName='" + txtFullName.Text + "',Type='" + txtType.Text + "',Standard='" + txtStandard.Text + "',Unit='" + cbbUnit.Text + "',Produce='" + txtProduce.Text + "',EditMan='" + FormLogin.L_UserName + "',EditTime='" + DateTime.Now + "' where Goodscode='" + txtGoodsCode.Text + "'");
                        MessageBox.Show("商品信息修改成功！");
                        txtFullName.Text = "";
                        txtType.Text = "";
                        txtStandard.Text = "";
                        txtProduce.Text = "";
                        FormGoods_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("该商品编号不存在！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TlBtnFind_Click(object sender, EventArgs e)
        {
            if (tlCmbGoodsType.Text == string.Empty)
            {
                MessageBox.Show("查询类别不能为空！");
            }
            else
            {
                if (tlTxtFindGoods.Text.Trim() == string.Empty)
                {
                    DataSet ds = datacon.getds("select ID as 编号,GoodsCode as 商品编号,FullName as 商品全称,Type as 商品型号,Standard as 商品规格,Unit as 所属单位,Produce as 商品产地,EditMan as 编辑人,EditTime as 编辑时间 from tb_Goods order by GoodsCode", "tb_Goods");
                    dgvStockList.DataSource = ds.Tables["tb_Goods"];
                }
                else
                {
                    DataSet ds2 = null;
                    if (tlCmbGoodsType.Text == "商品编号")  
                    {
                        ds2 = datacon.getds("select ID as 编号,GoodsCode as 商品编号,FullName as 商品全称,Type as 商品型号,Standard as 商品规格,Unit as 所属单位,Produce as 商品产地,EditMan as 编辑人,EditTime as 编辑时间 from tb_Goods where GoodsCode like '%" + tlTxtFindGoods.Text+"%' order by GoodsCode", "tb_Goods");
                        dgvStockList.DataSource = ds2.Tables["tb_Goods"];
                    }
                    else                 
                    {
                        ds2 = datacon.getds("select ID as 编号,GoodsCode as 商品编号,FullName as 商品全称,Type as 商品型号,Standard as 商品规格,Unit as 所属单位,Produce as 商品产地,EditMan as 编辑人,EditTime as 编辑时间 from tb_Goods where FullName like '%" + tlTxtFindGoods.Text+"%' order by GoodsCode", "tb_Goods");
                        dgvStockList.DataSource = ds2.Tables["tb_Goods"];
                    }
                }
            }
        }
    }
}
