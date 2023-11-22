using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class BookController

    {
        BookLogic bookLogic = new BookLogic();

        public List<Books> GetallBooks()
        {
            bookLogic.GetAllBooks();
            List < Books> books = bookLogic.GetAllBooks();
            return books;
        }

        public List<Books> BookSearch(string sFilter, string searchText)
        {
            
                string BookNameSearchText = searchText;
                List<Books> books = bookLogic.BookSeach(sFilter, searchText);
                return books;
           
        }

        public List<BorrowBooks> GetBorrowedBooks()
        {
            return bookLogic.GetBorrowedBooks();
        }

        public void ReturnBook(string selectedIsbn)
        {
            DateTime todaysdate = DateTime.Today;
            String actualReturnDate = todaysdate.ToString("MM-dd-yyyy");
            bookLogic.ReturnBook(actualReturnDate, selectedIsbn);


        }
        public string[] FillTable(string selectedISBN)
        {
            return bookLogic.FillTable(selectedISBN);
        }
        public void AddBook(string isbn, string bookName, int author, int category, int language, int publishYear,  int Pages, string publisher)
        {

            

            bookLogic.AddBook(isbn, bookName, author, category, language, publishYear, Pages, publisher);
        }

        public void UpdateBook(string isbn, string bookName, int author, int category, int language, int publishYear, int Pages, string publisher, String selectedISBN)
        {
            // Implement logic to update a book in the data model
            bookLogic.UpdateBook(isbn, bookName, author, category, language, publishYear, Pages, publisher, selectedISBN);

        }

        public void ReserveBook()
        {
            // Implement logic to reserve a book in the data model
            bookLogic.ReserveBook();

        }

        

        public void RemoveBook(string selectedISBN)
        {
            // Implement logic to remove a book from the data model
            bookLogic.RemoveBook(selectedISBN);

        }

        public List<ReservedBooks> DisplayReserves()
        {
            BookDAO bookDAO = new BookDAO();    

            return bookLogic.DisplayReserves();
        }

        public void AcceptBorrowReq(string UID, string isbn, string reservedDate)
        {
            bookLogic.AcceptBorrowReq( UID, isbn, reservedDate);
            
        }

    }
}
