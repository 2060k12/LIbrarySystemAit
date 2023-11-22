using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookLogic
    {
        BookDAO bookDAO = new BookDAO();

        public List<Books> GetAllBooks() { 
            List<Books> books = bookDAO.GetAllBooks();
            return books;
        }
        public List<Books> BookSeach(string sFilter, string searchText) {
            List<Books> books = bookDAO.BookSearch(sFilter, searchText);
            return books;
           
            
        }


        public List<BorrowBooks> GetBorrowedBooks()
        {
            return bookDAO.GetBorrowedBooks();
        }

        public void ReturnBook(string actualReturnDate, string selectedIsbn)
        {
            bookDAO.ReturnBook(actualReturnDate, selectedIsbn);
        }

        public string[] FillTable(string selectedISBN)
        {
            return bookDAO.FillTable(selectedISBN);


        }

        public void AddBook(string isbn, string bookName, int author, int category, int language, int publishYear, int Pages, string publisher)
        {
            bookDAO.AddBook(isbn, bookName, author, category, language, publishYear, Pages, publisher);

        }

        public void UpdateBook(string isbn, string bookName, int author, int category, int language, int publishYear, int Pages, string publisher, String selectedISBN)
        {
            // Implement logic to update a book in the data model
            bookDAO.UpdateBook(isbn, bookName, author, category, language, publishYear, Pages, publisher, selectedISBN);
        }

        public void ReserveBook()
        {
            // Implement logic to reserve a book in the data model
            bookDAO.ReserveBook();
        }

       

        public void RemoveBook(string selectedISBN)
        {
            // Implement logic to remove a book from the data model
            bookDAO.RemoveBook(selectedISBN);
        }

        public List<ReservedBooks> DisplayReserves()
        {
            return bookDAO.DisplayReserves();

        }
        public void AcceptBorrowReq( string UID, string isbn, string reservedDate)
        {

            // Calculate the ReturnDate as 10 days after today
            DateTime reservedDateTime = DateTime.Parse(reservedDate);
            DateTime returnDateTime = DateTime.Today.AddDays(10);
            string returnDate = returnDateTime.ToString("MM-dd-yyyy");
            string actualDate = "01-01-2000";
            int lateFee = 0;

            bookDAO.AcceptBorrowReq(UID, isbn, reservedDate, returnDate, actualDate, lateFee);



        }


    }
}
