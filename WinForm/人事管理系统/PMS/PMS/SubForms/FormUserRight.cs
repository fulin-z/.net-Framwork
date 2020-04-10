using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.SubForms
{
    public partial class FormUserRight : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormUserRight()
        {
            InitializeComponent();
        }

        private void FormUserRight_Load(object sender, EventArgs e)
        {
            doperate.cboxBind("select UserName from tb_User", "tb_User", "UserName", cboxUName);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSure_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxUName.Text == "" || cboxURight.Text == "")
                {
                    MessageBox.Show("信息不完整！");
                }
                else
                {
                    datacon.getcom("update tb_User set UserRight='" + cboxURight.Text + "' where UserName='" + cboxUName.Text + "'");
                    MessageBox.Show("权限修改成功！");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
