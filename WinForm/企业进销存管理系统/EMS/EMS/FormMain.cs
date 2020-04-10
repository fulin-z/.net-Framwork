using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class FormMain : Form
    {
        private Timer timer;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer = new Timer();   //定义计时器
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            toolStripMenuItem1.Text = FormLogin.L_UserName;
            toolStripMenuItem2.Text = FormLogin.L_UserRight;
            if (toolStripMenuItem2.Text == "操作用户")
            {
                操作用户ToolStripMenuItem.Enabled = false;
                权限管理ToolStripMenuItem.Enabled = false;
                公司员工ToolStripMenuItem.Enabled = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出本系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void 切换登录用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void 操作用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormUser FU = new SubForms.FormUser();
            FU.StartPosition = FormStartPosition.Manual;
            FU.MdiParent = this;
            FU.Show();
        }

        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormUserRight FUR = new SubForms.FormUserRight();
            FUR.StartPosition = FormStartPosition.Manual;
            FUR.MdiParent = this;
            FUR.Show();
        }

        private void 密码管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormUserPwd FUP = new SubForms.FormUserPwd();
            FUP.StartPosition = FormStartPosition.Manual;
            FUP.MdiParent = this;
            FUP.Show();
        }

        private void 经营商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormGoods FG = new SubForms.FormGoods();
            FG.StartPosition = FormStartPosition.Manual;
            FG.MdiParent = this;
            FG.Show();
        }

        private void 往来单位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormUnits FT = new SubForms.FormUnits();
            FT.StartPosition = FormStartPosition.Manual;
            FT.MdiParent = this;
            FT.Show();
        }

        private void 公司员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormEmployee FE = new SubForms.FormEmployee();
            FE.StartPosition = FormStartPosition.Manual;
            FE.MdiParent = this;
            FE.Show();
        }

        private void 进货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormBuyStock FBS = new SubForms.FormBuyStock();
            FBS.StartPosition = FormStartPosition.Manual;
            FBS.MdiParent = this;
            FBS.Show();
        }

        private void 往来对账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormTradeDealings FTD = new SubForms.FormTradeDealings();
            FTD.StartPosition = FormStartPosition.Manual;
            FTD.MdiParent = this;
            FTD.Show();
        }

        private void 销售单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormSaleStock FSS = new SubForms.FormSaleStock();
            FSS.StartPosition = FormStartPosition.Manual;
            FSS.MdiParent = this;
            FSS.Show();
        }

        private void 往来对账ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SubForms.FormSaleTrade FST = new SubForms.FormSaleTrade();
            FST.StartPosition = FormStartPosition.Manual;
            FST.MdiParent = this;
            FST.Show();
        }

        private void 库存状况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormStockStatus FSS = new SubForms.FormStockStatus();
            FSS.StartPosition = FormStartPosition.Manual;
            FSS.MdiParent = this;
            FSS.Show();
        }

        private void 库存商品上限报警ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormUpperLimit FUL = new SubForms.FormUpperLimit();
            FUL.StartPosition = FormStartPosition.Manual;
            FUL.MdiParent = this;
            FUL.Show();
        }

        private void 库存商品下限报警ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormLowerLimit FLL = new SubForms.FormLowerLimit();
            FLL.StartPosition = FormStartPosition.Manual;
            FLL.MdiParent = this;
            FLL.Show();
        }

        private void 进货退货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormRebuyStock FRS = new SubForms.FormRebuyStock();
            FRS.StartPosition = FormStartPosition.Manual;
            FRS.MdiParent = this;
            FRS.Show();
        }

        private void 销售退货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormResaleStock FRSS = new SubForms.FormResaleStock();
            FRSS.StartPosition = FormStartPosition.Manual;
            FRSS.MdiParent = this;
            FRSS.Show();
        }

        private void 商品销售排行ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
