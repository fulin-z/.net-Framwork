namespace EMS.SubForms
{
    partial class FormSelectStock
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
            this.dgvSelectStockList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectStockList
            // 
            this.dgvSelectStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectStockList.Location = new System.Drawing.Point(0, 1);
            this.dgvSelectStockList.Name = "dgvSelectStockList";
            this.dgvSelectStockList.RowTemplate.Height = 23;
            this.dgvSelectStockList.Size = new System.Drawing.Size(566, 199);
            this.dgvSelectStockList.TabIndex = 2;
            this.dgvSelectStockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSelectStockList_CellDoubleClick);
            // 
            // FormSelectStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 200);
            this.Controls.Add(this.dgvSelectStockList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectStock";
            this.Text = "选择-库存商品";
            this.Load += new System.EventHandler(this.FormSelectStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectStockList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectStockList;
    }
}