using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;
using Model.DataSetUsersTableAdapters;

namespace View
{
    public partial class UserForms : Form
    {
        BookController bookController = new BookController();
        public UserForms()
        {
            // creating an object for book controller 
           

            InitializeComponent();

            // connecting here so that the data gets loaded when we login.
            // connect to the controller
            bookController.GetallBooks();
            List<Books> books = bookController.GetallBooks();

            //display the data
            dataGridView1.DataSource = books;

        }

        private void search_Click(object sender, EventArgs e)
        {
            string sFilter, searchText;
            sFilter = filterComboBox.Text;
            searchText = searchTextBox.Text;
            bookController.BookSearch(sFilter, searchText);
            List<Books> book = bookController.BookSearch(sFilter, searchText);

            //display the data
            dataGridView1.DataSource = book;



        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            DataRowView selectedDataRow = (DataRowView)comboBox1.SelectedItem;
            String selectedISBN = dataGridView1.SelectedCells[0].Value.ToString();
            string username = comboBox1.Text;
            userController.ReserveBooks(selectedISBN, username);
            
            MessageBox.Show("Book reserved. Waiting for the librarian to accept the reserve request", "Reservation Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void UserForms_Load(object sender, EventArgs e)
        {
            this.tabUserTableAdapter.Fill(this.displayUserNameComboBox.TabUser);
            


        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnBookForms returnBookForms = new ReturnBookForms();
            returnBookForms.Show();
        }
    }
}
