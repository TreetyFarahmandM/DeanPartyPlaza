namespace PartyPlaza
{
    partial class FrmSupplier
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplayExit = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnDisplayDelete = new System.Windows.Forms.Button();
            this.btnDisplayEdit = new System.Windows.Forms.Button();
            this.btnDisplayAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 45);
            this.label1.TabIndex = 78;
            this.label1.Text = "Suppliers List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDisplayExit
            // 
            this.btnDisplayExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDisplayExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayExit.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayExit.Location = new System.Drawing.Point(875, 635);
            this.btnDisplayExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplayExit.Name = "btnDisplayExit";
            this.btnDisplayExit.Size = new System.Drawing.Size(309, 71);
            this.btnDisplayExit.TabIndex = 76;
            this.btnDisplayExit.Text = "Exit";
            this.btnDisplayExit.UseVisualStyleBackColor = false;
            this.btnDisplayExit.Click += new System.EventHandler(this.btnDisplayExit_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(47, 82);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.Size = new System.Drawing.Size(596, 646);
            this.dgvSupplier.TabIndex = 77;
            // 
            // btnDisplayDelete
            // 
            this.btnDisplayDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDisplayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayDelete.Location = new System.Drawing.Point(875, 529);
            this.btnDisplayDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplayDelete.Name = "btnDisplayDelete";
            this.btnDisplayDelete.Size = new System.Drawing.Size(309, 71);
            this.btnDisplayDelete.TabIndex = 75;
            this.btnDisplayDelete.Text = "Delete";
            this.btnDisplayDelete.UseVisualStyleBackColor = false;
            // 
            // btnDisplayEdit
            // 
            this.btnDisplayEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDisplayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayEdit.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayEdit.Location = new System.Drawing.Point(875, 429);
            this.btnDisplayEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplayEdit.Name = "btnDisplayEdit";
            this.btnDisplayEdit.Size = new System.Drawing.Size(309, 71);
            this.btnDisplayEdit.TabIndex = 74;
            this.btnDisplayEdit.Text = "Edit";
            this.btnDisplayEdit.UseVisualStyleBackColor = false;
            this.btnDisplayEdit.Click += new System.EventHandler(this.btnDisplayEdit_Click_1);
            // 
            // btnDisplayAdd
            // 
            this.btnDisplayAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDisplayAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayAdd.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayAdd.Location = new System.Drawing.Point(875, 325);
            this.btnDisplayAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplayAdd.Name = "btnDisplayAdd";
            this.btnDisplayAdd.Size = new System.Drawing.Size(309, 71);
            this.btnDisplayAdd.TabIndex = 73;
            this.btnDisplayAdd.Text = "Add";
            this.btnDisplayAdd.UseVisualStyleBackColor = false;
            this.btnDisplayAdd.Click += new System.EventHandler(this.btnDisplayAdd_Click_1);
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1231, 760);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayExit);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.btnDisplayDelete);
            this.Controls.Add(this.btnDisplayEdit);
            this.Controls.Add(this.btnDisplayAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSupplier";
            this.Text = "Supplier Form";
            this.Load += new System.EventHandler(this.frmDisplaySupplier_load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Label label1;
        private Button btnDisplayExit;
        private DataGridView dgvSupplier;
        private Button btnDisplayDelete;
        private Button btnDisplayEdit;
        private Button btnDisplayAdd;
    }
}