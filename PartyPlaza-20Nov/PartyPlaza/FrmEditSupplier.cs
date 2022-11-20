using PartyPlaza;
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
    public partial class FrmEditSupplier : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsPartyPlaza = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;
        public FrmEditSupplier()
        {
            InitializeComponent();
        }
        private void btnEditEdit_Click(object sender, EventArgs e)
        { 
            if (lblEditSupplierNo.Text == "Edit")
                {
                    txtEditBusinessName.Enabled = true;
                    txtEditForename.Enabled = true;
                    txtEditSurname.Enabled = true;
                    txtEditStreet.Enabled = true;
                    txtEditTown.Enabled = true;
                    txtEditCounty.Enabled = true;
                    txtEditPostcode.Enabled = true;
                    txtEditTelNo.Enabled = true;

                    lblEditSupplierNo.Text = "Save";
            }
            else
            {
                MySupplier mySupplier = new MySupplier();
                bool ok = true;
                errP.Clear();

                //This set of codes is for
                try
                {
                    mySupplier.IDNum = Convert.ToInt32(lblEditSupplierNo.Text.Trim());
                    //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblEditSupplierNo, MyEx.toString());
                }
                try
                {
                mySupplier.BusinessName = txtEditBusinessName.Text.Trim();
                //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                ok = false;
                errP.SetError(txtEditBusinessName, MyEx.toString());
                }
                try
                {
                mySupplier.ContactSurname = txtEditSurname.Text.Trim();
                //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                ok = false;
                errP.SetError(txtEditSurname, MyEx.toString());
                }
                try
                {
                mySupplier.ContactForename = txtEditForename.Text.Trim();
                //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                ok = false;
                errP.SetError(txtEditForename, MyEx.toString());
                }
                try
                {
                mySupplier.Street = txtEditStreet.Text.Trim();
                //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                ok = false;
                errP.SetError(txtEditStreet, MyEx.toString());
                }
                try
                {
                mySupplier.Town = txtEditTown.Text.Trim();
                //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                ok = false;
                errP.SetError(txtEditTown, MyEx.toString());
                }
                try
                {
                mySupplier.County = txtEditCounty.Text.Trim();
                //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                ok = false;
                errP.SetError(txtEditCounty, MyEx.toString());
                }
                try
                {
                mySupplier.Postcode = txtEditPostcode.Text.Trim();
                //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                ok = false;
                errP.SetError(txtEditPostcode, MyEx.toString());
                }
                try
                {
                mySupplier.TelNum = txtEditTelNo.Text.Trim();
                //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                ok = false;
                errP.SetError(txtEditTelNo, MyEx.toString());
                }
                try
                {

                mySupplier.Email = txtEditEmail.Text.Trim();
                //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                ok = false;
                errP.SetError(txtEditEmail, MyEx.toString());
                }
                try
                {
                    if (ok)
                    {
                        drSupplier.BeginEdit();

                        drSupplier["SupplierNo"] = mySupplier.IDNum;
                        drSupplier["BusinessName"] = mySupplier.BusinessName;
                        drSupplier["ContactForename"] = mySupplier.ContactForename;
                        drSupplier["ContactSurname"] = mySupplier.ContactSurname;
                        drSupplier["Street"] = mySupplier.Street;
                        drSupplier["Town"] = mySupplier.Town;
                        drSupplier["County"] = mySupplier.County;
                        drSupplier["Postcode"] = mySupplier.Postcode;
                        drSupplier["TelNo"] = mySupplier.TelNum;
                        drSupplier["Email"] = mySupplier.Email;

                        drSupplier.EndEdit();
                        daSupplier.Update(dsPartyPlaza, "Supplier");

                        MessageBox.Show("Supplier Details Updated", "Supplier");

                        txtEditBusinessName.Enabled = false;
                        txtEditForename.Enabled = false;
                        txtEditSurname.Enabled = false;
                        txtEditStreet.Enabled = false;
                        txtEditTown.Enabled = false;
                        txtEditCounty.Enabled = false;
                        txtEditPostcode.Enabled = false;
                        txtEditTelNo.Enabled = false;
                        txtEditEmail.Enabled = false;

                        lblEditSupplierNo.Text = "Edit";
                        //tabCustomer.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Navigating the Edit Supplier page to the Supplier Display Form
            this.Hide();
            FrmSupplier frmSupplier = new FrmSupplier();
            frmSupplier.ShowDialog();
            this.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
