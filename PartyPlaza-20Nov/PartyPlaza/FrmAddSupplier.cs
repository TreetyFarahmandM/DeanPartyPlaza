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
    public partial class frmAddSupplier : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsPartyPlaza = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;

        public frmAddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = DESKTOP-5PH67NH\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlSupplier = @"select * from Supplier ";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsPartyPlaza, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsPartyPlaza, "Supplier");
            
            int noRows = dsPartyPlaza.Tables["Supplier"].Rows.Count;

            if (noRows == 0)
                lblAddSupplierNo.Text = "10000";
            else
            {
                getNumber(noRows);
            }
           // ErrorProvider.Clear();
            clearAddForm();
        }
        void ErrorProvider()
        {

        }
        void clearAddForm()
        {
            txtAddForename.Clear();
            txtAddSurname.Clear();
            txtAddStreet.Clear();
            txtAddCounty.Clear();
            txtAddTown.Clear();
            txtAddCounty.Clear();
            txtAddPostcode.Clear();
            txtAddTelNo.Clear();

        }
        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            MySupplier mySupplier = new MySupplier();
            bool ok = true;
            errP.Clear();

            try
            {
                mySupplier.IDNum = Convert.ToInt32(lblAddSupplierNo.Text.Trim());
                //passed to Supplier class to check 
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddSupplierNo, MyEx.toString());
            }
       
            try
            {
                mySupplier.ContactSurname = txtAddSurname.Text.Trim();
                //passed to Supplier class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSurname, MyEx.toString());
            }
            try
            {
                mySupplier.ContactForename = txtAddForename.Text.Trim();
                //passed to Supplier class to check

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddForename, MyEx.toString());
            }
            try
            {
                mySupplier.Street = txtAddStreet.Text.Trim();
                //passed to Supplier class to check

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddStreet, MyEx.toString());
            }
            try
            {
                mySupplier.Town = txtAddTown.Text.Trim();
                //passed to Supplier class to check

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddTown, MyEx.toString());
            }
            try
            {
                mySupplier.County = txtAddCounty.Text.Trim();
                //passed to Supplier class to check

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddCounty, MyEx.toString());
            }
            try
            {
                mySupplier.Postcode = txtAddPostcode.Text.Trim();
                //passed to Supplier class to check

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddPostcode, MyEx.toString());
            }
            try
            {
                mySupplier.TelNum = txtAddTelNo.Text.Trim();
                //passed to Supplier class to check

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddTelNo, MyEx.toString());
            }

            try
            {
                mySupplier.Email = txtAddEmail.Text.Trim();
                //passed to Supplier class to check

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddEmail, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drSupplier = dsPartyPlaza.Tables["Supplier"].NewRow();

                    drSupplier["CustomerNo"] = mySupplier.IDNum;
                    drSupplier["Forename"] = mySupplier.ContactForename;
                    drSupplier["Surname"] = mySupplier.ContactSurname;
                    drSupplier["Street"] = mySupplier.Street;
                    drSupplier["Town"] = mySupplier.Town;
                    drSupplier["County"] = mySupplier.County;
                    drSupplier["Postcode"] = mySupplier.Postcode;
                    drSupplier["TelNo"] = mySupplier.TelNum;
                    drSupplier["Email"] = mySupplier.Email;

                    dsPartyPlaza.Tables["Supplier"].Rows.Add(drSupplier);
                    daSupplier.Update(dsPartyPlaza, "Supplier");

                    MessageBox.Show("Supplier Added");

                    if (MessageBox.Show("Do you wish to add another supplier?",
                        "Add Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsPartyPlaza.Tables["Supplier"].Rows.Count);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Navigating the page to the Supplier Display Form
            this.Hide();
            FrmSupplier frmSupplier = new FrmSupplier();
            frmSupplier.ShowDialog();
            this.Close();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {

        }
        private void getNumber(int noRows)
        {
            drSupplier = dsPartyPlaza.Tables["Supplier"].Rows[noRows - 1];
            lblAddSupplierNo.Text = (int.Parse(drSupplier["SupplierNo"].ToString() + 1).ToString());
        }
    }
}
