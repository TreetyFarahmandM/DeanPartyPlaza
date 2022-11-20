using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlaza
{
   
    public partial class FrmSupplier : Form
    {
        bool visible = true;

        SqlDataAdapter daSupplier;
        DataSet dsPartyPlaza = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;
        public FrmSupplier()
        {
            InitializeComponent();
        }
        private void frmDisplaySupplier_load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .; Initial Catalog = PartyPlaza; Intergrated Security = true";
            //DESKTOP-5PH67NH\SQLEXPRESS01
            connStr = @"Data Source = DESKTOP-5PH67NH\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);

            daSupplier.FillSchema(dsPartyPlaza, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsPartyPlaza, "Supplier");

            dgvSupplier.DataSource = dsPartyPlaza.Tables["Supplier"];

            dgvSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        
        private void btnDisplayAdd_Click_1(object sender, EventArgs e)
        {
            //Navigating the Supplier page to the Add Supplier Form
            this.Hide();
            frmAddSupplier FrmAddSupplier = new frmAddSupplier();
            FrmAddSupplier.ShowDialog();
            this.Close();
        }
        private void btnDisplayEdit_Click(object sender, EventArgs e)
        {
            //Navigating the Supplier page to the Edit Supplier Form
            if (dgvSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier from the list provided", "Select Supplier");
            }
            else if (dgvSupplier.SelectedRows.Count == 1)
            {
                //Navigating the Supplier page to the Edit Supplier Form
                this.Hide();
                FrmEditSupplier frmEditSupplier = new FrmEditSupplier();
                frmEditSupplier.ShowDialog();
                this.Close();

            }
        }
        private void btnDisplayExit_Click(object sender, EventArgs e)
        {
            //Navigating the Supplier page to the Main Form
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            this.Close();
        }
        private void btnDisplayDelete_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.Rows.Count == 0)
                MessageBox.Show("Please select a Supplier from the list.", "Select Supplier");

            else
            {
                drSupplier = dsPartyPlaza.Tables["Supplier"].Rows.Find(dgvSupplier.SelectedRows[0].Cells[0].Value);
                String tempName = drSupplier["Business Name"].ToString();

                if (MessageBox.Show("Are you sure you want to delete" + tempName + " details?", "Add Supplier",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drSupplier.Delete();
                    daSupplier.Update(dsPartyPlaza, "Supplier");
                }
            }
        }
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = DESKTOP-5PH67NH\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);

            daSupplier.FillSchema(dsPartyPlaza, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsPartyPlaza, "Supplier");
            dgvSupplier.DataSource = dsPartyPlaza.Tables["Supplier"];

            //Resize the DataGridView colums to fit the newly loaded content.
            dgvSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
