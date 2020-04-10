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
    public partial class FormSetStockLimit : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public string goodsname;
        public string goodscode;
        public FormSetStockLimit()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //验证输入的文本必须为阿拉伯数字。
            for (int i = 0; i < txtUpperLimit.Text.Length; i++)
            {
                if (!Char.IsNumber(txtUpperLimit.Text, i))
                {
                    MessageBox.Show("库存上限设置必须为阿拉伯数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < txtLowerLimit.Text.Length; i++)
            {
                if (!Char.IsNumber(txtLowerLimit.Text, i))
                {
                    MessageBox.Show("库存上限设置必须为阿拉伯数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //更新数据
            string UpperLimit = txtUpperLimit.Text;
            string LowerLimit = txtLowerLimit.Text;
            datacon.getcom("update tb_Stock set UpperLimit='" + txtUpperLimit.Text + "',LowerLimit='" + txtLowerLimit.Text + "' where GoodsCode='" + goodscode + "'");
            MessageBox.Show(goodsname + "库存上下限设置成功！");
            this.Close();
        }

        private void FormSetStockLimit_Load(object sender, EventArgs e)
        {
            this.Text = "[ " + goodsname + " ]" + "库存预警设置";
        }
    }
}
