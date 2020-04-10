using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
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
            labelUserName.Text = FormLogin.L_UserName;
            labelUserRight.Text = FormLogin.L_UserRight;
            timer = new Timer();   //定义计时器
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            if (labelUserRight.Text == "普通用户")
            {
                部门管理ToolStripMenuItem.Enabled = false;
                用户管理ToolStripMenuItem1.Enabled = false;
                权限管理ToolStripMenuItem.Enabled = false;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出本系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void 部门管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormDeptManagement FDM = new SubForms.FormDeptManagement();
            FDM.StartPosition = FormStartPosition.Manual;
            FDM.MdiParent = this;
            FDM.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormChangePwd FCP = new SubForms.FormChangePwd();
            FCP.StartPosition = FormStartPosition.Manual;
            FCP.MdiParent = this;
            FCP.Show();
        }

        private void 员工档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormEmployeeFiles FEF = new SubForms.FormEmployeeFiles();
            FEF.StartPosition = FormStartPosition.Manual;
            FEF.MdiParent = this;
            FEF.Show();
        }

        private void 奖罚管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormEmployeeRewards FER = new SubForms.FormEmployeeRewards();
            FER.StartPosition = FormStartPosition.Manual;
            FER.MdiParent = this;
            FER.Show();
        }

        private void 考评管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormEvaluation FE = new SubForms.FormEvaluation();
            FE.StartPosition = FormStartPosition.Manual;
            FE.MdiParent = this;
            FE.Show();
        }

        private void 变动管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormEmployeeChange FEC = new SubForms.FormEmployeeChange();
            FEC.StartPosition = FormStartPosition.Manual;
            FEC.MdiParent = this;
            FEC.Show();
        }

        private void 结算工资ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormSettlementWage FSW = new SubForms.FormSettlementWage();
            FSW.StartPosition = FormStartPosition.Manual;
            FSW.MdiParent = this;
            FSW.Show();
        }

        private void 已发工资ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForms.FormWages FW = new SubForms.FormWages();
            FW.StartPosition = FormStartPosition.Manual;
            FW.MdiParent = this;
            FW.Show();
        }
    }
}
