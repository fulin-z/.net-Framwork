namespace PMS.SubForms
{
    partial class FormAddEmployeeChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEmployeeChange));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNewPay = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtjob1 = new System.Windows.Forms.TextBox();
            this.txtdep1 = new System.Windows.Forms.TextBox();
            this.cbbdep2 = new System.Windows.Forms.ComboBox();
            this.cbbnum = new System.Windows.Forms.ComboBox();
            this.txtexplain = new System.Windows.Forms.TextBox();
            this.txtpay1 = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtjob2 = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(426, 25);
            this.menuStrip1.TabIndex = 4;
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
            // txtNewPay
            // 
            this.txtNewPay.Location = new System.Drawing.Point(284, 146);
            this.txtNewPay.Name = "txtNewPay";
            this.txtNewPay.Size = new System.Drawing.Size(121, 21);
            this.txtNewPay.TabIndex = 52;
            // 
            // txtdate
            // 
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(66, 181);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(121, 21);
            this.txtdate.TabIndex = 51;
            // 
            // txtjob1
            // 
            this.txtjob1.Enabled = false;
            this.txtjob1.Location = new System.Drawing.Point(65, 106);
            this.txtjob1.Name = "txtjob1";
            this.txtjob1.Size = new System.Drawing.Size(121, 21);
            this.txtjob1.TabIndex = 50;
            // 
            // txtdep1
            // 
            this.txtdep1.Enabled = false;
            this.txtdep1.Location = new System.Drawing.Point(65, 65);
            this.txtdep1.Name = "txtdep1";
            this.txtdep1.Size = new System.Drawing.Size(121, 21);
            this.txtdep1.TabIndex = 49;
            // 
            // cbbdep2
            // 
            this.cbbdep2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbdep2.FormattingEnabled = true;
            this.cbbdep2.Location = new System.Drawing.Point(284, 66);
            this.cbbdep2.Name = "cbbdep2";
            this.cbbdep2.Size = new System.Drawing.Size(121, 20);
            this.cbbdep2.TabIndex = 47;
            // 
            // cbbnum
            // 
            this.cbbnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbnum.FormattingEnabled = true;
            this.cbbnum.Location = new System.Drawing.Point(66, 30);
            this.cbbnum.Name = "cbbnum";
            this.cbbnum.Size = new System.Drawing.Size(121, 20);
            this.cbbnum.TabIndex = 46;
            this.cbbnum.SelectedIndexChanged += new System.EventHandler(this.Cbbnum_SelectedIndexChanged);
            // 
            // txtexplain
            // 
            this.txtexplain.Location = new System.Drawing.Point(66, 224);
            this.txtexplain.Multiline = true;
            this.txtexplain.Name = "txtexplain";
            this.txtexplain.Size = new System.Drawing.Size(353, 116);
            this.txtexplain.TabIndex = 45;
            // 
            // txtpay1
            // 
            this.txtpay1.Enabled = false;
            this.txtpay1.Location = new System.Drawing.Point(66, 146);
            this.txtpay1.Name = "txtpay1";
            this.txtpay1.Size = new System.Drawing.Size(120, 21);
            this.txtpay1.TabIndex = 44;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(284, 30);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 21);
            this.txtname.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 42;
            this.label10.Text = "调动说明：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 41;
            this.label9.Text = "调动日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 40;
            this.label8.Text = "工资调整：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 39;
            this.label7.Text = "原 工 资：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "现 职 务：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "原 职 务：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "现 部 门：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "原 部 门：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "员工姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "员工编号：";
            // 
            // txtjob2
            // 
            this.txtjob2.Location = new System.Drawing.Point(284, 110);
            this.txtjob2.Name = "txtjob2";
            this.txtjob2.Size = new System.Drawing.Size(121, 21);
            this.txtjob2.TabIndex = 53;
            // 
            // FormAddEmployeeChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 346);
            this.Controls.Add(this.txtjob2);
            this.Controls.Add(this.txtNewPay);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtjob1);
            this.Controls.Add(this.txtdep1);
            this.Controls.Add(this.cbbdep2);
            this.Controls.Add(this.cbbnum);
            this.Controls.Add(this.txtexplain);
            this.Controls.Add(this.txtpay1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEmployeeChange";
            this.Text = "添加人员变动信息";
            this.Load += new System.EventHandler(this.FormAddEmployeeChange_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNewPay;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtjob1;
        private System.Windows.Forms.TextBox txtdep1;
        private System.Windows.Forms.ComboBox cbbdep2;
        private System.Windows.Forms.ComboBox cbbnum;
        private System.Windows.Forms.TextBox txtexplain;
        private System.Windows.Forms.TextBox txtpay1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtjob2;
    }
}