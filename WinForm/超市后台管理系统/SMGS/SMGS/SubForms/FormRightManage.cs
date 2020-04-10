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
    public partial class FormRightManage : Form
    {
        database.DataCon datacon = new database.DataCon();
        database.DataOperate doperate = new database.DataOperate();
        public FormRightManage()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormRightManage_Load(object sender, EventArgs e)
        {
            doperate.cboxBind("select UserName from tb_User", "tb_User", "UserName", cboxUName);
        }

        private void BtnSure_Click(object sender, EventArgs e)
        {
            datacon.getcom("update tb_User set UserRight='"
                + cboxURight.Text.Trim() + "'where UserName='" + cboxUName.Text.Trim() + "'");
            MessageBox.Show("权限修改成功！");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
