using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace View
{
    public partial class ApproveBorrowForms : Form
    {
        BookController bookController = new BookController();
        public ApproveBorrowForms()
        {
            InitializeComponent();
            DisplayReserves();
        }


        public void DisplayReserves()
        {
            bookController.DisplayReserves();
            List<ReservedBooks> reservedBooks = bookController.DisplayReserves();
            // display the data
            dataGridView1.DataSource = reservedBooks;
        }
        private void accept_Click(object sender, EventArgs e) {

            // Get the selected reservation information from TabReserved
            // DataRowView selectedDataRow = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;

            ReservedBooks selectedReservation = (ReservedBooks)dataGridView1.SelectedRows[0].DataBoundItem;

            string UID = selectedReservation.UID1;
            string isbn = selectedReservation.ISBN1;
            string reservedDate = selectedReservation.ReservedDate1;
            bookController.AcceptBorrowReq(UID, isbn,reservedDate );
            DisplayReserves();

            MessageBox.Show(" Book Successfully Reserved");





        }

    }
}
