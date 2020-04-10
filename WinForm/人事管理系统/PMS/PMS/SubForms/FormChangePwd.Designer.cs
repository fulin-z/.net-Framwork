namespace PMS.SubForms
{
    partial class FormChangePwd
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
            this.textboxNNewPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxNewPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxOldPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(194, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "退出";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSure
            // 
            this.btnSure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSure.Location = new System.Drawing.Point(121, 118);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(58, 23);
            this.btnSure.TabIndex = 25;
            this.btnSure.Text = "确定";
            this.btnSure.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.BtnSure_Click);
            // 
            // textboxNNewPwd
            // 
            this.textboxNNewPwd.Location = new System.Drawing.Point(90, 87);
            this.textboxNNewPwd.Name = "textboxNNewPwd";
            this.textboxNNewPwd.PasswordChar = '*';
            this.textboxNNewPwd.Size = new System.Drawing.Size(100, 21);
            this.textboxNNewPwd.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "确认新密码：";
            // 
            // textboxNewPwd
            // 
            this.textboxNewPwd.Location = new System.Drawing.Point(90, 60);
            this.textboxNewPwd.Name = "textboxNewPwd";
            this.textboxNewPwd.PasswordChar = '*';
            this.textboxNewPwd.Size = new System.Drawing.Size(100, 21);
            this.textboxNewPwd.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "新密码：";
            // 
            // textboxOldPwd
            // 
            this.textboxOldPwd.Location = new System.Drawing.Point(90, 33);
            this.textboxOldPwd.Name = "textboxOldPwd";
            this.textboxOldPwd.PasswordChar = '*';
            this.textboxOldPwd.Size = new System.Drawing.Size(100, 21);
            this.textboxOldPwd.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "旧密码：";
            // 
            // textboxUserName
            // 
            this.textboxUserName.Location = new System.Drawing.Point(90, 6);
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.ReadOnly = true;
            this.textboxUserName.Size = new System.Drawing.Size(100, 21);
            this.textboxUserName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "用户名：";
            // 
            // FormChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 159);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.textboxNNewPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxNewPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxOldPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangePwd";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FormChangePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.TextBox textboxNNewPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxNewPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxOldPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxUserName;
        private System.Windows.Forms.Label label1;
    }
}