namespace tools
{
    partial class AddressValidatedListForm
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
            this.dgvAutoList = new System.Windows.Forms.DataGridView();
            this.dgvManualList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBulkOK = new System.Windows.Forms.Button();
            this.btnBulkNG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManualList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutoList
            // 
            this.dgvAutoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoList.Location = new System.Drawing.Point(28, 45);
            this.dgvAutoList.Name = "dgvAutoList";
            this.dgvAutoList.RowHeadersWidth = 51;
            this.dgvAutoList.RowTemplate.Height = 24;
            this.dgvAutoList.Size = new System.Drawing.Size(1687, 290);
            this.dgvAutoList.TabIndex = 0;
            // 
            // dgvManualList
            // 
            this.dgvManualList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManualList.Location = new System.Drawing.Point(28, 454);
            this.dgvManualList.Name = "dgvManualList";
            this.dgvManualList.RowHeadersWidth = 51;
            this.dgvManualList.RowTemplate.Height = 24;
            this.dgvManualList.Size = new System.Drawing.Size(1687, 257);
            this.dgvManualList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "The orders below can be created and printed automatically";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(25, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "The orders below need to be created and printed manually";
            // 
            // btnBulkOK
            // 
            this.btnBulkOK.Location = new System.Drawing.Point(1430, 14);
            this.btnBulkOK.Name = "btnBulkOK";
            this.btnBulkOK.Size = new System.Drawing.Size(285, 28);
            this.btnBulkOK.TabIndex = 3;
            this.btnBulkOK.Text = "Bulk creating and printing orders";
            this.btnBulkOK.UseVisualStyleBackColor = true;
            this.btnBulkOK.Click += new System.EventHandler(this.btnBulkOK_Click);
            // 
            // btnBulkNG
            // 
            this.btnBulkNG.Location = new System.Drawing.Point(1430, 420);
            this.btnBulkNG.Name = "btnBulkNG";
            this.btnBulkNG.Size = new System.Drawing.Size(285, 28);
            this.btnBulkNG.TabIndex = 3;
            this.btnBulkNG.Text = "Create and print orders manually";
            this.btnBulkNG.UseVisualStyleBackColor = true;
            this.btnBulkNG.Click += new System.EventHandler(this.btnBulkNG_Click);
            // 
            // AddressValidatedListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 753);
            this.Controls.Add(this.btnBulkNG);
            this.Controls.Add(this.btnBulkOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvManualList);
            this.Controls.Add(this.dgvAutoList);
            this.Name = "AddressValidatedListForm";
            this.Text = "AddressValidatedListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManualList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutoList;
        private System.Windows.Forms.DataGridView dgvManualList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBulkOK;
        private System.Windows.Forms.Button btnBulkNG;
    }
}