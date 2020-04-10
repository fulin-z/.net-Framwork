namespace SMGS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBI = new System.Windows.Forms.TabPage();
            this.btnPI = new System.Windows.Forms.Button();
            this.tpGM = new System.Windows.Forms.TabPage();
            this.btnCM = new System.Windows.Forms.Button();
            this.btnBR = new System.Windows.Forms.Button();
            this.btnOS = new System.Windows.Forms.Button();
            this.btnIS = new System.Windows.Forms.Button();
            this.tpSum = new System.Windows.Forms.TabPage();
            this.btnGIL = new System.Windows.Forms.Button();
            this.btnWG = new System.Windows.Forms.Button();
            this.btnGOL = new System.Windows.Forms.Button();
            this.tpHelp = new System.Windows.Forms.TabPage();
            this.btnRI = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUM = new System.Windows.Forms.Button();
            this.btnEP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpBI.SuspendLayout();
            this.tpGM.SuspendLayout();
            this.tpSum.SuspendLayout();
            this.tpHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, -16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 510);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBI);
            this.tabControl1.Controls.Add(this.tpGM);
            this.tabControl1.Controls.Add(this.tpSum);
            this.tabControl1.Controls.Add(this.tpHelp);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tpBI
            // 
            this.tpBI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpBI.BackgroundImage")));
            this.tpBI.Controls.Add(this.btnPI);
            this.tpBI.Location = new System.Drawing.Point(4, 22);
            this.tpBI.Name = "tpBI";
            this.tpBI.Padding = new System.Windows.Forms.Padding(3);
            this.tpBI.Size = new System.Drawing.Size(633, 467);
            this.tpBI.TabIndex = 1;
            this.tpBI.Text = "供应商信息";
            this.tpBI.UseVisualStyleBackColor = true;
            // 
            // btnPI
            // 
            this.btnPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPI.Location = new System.Drawing.Point(270, 178);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(103, 109);
            this.btnPI.TabIndex = 5;
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.BtnPI_Click);
            // 
            // tpGM
            // 
            this.tpGM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpGM.BackgroundImage")));
            this.tpGM.Controls.Add(this.btnCM);
            this.tpGM.Controls.Add(this.btnBR);
            this.tpGM.Controls.Add(this.btnOS);
            this.tpGM.Controls.Add(this.btnIS);
            this.tpGM.Location = new System.Drawing.Point(4, 22);
            this.tpGM.Name = "tpGM";
            this.tpGM.Padding = new System.Windows.Forms.Padding(3);
            this.tpGM.Size = new System.Drawing.Size(633, 467);
            this.tpGM.TabIndex = 0;
            this.tpGM.Text = "商品管理";
            this.tpGM.UseVisualStyleBackColor = true;
            // 
            // btnCM
            // 
            this.btnCM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCM.FlatAppearance.BorderSize = 0;
            this.btnCM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCM.Location = new System.Drawing.Point(274, 340);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(90, 99);
            this.btnCM.TabIndex = 3;
            this.btnCM.UseVisualStyleBackColor = true;
            this.btnCM.Click += new System.EventHandler(this.BtnCM_Click);
            // 
            // btnBR
            // 
            this.btnBR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBR.FlatAppearance.BorderSize = 0;
            this.btnBR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBR.Location = new System.Drawing.Point(428, 182);
            this.btnBR.Name = "btnBR";
            this.btnBR.Size = new System.Drawing.Size(87, 103);
            this.btnBR.TabIndex = 2;
            this.btnBR.UseVisualStyleBackColor = true;
            this.btnBR.Click += new System.EventHandler(this.BtnBR_Click);
            // 
            // btnOS
            // 
            this.btnOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOS.FlatAppearance.BorderSize = 0;
            this.btnOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOS.Location = new System.Drawing.Point(112, 182);
            this.btnOS.Name = "btnOS";
            this.btnOS.Size = new System.Drawing.Size(92, 103);
            this.btnOS.TabIndex = 1;
            this.btnOS.UseVisualStyleBackColor = true;
            this.btnOS.Click += new System.EventHandler(this.BtnOS_Click);
            // 
            // btnIS
            // 
            this.btnIS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIS.FlatAppearance.BorderSize = 0;
            this.btnIS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIS.ForeColor = System.Drawing.Color.Transparent;
            this.btnIS.Location = new System.Drawing.Point(274, 44);
            this.btnIS.Name = "btnIS";
            this.btnIS.Size = new System.Drawing.Size(90, 95);
            this.btnIS.TabIndex = 0;
            this.btnIS.UseVisualStyleBackColor = false;
            this.btnIS.Click += new System.EventHandler(this.BtnIS_Click);
            // 
            // tpSum
            // 
            this.tpSum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpSum.BackgroundImage")));
            this.tpSum.Controls.Add(this.btnGIL);
            this.tpSum.Controls.Add(this.btnWG);
            this.tpSum.Controls.Add(this.btnGOL);
            this.tpSum.Location = new System.Drawing.Point(4, 22);
            this.tpSum.Name = "tpSum";
            this.tpSum.Size = new System.Drawing.Size(633, 467);
            this.tpSum.TabIndex = 2;
            this.tpSum.Text = "查询统计";
            this.tpSum.UseVisualStyleBackColor = true;
            // 
            // btnGIL
            // 
            this.btnGIL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGIL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGIL.Location = new System.Drawing.Point(132, 287);
            this.btnGIL.Name = "btnGIL";
            this.btnGIL.Size = new System.Drawing.Size(89, 104);
            this.btnGIL.TabIndex = 14;
            this.btnGIL.UseVisualStyleBackColor = true;
            this.btnGIL.Click += new System.EventHandler(this.BtnGIL_Click);
            // 
            // btnWG
            // 
            this.btnWG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWG.Location = new System.Drawing.Point(403, 285);
            this.btnWG.Name = "btnWG";
            this.btnWG.Size = new System.Drawing.Size(96, 115);
            this.btnWG.TabIndex = 15;
            this.btnWG.UseVisualStyleBackColor = true;
            this.btnWG.Click += new System.EventHandler(this.BtnWG_Click);
            // 
            // btnGOL
            // 
            this.btnGOL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGOL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGOL.Location = new System.Drawing.Point(271, 30);
            this.btnGOL.Name = "btnGOL";
            this.btnGOL.Size = new System.Drawing.Size(85, 95);
            this.btnGOL.TabIndex = 13;
            this.btnGOL.UseVisualStyleBackColor = true;
            this.btnGOL.Click += new System.EventHandler(this.BtnGOL_Click);
            // 
            // tpHelp
            // 
            this.tpHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpHelp.BackgroundImage")));
            this.tpHelp.Controls.Add(this.btnRI);
            this.tpHelp.Controls.Add(this.btnExit);
            this.tpHelp.Controls.Add(this.btnUM);
            this.tpHelp.Controls.Add(this.btnEP);
            this.tpHelp.Location = new System.Drawing.Point(4, 22);
            this.tpHelp.Name = "tpHelp";
            this.tpHelp.Size = new System.Drawing.Size(633, 467);
            this.tpHelp.TabIndex = 4;
            this.tpHelp.Text = "用户和权限";
            this.tpHelp.UseVisualStyleBackColor = true;
            // 
            // btnRI
            // 
            this.btnRI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRI.Location = new System.Drawing.Point(101, 200);
            this.btnRI.Name = "btnRI";
            this.btnRI.Size = new System.Drawing.Size(85, 89);
            this.btnRI.TabIndex = 20;
            this.btnRI.UseVisualStyleBackColor = true;
            this.btnRI.Click += new System.EventHandler(this.BtnRI_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(274, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 84);
            this.btnExit.TabIndex = 23;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnUM
            // 
            this.btnUM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUM.Location = new System.Drawing.Point(263, 15);
            this.btnUM.Name = "btnUM";
            this.btnUM.Size = new System.Drawing.Size(106, 104);
            this.btnUM.TabIndex = 21;
            this.btnUM.UseVisualStyleBackColor = true;
            this.btnUM.Click += new System.EventHandler(this.BtnUM_Click);
            // 
            // btnEP
            // 
            this.btnEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEP.Location = new System.Drawing.Point(426, 182);
            this.btnEP.Name = "btnEP";
            this.btnEP.Size = new System.Drawing.Size(94, 99);
            this.btnEP.TabIndex = 19;
            this.btnEP.UseVisualStyleBackColor = true;
            this.btnEP.Click += new System.EventHandler(this.BtnEP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(47, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "当前登录用户为：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(251, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "您的用户权限为：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(442, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "当前系统时间：";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.ForeColor = System.Drawing.Color.Red;
            this.labelUser.Location = new System.Drawing.Point(155, 499);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 12);
            this.labelUser.TabIndex = 16;
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.ForeColor = System.Drawing.Color.Red;
            this.labelRight.Location = new System.Drawing.Point(358, 498);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(0, 12);
            this.labelRight.TabIndex = 17;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(537, 497);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 12);
            this.labelTime.TabIndex = 18;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 514);
            this.ControlBox = false;
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "超市后台管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpBI.ResumeLayout(false);
            this.tpGM.ResumeLayout(false);
            this.tpSum.ResumeLayout(false);
            this.tpHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGM;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.Button btnBR;
        private System.Windows.Forms.Button btnOS;
        private System.Windows.Forms.Button btnIS;
        private System.Windows.Forms.TabPage tpBI;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.TabPage tpSum;
        private System.Windows.Forms.Button btnGIL;
        private System.Windows.Forms.Button btnWG;
        private System.Windows.Forms.Button btnGOL;
        private System.Windows.Forms.TabPage tpHelp;
        private System.Windows.Forms.Button btnRI;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUM;
        private System.Windows.Forms.Button btnEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelTime;
    }
}