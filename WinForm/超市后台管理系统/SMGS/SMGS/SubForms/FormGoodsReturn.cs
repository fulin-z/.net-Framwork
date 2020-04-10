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

namespace SMGS.SubForms
{
    public partial class FormGoodsReturn : Form
    {
        database.DataCon datacon = new database.DataCon();
        database.DataOperate doperate = new database.DataOperate();
        public FormGoodsReturn()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            cboxGName.Text = "";
            txtGID.Text = "";
            txtOSGNum.Text = "";
            cboxGUnit.Text = "";
            txtGSPrice.Text = "";
            txtGOPrice.Text = "";
            txtOSRemark.Text = "";
        }

        private void FormGoodsReturn_Load(object sender, EventArgs e)
        {
            doperate.cboxBind("select GoodsName from tb_WareHouse", "tb_WareHouse", "GoodsName", cboxGName);
            txtHPeople.Text = FormMain.L_UserName;
        }

        private void CboxGName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxGName.Text != "")
            {
                SqlConnection sqlcon = datacon.getcon();
                SqlCommand cmd = new SqlCommand("select GoodsID,GoodsPrice,Measure from tb_WareHouse where GoodsName='" + cboxGName.Text + "'", sqlcon);
                sqlcon.Open();
                SqlDataReader sqlread = cmd.ExecuteReader();
                if (sqlread.Read())
                {
                    txtGID.Text = sqlread["GoodsID"].ToString();
                    txtGOPrice.Text = sqlread["GoodsPrice"].ToString();
                    cboxGUnit.Text = sqlread["Measure"].ToString();
                }
            }
        }

        private void TxtGSPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOSGNum.Text == "" || cboxGUnit.Text == "" || txtHPeople.Text == "")
                {
                    MessageBox.Show("信息不完整，请完善！");
                }
                else
                {
                    SqlConnection sqlcon = datacon.getcon();
                    SqlCommand cmd = new SqlCommand("select GoodsNumber from tb_WareHouse where GoodsName='" + cboxGName.Text + "'", sqlcon);
                    sqlcon.Open();
                    SqlDataReader sqlread = cmd.ExecuteReader();
                    if (sqlread.Read())
                    {
                        int Num = Convert.ToInt32(sqlread["GoodsNumber"]);
                        int ReturnNum = Convert.ToInt32(txtOSGNum.Text);
                        datacon.getcom("insert into tb_GoodsReturn(GoodsID,GoodsName,GoodsNumber,Measure,GoodsPrice,Total,Handler,Remark,HandTime)" +
                            "values('" + txtGID.Text + "','" + cboxGName.Text + "','" + txtOSGNum.Text + "','" + cboxGUnit.Text + "','" + txtGOPrice.Text + "','" + txtGSPrice.Text + "','" + txtHPeople.Text + "','" + txtOSRemark.Text + "','" + DateTime.Now + "')");
                        datacon.getcom("update tb_WareHouse set GoodsNumber='" + (Num + ReturnNum) + "' where GoodsName='" + cboxGName.Text + "'");
                        MessageBox.Show("商品退货成功！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtGSPrice_Click(object sender, EventArgs e)
        {
            if (txtOSGNum.Text != "" && txtGOPrice.Text != "")
            {
                txtGSPrice.Text = (Convert.ToDouble(txtOSGNum.Text) * Convert.ToDouble(txtGOPrice.Text)).ToString();
            }
        }
    }
}
