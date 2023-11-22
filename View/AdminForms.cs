using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View
{

    public partial class AdminForms : Form
    {
        BookController bookController = new BookController();
        public void displayBooks()
        {
            bookController.GetallBooks();
            List<Books> books = bookController.GetallBooks();
            dataGridView1.DataSource = books;

        }

        public AdminForms()
        {
            InitializeComponent();


            //display the data
            displayBooks();
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            String selectedISBN = dataGridView1.SelectedCells[0].Value.ToString();
            
            isbnTextBox.Text = selectedISBN;
            BookDAO bookDAO = new BookDAO();
            isbnTextBox.Text = bookController.FillTable(selectedISBN)[7] ;
            bookNameTextBox.Text = bookController.FillTable(selectedISBN)[0];
            authorTextBox.Text = bookController.FillTable(selectedISBN)[1];
            categoryTextBox.Text = bookController.FillTable(selectedISBN)[2];
            languageTextBox.Text = bookController.FillTable(selectedISBN)[3];
            publisherTextBox.Text = bookController.FillTable(selectedISBN)[4];
            pagesTextBox.Text = bookController.FillTable(selectedISBN)[5];
            publishYearTextBox.Text = bookController.FillTable(selectedISBN)[6];




        }
        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();

            loginForm.Show();
            
        }

        // this is the function for add button is the add books button in the program
        private void add_Click(object sender, EventArgs e)
        {
            if (int.TryParse(authorTextBox.Text, out int author) &&
         int.TryParse(categoryTextBox.Text, out int category) &&
         int.TryParse(languageTextBox.Text, out int language) &&
         int.TryParse(publishYearTextBox.Text, out int publishYear) &&
         int.TryParse(pagesTextBox.Text, out int pages))
            {
                string isbn = isbnTextBox.Text;
                string bookName = bookNameTextBox.Text;
                string publisher = publisherTextBox.Text;

                bookController.AddBook(isbn, bookName, author, category, language, publishYear, pages, publisher);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values for certain fields.");
            }

            displayBooks();
            MessageBox.Show("New Book Added Successfully");

        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            String selectedISBN = dataGridView1.SelectedCells[0].Value.ToString();

            if (int.TryParse(authorTextBox.Text, out int author) &&
         int.TryParse(categoryTextBox.Text, out int category) &&
         int.TryParse(languageTextBox.Text, out int language) &&
         int.TryParse(publishYearTextBox.Text, out int publishYear) &&
         int.TryParse(pagesTextBox.Text, out int pages))
            {
                string isbn = isbnTextBox.Text;
                string bookName = bookNameTextBox.Text;
                string publisher = publisherTextBox.Text;

                bookController.UpdateBook(isbn, bookName, author, category, language, publishYear, pages, publisher, selectedISBN);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values for certain fields.");

            }
            displayBooks();
            MessageBox.Show("Book Updated Successfully");

        }

        private void reserveBook_Click(object sender, EventArgs e)
        {
            bookController.ReserveBook();
            ApproveBorrowForms approveBorrowFroms = new ApproveBorrowForms();
            approveBorrowFroms.Show();
        }

        private void manageUserButton_Click(object sender, EventArgs e)
        {
            ManagementForms manageFroms = new ManagementForms();
            manageFroms.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            String selectedISBN = dataGridView1.SelectedCells[0].Value.ToString();
            bookController.RemoveBook(selectedISBN);
            displayBooks();
            MessageBox.Show("Book Deleted Successfully");

        }


    }
}
