namespace EMS.SubForms
{
    partial class FormUserPwd
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSure = new System.Windows.Forms.Button();
            this.txtboxNNewPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxNewPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxOldPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(194, 121);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 23);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "退出";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSure
            // 
            this.btnSure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSure.Location = new System.Drawing.Point(121, 121);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(58, 23);
            this.btnSure.TabIndex = 35;
            this.btnSure.Text = "确定";
            this.btnSure.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.BtnSure_Click);
            // 
            // txtboxNNewPwd
            // 
            this.txtboxNNewPwd.Location = new System.Drawing.Point(90, 90);
            this.txtboxNNewPwd.Name = "txtboxNNewPwd";
            this.txtboxNNewPwd.PasswordChar = '*';
            this.txtboxNNewPwd.Size = new System.Drawing.Size(100, 21);
            this.txtboxNNewPwd.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "确认新密码：";
            // 
            // txtboxNewPwd
            // 
            this.txtboxNewPwd.Location = new System.Drawing.Point(90, 63);
            this.txtboxNewPwd.Name = "txtboxNewPwd";
            this.txtboxNewPwd.PasswordChar = '*';
            this.txtboxNewPwd.Size = new System.Drawing.Size(100, 21);
            this.txtboxNewPwd.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "新密码：";
            // 
            // txtboxOldPwd
            // 
            this.txtboxOldPwd.Location = new System.Drawing.Point(90, 36);
            this.txtboxOldPwd.Name = "txtboxOldPwd";
            this.txtboxOldPwd.PasswordChar = '*';
            this.txtboxOldPwd.Size = new System.Drawing.Size(100, 21);
            this.txtboxOldPwd.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "旧密码：";
            // 
            // txtboxUserName
            // 
            this.txtboxUserName.Enabled = false;
            this.txtboxUserName.Location = new System.Drawing.Point(90, 9);
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.ReadOnly = true;
            this.txtboxUserName.Size = new System.Drawing.Size(100, 21);
            this.txtboxUserName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "用户名：";
            // 
            // FormUserPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 159);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.txtboxNNewPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxNewPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxOldPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserPwd";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FormUserPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.TextBox txtboxNNewPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxNewPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxOldPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxUserName;
        private System.Windows.Forms.Label label1;
    }
}