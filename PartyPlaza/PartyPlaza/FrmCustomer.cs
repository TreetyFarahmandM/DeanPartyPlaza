using System;
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
    public partial class FrmCustomer : Form
    {
        SqlDataAdapter daCustomer;
        DataSet partyPlaza = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String connStr, sqlCustomer;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        connStr = @"Data Source = 286386-PC\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(partyPlaza, SchemaType.Source, "Customer");
            daCustomer.Fill(partyPlaza, "Customer");

            dgvCustomer.DataSource = partyPlaza.Tables["Customer"];
            dgvCustomer.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells);
        }

      
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butExitCust_Click(object sender, EventArgs e)
        {
            MyGlobals.frmClosing = true;
            Close();
        }

        private void btnDeleteDisplay_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer from the list.", "Select Customer");
            }
            else
            {
                drCustomer = partyPlaza.Tables["Customer"].Rows.Find(dgvCustomer.SelectedRows[0].Cells[0].Value);
                string tempName = drCustomer["Forename"].ToString() + " " + drCustomer["Surname"].ToString();

                if (MessageBox.Show("Are you sure you want to delete " + tempName + " details? ", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drCustomer.Delete();
                    daCustomer.Update(partyPlaza, "Customer");
                }
            }
        }
    }
}
