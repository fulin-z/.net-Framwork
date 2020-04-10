namespace PMS
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUserRight = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奖罚管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考评管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.变动管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工资管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结算工资ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已发工资ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前登录用户：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前系统时间：";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.ForeColor = System.Drawing.Color.Red;
            this.labelUserName.Location = new System.Drawing.Point(158, 5);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 12);
            this.labelUserName.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(552, 5);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 12);
            this.labelTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户权限为：";
            // 
            // labelUserRight
            // 
            this.labelUserRight.AutoSize = true;
            this.labelUserRight.ForeColor = System.Drawing.Color.Red;
            this.labelUserRight.Location = new System.Drawing.Point(339, 5);
            this.labelUserRight.Name = "labelUserRight";
            this.labelUserRight.Size = new System.Drawing.Size(0, 12);
            this.labelUserRight.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工管理ToolStripMenuItem,
            this.工资管理ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工档案ToolStripMenuItem,
            this.奖罚管理ToolStripMenuItem,
            this.考评管理ToolStripMenuItem,
            this.变动管理ToolStripMenuItem});
            this.员工管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("员工管理ToolStripMenuItem.Image")));
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            // 
            // 员工档案ToolStripMenuItem
            // 
            this.员工档案ToolStripMenuItem.Name = "员工档案ToolStripMenuItem";
            this.员工档案ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.员工档案ToolStripMenuItem.Text = "员工档案";
            this.员工档案ToolStripMenuItem.Click += new System.EventHandler(this.员工档案ToolStripMenuItem_Click);
            // 
            // 奖罚管理ToolStripMenuItem
            // 
            this.奖罚管理ToolStripMenuItem.Name = "奖罚管理ToolStripMenuItem";
            this.奖罚管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.奖罚管理ToolStripMenuItem.Text = "奖罚管理";
            this.奖罚管理ToolStripMenuItem.Click += new System.EventHandler(this.奖罚管理ToolStripMenuItem_Click);
            // 
            // 考评管理ToolStripMenuItem
            // 
            this.考评管理ToolStripMenuItem.Name = "考评管理ToolStripMenuItem";
            this.考评管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.考评管理ToolStripMenuItem.Text = "考评管理";
            this.考评管理ToolStripMenuItem.Click += new System.EventHandler(this.考评管理ToolStripMenuItem_Click);
            // 
            // 变动管理ToolStripMenuItem
            // 
            this.变动管理ToolStripMenuItem.Name = "变动管理ToolStripMenuItem";
            this.变动管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.变动管理ToolStripMenuItem.Text = "变动管理";
            this.变动管理ToolStripMenuItem.Click += new System.EventHandler(this.变动管理ToolStripMenuItem_Click);
            // 
            // 工资管理ToolStripMenuItem
            // 
            this.工资管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.结算工资ToolStripMenuItem,
            this.已发工资ToolStripMenuItem});
            this.工资管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("工资管理ToolStripMenuItem.Image")));
            this.工资管理ToolStripMenuItem.Name = "工资管理ToolStripMenuItem";
            this.工资管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.工资管理ToolStripMenuItem.Text = "工资管理";
            // 
            // 结算工资ToolStripMenuItem
            // 
            this.结算工资ToolStripMenuItem.Name = "结算工资ToolStripMenuItem";
            this.结算工资ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.结算工资ToolStripMenuItem.Text = "结算工资";
            this.结算工资ToolStripMenuItem.Click += new System.EventHandler(this.结算工资ToolStripMenuItem_Click);
            // 
            // 已发工资ToolStripMenuItem
            // 
            this.已发工资ToolStripMenuItem.Name = "已发工资ToolStripMenuItem";
            this.已发工资ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.已发工资ToolStripMenuItem.Text = "已发工资";
            this.已发工资ToolStripMenuItem.Click += new System.EventHandler(this.已发工资ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部门管理ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("系统管理ToolStripMenuItem.Image")));
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 部门管理ToolStripMenuItem
            // 
            this.部门管理ToolStripMenuItem.Name = "部门管理ToolStripMenuItem";
            this.部门管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.部门管理ToolStripMenuItem.Text = "部门管理";
            this.部门管理ToolStripMenuItem.Click += new System.EventHandler(this.部门管理ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem1,
            this.权限管理ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("用户管理ToolStripMenuItem.Image")));
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 用户管理ToolStripMenuItem1
            // 
            this.用户管理ToolStripMenuItem1.Name = "用户管理ToolStripMenuItem1";
            this.用户管理ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.用户管理ToolStripMenuItem1.Text = "用户管理";
            this.用户管理ToolStripMenuItem1.Click += new System.EventHandler(this.用户管理ToolStripMenuItem1_Click);
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            this.权限管理ToolStripMenuItem.Click += new System.EventHandler(this.权限管理ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出系统ToolStripMenuItem.Image")));
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelUserRight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 24);
            this.panel1.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "人事管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUserRight;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工资管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奖罚管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考评管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 变动管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结算工资ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已发工资ToolStripMenuItem;
    }
}