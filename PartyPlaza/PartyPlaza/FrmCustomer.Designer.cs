namespace PartyPlaza
{
    partial class FrmCustomer
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
            this.butEditCust = new System.Windows.Forms.Button();
            this.butDeleteCust = new System.Windows.Forms.Button();
            this.butExitCust = new System.Windows.Forms.Button();
            this.butAddCust = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // butEditCust
            // 
            this.butEditCust.Location = new System.Drawing.Point(590, 78);
            this.butEditCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butEditCust.Name = "butEditCust";
            this.butEditCust.Size = new System.Drawing.Size(183, 44);
            this.butEditCust.TabIndex = 9;
            this.butEditCust.Text = "Edit";
            this.butEditCust.UseVisualStyleBackColor = true;
            // 
            // butDeleteCust
            // 
            this.butDeleteCust.Location = new System.Drawing.Point(590, 148);
            this.butDeleteCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeleteCust.Name = "butDeleteCust";
            this.butDeleteCust.Size = new System.Drawing.Size(183, 44);
            this.butDeleteCust.TabIndex = 8;
            this.butDeleteCust.Text = "Delete";
            this.butDeleteCust.UseVisualStyleBackColor = true;
            // 
            // butExitCust
            // 
            this.butExitCust.Location = new System.Drawing.Point(590, 215);
            this.butExitCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butExitCust.Name = "butExitCust";
            this.butExitCust.Size = new System.Drawing.Size(183, 44);
            this.butExitCust.TabIndex = 7;
            this.butExitCust.Text = "Exit";
            this.butExitCust.UseVisualStyleBackColor = true;
            this.butExitCust.Click += new System.EventHandler(this.butExitCust_Click);
            // 
            // butAddCust
            // 
            this.butAddCust.Location = new System.Drawing.Point(590, 11);
            this.butAddCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAddCust.Name = "butAddCust";
            this.butAddCust.Size = new System.Drawing.Size(183, 44);
            this.butAddCust.TabIndex = 6;
            this.butAddCust.Text = "Add";
            this.butAddCust.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(12, 11);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 29;
            this.dgvCustomer.Size = new System.Drawing.Size(560, 361);
            this.dgvCustomer.TabIndex = 5;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 388);
            this.Controls.Add(this.butEditCust);
            this.Controls.Add(this.butDeleteCust);
            this.Controls.Add(this.butExitCust);
            this.Controls.Add(this.butAddCust);
            this.Controls.Add(this.dgvCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button butEditCust;
        private Button butDeleteCust;
        private Button butExitCust;
        private Button butAddCust;
        private DataGridView dgvCustomer;
    }
}