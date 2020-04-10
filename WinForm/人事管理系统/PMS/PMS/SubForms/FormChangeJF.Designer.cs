namespace PMS.SubForms
{
    partial class FormChangeJF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeJF));
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJFdate = new System.Windows.Forms.DateTimePicker();
            this.txtFK = new System.Windows.Forms.TextBox();
            this.txtJL = new System.Windows.Forms.TextBox();
            this.cbbUserJFType = new System.Windows.Forms.ComboBox();
            this.txtJFcontent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtYGNum = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(278, 60);
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Size = new System.Drawing.Size(125, 21);
            this.txtDept.TabIndex = 78;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 60);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(111, 21);
            this.txtName.TabIndex = 77;
            // 
            // txtJFdate
            // 
            this.txtJFdate.Enabled = false;
            this.txtJFdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtJFdate.Location = new System.Drawing.Point(77, 217);
            this.txtJFdate.Name = "txtJFdate";
            this.txtJFdate.Size = new System.Drawing.Size(111, 21);
            this.txtJFdate.TabIndex = 76;
            // 
            // txtFK
            // 
            this.txtFK.Location = new System.Drawing.Point(269, 186);
            this.txtFK.Name = "txtFK";
            this.txtFK.Size = new System.Drawing.Size(134, 21);
            this.txtFK.TabIndex = 75;
            this.txtFK.Text = "0";
            this.txtFK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtJL
            // 
            this.txtJL.Location = new System.Drawing.Point(77, 186);
            this.txtJL.Name = "txtJL";
            this.txtJL.Size = new System.Drawing.Size(111, 21);
            this.txtJL.TabIndex = 74;
            this.txtJL.Text = "0";
            this.txtJL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbbUserJFType
            // 
            this.cbbUserJFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserJFType.FormattingEnabled = true;
            this.cbbUserJFType.Items.AddRange(new object[] {
            "奖励",
            "惩罚"});
            this.cbbUserJFType.Location = new System.Drawing.Point(278, 31);
            this.cbbUserJFType.Name = "cbbUserJFType";
            this.cbbUserJFType.Size = new System.Drawing.Size(125, 20);
            this.cbbUserJFType.TabIndex = 73;
            this.cbbUserJFType.SelectedIndexChanged += new System.EventHandler(this.CbbUserJFType_SelectedIndexChanged);
            // 
            // txtJFcontent
            // 
            this.txtJFcontent.Location = new System.Drawing.Point(77, 92);
            this.txtJFcontent.Multiline = true;
            this.txtJFcontent.Name = "txtJFcontent";
            this.txtJFcontent.Size = new System.Drawing.Size(326, 81);
            this.txtJFcontent.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 70;
            this.label8.Text = "奖罚日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 69;
            this.label7.Text = "罚款金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 68;
            this.label6.Text = "奖励金额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 67;
            this.label5.Text = "奖罚内容：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 66;
            this.label4.Text = "部　　门：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 65;
            this.label3.Text = "姓　　名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 64;
            this.label2.Text = "类　　型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 63;
            this.label1.Text = "员工编号：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(411, 25);
            this.menuStrip1.TabIndex = 79;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("修改ToolStripMenuItem.Image")));
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // txtYGNum
            // 
            this.txtYGNum.Location = new System.Drawing.Point(77, 31);
            this.txtYGNum.Name = "txtYGNum";
            this.txtYGNum.ReadOnly = true;
            this.txtYGNum.Size = new System.Drawing.Size(111, 21);
            this.txtYGNum.TabIndex = 80;
            // 
            // FormChangeJF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 246);
            this.Controls.Add(this.txtYGNum);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtJFdate);
            this.Controls.Add(this.txtFK);
            this.Controls.Add(this.txtJL);
            this.Controls.Add(this.cbbUserJFType);
            this.Controls.Add(this.txtJFcontent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeJF";
            this.Load += new System.EventHandler(this.FormChangeJF_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker txtJFdate;
        private System.Windows.Forms.TextBox txtFK;
        private System.Windows.Forms.TextBox txtJL;
        private System.Windows.Forms.ComboBox cbbUserJFType;
        private System.Windows.Forms.TextBox txtJFcontent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtYGNum;
    }
}