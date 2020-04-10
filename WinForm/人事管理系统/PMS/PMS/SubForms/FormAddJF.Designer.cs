namespace PMS.SubForms
{
    partial class FormAddJF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddJF));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtJFdate = new System.Windows.Forms.DateTimePicker();
            this.txtFK = new System.Windows.Forms.TextBox();
            this.txtJL = new System.Windows.Forms.TextBox();
            this.cbbUserJFType = new System.Windows.Forms.ComboBox();
            this.cbbUserNum = new System.Windows.Forms.ComboBox();
            this.txtJFcontent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(419, 25);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("增加ToolStripMenuItem.Image")));
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.增加ToolStripMenuItem.Text = "增加";
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.增加ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // txtJFdate
            // 
            this.txtJFdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtJFdate.Location = new System.Drawing.Point(78, 216);
            this.txtJFdate.Name = "txtJFdate";
            this.txtJFdate.Size = new System.Drawing.Size(111, 21);
            this.txtJFdate.TabIndex = 59;
            // 
            // txtFK
            // 
            this.txtFK.Location = new System.Drawing.Point(270, 185);
            this.txtFK.Name = "txtFK";
            this.txtFK.Size = new System.Drawing.Size(134, 21);
            this.txtFK.TabIndex = 58;
            this.txtFK.Text = "0";
            this.txtFK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtJL
            // 
            this.txtJL.Location = new System.Drawing.Point(78, 185);
            this.txtJL.Name = "txtJL";
            this.txtJL.Size = new System.Drawing.Size(111, 21);
            this.txtJL.TabIndex = 57;
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
            this.cbbUserJFType.Location = new System.Drawing.Point(279, 30);
            this.cbbUserJFType.Name = "cbbUserJFType";
            this.cbbUserJFType.Size = new System.Drawing.Size(125, 20);
            this.cbbUserJFType.TabIndex = 54;
            this.cbbUserJFType.SelectedIndexChanged += new System.EventHandler(this.CbbUserJFType_SelectedIndexChanged);
            // 
            // cbbUserNum
            // 
            this.cbbUserNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserNum.FormattingEnabled = true;
            this.cbbUserNum.Location = new System.Drawing.Point(78, 30);
            this.cbbUserNum.Name = "cbbUserNum";
            this.cbbUserNum.Size = new System.Drawing.Size(111, 20);
            this.cbbUserNum.TabIndex = 53;
            this.cbbUserNum.SelectedIndexChanged += new System.EventHandler(this.CbbUserNum_SelectedIndexChanged);
            // 
            // txtJFcontent
            // 
            this.txtJFcontent.Location = new System.Drawing.Point(78, 91);
            this.txtJFcontent.Multiline = true;
            this.txtJFcontent.Name = "txtJFcontent";
            this.txtJFcontent.Size = new System.Drawing.Size(326, 81);
            this.txtJFcontent.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 51;
            this.label8.Text = "奖罚日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 50;
            this.label7.Text = "罚款金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "奖励金额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "奖罚内容：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "部　　门：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "姓　　名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "类　　型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "员工编号：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 59);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(111, 21);
            this.txtName.TabIndex = 61;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(279, 59);
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Size = new System.Drawing.Size(125, 21);
            this.txtDept.TabIndex = 62;
            // 
            // FormAddJF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 242);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtJFdate);
            this.Controls.Add(this.txtFK);
            this.Controls.Add(this.txtJL);
            this.Controls.Add(this.cbbUserJFType);
            this.Controls.Add(this.cbbUserNum);
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
            this.Name = "FormAddJF";
            this.Text = "新增奖罚";
            this.Load += new System.EventHandler(this.FormAddJF_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker txtJFdate;
        private System.Windows.Forms.TextBox txtFK;
        private System.Windows.Forms.TextBox txtJL;
        private System.Windows.Forms.ComboBox cbbUserJFType;
        private System.Windows.Forms.ComboBox cbbUserNum;
        private System.Windows.Forms.TextBox txtJFcontent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDept;
    }
}