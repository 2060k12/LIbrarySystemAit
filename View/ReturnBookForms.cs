using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ReturnBookForms : Form
    {
        BookController bookController = new BookController();
        public ReturnBookForms()
        {
            InitializeComponent();
            List<BorrowBooks> borrowBooks = bookController.GetBorrowedBooks();
            dataGridView1.DataSource = borrowBooks;



        }


        private void button1_Click(object sender, EventArgs e)
        {
            string selectedIsbn = dataGridView1.SelectedCells[1].Value.ToString();
            bookController.ReturnBook(selectedIsbn);
            MessageBox.Show("Book has been returned successfully", "Reservation Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
