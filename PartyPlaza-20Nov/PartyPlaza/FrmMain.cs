namespace PartyPlaza
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Navigating the Main page to the Display Supplier Form
            this.Hide();
            FrmSupplier frmSupplier = new FrmSupplier();
            frmSupplier.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            ButBooking.BackColor = Color.LightGray;
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ButCustomer.BackColor = Color.LightGray;
        }
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ButOrder.BackColor = Color.LightGray;
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            ButSupplier.BackColor = Color.LightGray;
        }
        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            ButBooking.BackColor = Color.Transparent;
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            ButCustomer.BackColor = Color.Transparent;
        }
        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            ButOrder.BackColor = Color.Transparent;
        }
        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            ButSupplier.BackColor = Color.Transparent;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void ButBooking_Click(object sender, EventArgs e)
        {
            //if (MyGlobals.frmEditForm)

            //FrmBooking frmBook = new FrmBooking();
            //frmBook.TopLevel = false;
            //frmBook.FormBorderStyle = FormBorderStyle.None;
            //frmBook.WindowState = FormWindowState.Maximized;
            //pnlMain.Controls.Add(frmBook);
            //frmBook.Show();



        }
        private void ButCustomer_Click(object sender, EventArgs e)
        {
            //if (MyGlobals.frmEditForm)
            
                FrmCustomer frmCust = new FrmCustomer();
                frmCust.TopLevel = false;
                frmCust.FormBorderStyle= FormBorderStyle.None;
                frmCust.WindowState = FormWindowState.Maximized;
                pnlMain.Controls.Add(frmCust);
                frmCust.Show();


            
        }
        private void ButOrder_Click(object sender, EventArgs e)
        {
            //if (MyGlobals.frmEditForm)

            //FrmBooking frmBook = new FrmBooking();
            //frmBook.TopLevel = false;
            //frmBook.FormBorderStyle = FormBorderStyle.None;
            //frmBook.WindowState = FormWindowState.Maximized;
            //pnlMain.Controls.Add(frmBook);
            //frmBook.Show();



        }
        private void ButSupplier_Click(object sender, EventArgs e)
        {
            //if (MyGlobals.frmEditForm)

            //FrmBooking frmBook = new FrmBooking();
            //frmBook.TopLevel = false;
            //frmBook.FormBorderStyle = FormBorderStyle.None;
            //frmBook.WindowState = FormWindowState.Maximized;
            //pnlMain.Controls.Add(frmBook);
            //frmBook.Show();



        }
    }
}