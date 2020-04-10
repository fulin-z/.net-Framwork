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
    public partial class FormChangeEvaluation : Form
    {
        DataBase.DataCon datacon = new DataBase.DataCon();
        DataBase.DataOperate doperate = new DataBase.DataOperate();
        public FormChangeEvaluation()
        {
            InitializeComponent();
        }
        public string YGName;
        public string YGID;
        public string ID;
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChangeEvaluation_Load(object sender, EventArgs e)
        {
            txtNum.Text = YGID;
            txtname.Text = YGName;
            DataSet ds = datacon.getds("select * from tb_Evaluation where ID='" + ID + "'", "tb_Evaluation");
            ds.Dispose();
            txtdep.Text = ds.Tables[0].Rows[0][3].ToString();
            txtcontent.Text = ds.Tables[0].Rows[0][4].ToString();
            txtresult.Text = ds.Tables[0].Rows[0][5].ToString();
            txtscore.Text = ds.Tables[0].Rows[0][6].ToString();
            txtkp.Text = FormLogin.L_UserName;
            txtkpdate.Text = ds.Tables[0].Rows[0][8].ToString();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcontent.Text.Trim() == "" || txtresult.Text.Trim() == "" || txtscore.Text.Trim() == "")
                {
                    MessageBox.Show("请将信息填写完整！");
                }
                else
                {
                    datacon.getcom("update tb_Evaluation set Contents='" + txtcontent.Text + "',Result='" + txtresult.Text + "',Core='" + txtscore.Text + "',People='" + txtkp.Text + "' where ID='" + ID + "'");
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
