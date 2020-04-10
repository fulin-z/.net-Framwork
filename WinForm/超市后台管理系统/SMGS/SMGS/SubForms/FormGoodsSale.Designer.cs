namespace SMGS.SubForms
{
    partial class FormGoodsSale
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGSPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labGPrice = new System.Windows.Forms.Label();
            this.txtGOPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOSRemark = new System.Windows.Forms.TextBox();
            this.cboxGName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHPeople = new System.Windows.Forms.TextBox();
            this.cboxGUnit = new System.Windows.Forms.ComboBox();
            this.txtOSGNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "计量单位";
            // 
            // txtGSPrice
            // 
            this.txtGSPrice.Location = new System.Drawing.Point(95, 91);
            this.txtGSPrice.Name = "txtGSPrice";
            this.txtGSPrice.ReadOnly = true;
            this.txtGSPrice.Size = new System.Drawing.Size(100, 21);
            this.txtGSPrice.TabIndex = 11;
            this.txtGSPrice.Click += new System.EventHandler(this.TxtGSPrice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "购买数量";
            // 
            // labGPrice
            // 
            this.labGPrice.AutoSize = true;
            this.labGPrice.Location = new System.Drawing.Point(217, 100);
            this.labGPrice.Name = "labGPrice";
            this.labGPrice.Size = new System.Drawing.Size(53, 12);
            this.labGPrice.TabIndex = 14;
            this.labGPrice.Text = "商品单价";
            this.labGPrice.Click += new System.EventHandler(this.LabGPrice_Click);
            // 
            // txtGOPrice
            // 
            this.txtGOPrice.Location = new System.Drawing.Point(276, 91);
            this.txtGOPrice.Name = "txtGOPrice";
            this.txtGOPrice.ReadOnly = true;
            this.txtGOPrice.Size = new System.Drawing.Size(100, 21);
            this.txtGOPrice.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "备注";
            // 
            // txtOSRemark
            // 
            this.txtOSRemark.Location = new System.Drawing.Point(95, 171);
            this.txtOSRemark.Multiline = true;
            this.txtOSRemark.Name = "txtOSRemark";
            this.txtOSRemark.Size = new System.Drawing.Size(291, 48);
            this.txtOSRemark.TabIndex = 8;
            // 
            // cboxGName
            // 
            this.cboxGName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGName.FormattingEnabled = true;
            this.cboxGName.Location = new System.Drawing.Point(95, 20);
            this.cboxGName.Name = "cboxGName";
            this.cboxGName.Size = new System.Drawing.Size(100, 20);
            this.cboxGName.TabIndex = 1;
            this.cboxGName.SelectedIndexChanged += new System.EventHandler(this.CboxGName_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "总金额";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "经手人";
            // 
            // txtHPeople
            // 
            this.txtHPeople.Location = new System.Drawing.Point(95, 133);
            this.txtHPeople.Name = "txtHPeople";
            this.txtHPeople.Size = new System.Drawing.Size(100, 21);
            this.txtHPeople.TabIndex = 7;
            // 
            // cboxGUnit
            // 
            this.cboxGUnit.FormattingEnabled = true;
            this.cboxGUnit.Items.AddRange(new object[] {
            "个",
            "件",
            "瓶",
            "斤",
            "两",
            "公斤",
            "千克",
            "吨",
            "米",
            "台",
            "部",
            "辆"});
            this.cboxGUnit.Location = new System.Drawing.Point(276, 53);
            this.cboxGUnit.MaxDropDownItems = 100;
            this.cboxGUnit.Name = "cboxGUnit";
            this.cboxGUnit.Size = new System.Drawing.Size(100, 20);
            this.cboxGUnit.TabIndex = 3;
            // 
            // txtOSGNum
            // 
            this.txtOSGNum.Location = new System.Drawing.Point(95, 52);
            this.txtOSGNum.Name = "txtOSGNum";
            this.txtOSGNum.Size = new System.Drawing.Size(100, 21);
            this.txtOSGNum.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOSGNum);
            this.groupBox1.Controls.Add(this.cboxGUnit);
            this.groupBox1.Controls.Add(this.txtHPeople);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboxGName);
            this.groupBox1.Controls.Add(this.txtOSRemark);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGOPrice);
            this.groupBox1.Controls.Add(this.labGPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGSPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 237);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(34, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "结算";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(170, 43);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "清空";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(311, 43);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "退出";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 88);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "商品编号";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtGID
            // 
            this.txtGID.Location = new System.Drawing.Point(276, 19);
            this.txtGID.Name = "txtGID";
            this.txtGID.ReadOnly = true;
            this.txtGID.Size = new System.Drawing.Size(100, 21);
            this.txtGID.TabIndex = 23;
            // 
            // FormGoodsSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGoodsSale";
            this.Text = "商品出售";
            this.Load += new System.EventHandler(this.FormGoodsSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGSPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labGPrice;
        private System.Windows.Forms.TextBox txtGOPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOSRemark;
        private System.Windows.Forms.ComboBox cboxGName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHPeople;
        private System.Windows.Forms.ComboBox cboxGUnit;
        private System.Windows.Forms.TextBox txtOSGNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGID;
        private System.Windows.Forms.Label label1;
    }
}