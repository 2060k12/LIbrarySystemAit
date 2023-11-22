using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Model.BorrowBookDataSetTableAdapters;
using Model.DataSetBooksTableAdapters;
using Model.DataSetReserveDaoTableAdapters;
using static Model.DataSetBooks;


namespace Model
{
    public class BookDAO
    {
        string[] bookInfo = new string[8];

        TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();
        TabBorrowTableAdapter tabBorrowTableAdapter = new TabBorrowTableAdapter();
        TabReservedTableAdapter tabReservedTableAdapter = new TabReservedTableAdapter();

        public List<Books> GetAllBooks()
        {
            // connect to the database
            DataSetBooks.TabBookDataTable tabBookDataTable = tabBookTableAdapter.GetAllUsers();
            int dataCount = tabBookDataTable.Count;


            // now lets transverse the tabBookDataTable and get all the data one by one 
            // check if any data is returned
            if (dataCount == 0)
            {
                return null; // when there are no data in the tbales

            }
            else
            {
                // create a list of b object
                List<Books> books = new List<Books>();

                // there are data
                foreach (DataRow row in tabBookDataTable)
                {
                    String isbn = (row["ISBN"].ToString());
                    String bookName = (row["BookName"].ToString());
                    String Author = (row["Author"].ToString());
                    int Category = Convert.ToInt32(row["Category"]);
                    int language = Convert.ToInt32(row["Language"]);
                    int publishYear = Convert.ToInt32(row["PublishYear"]);
                    int pages = Convert.ToInt32(row["Pages"]);
                    String publisher = (row["Publisher"].ToString());

                    //encapsulate the above data into User object 

                    Books book = new Books();
                    book.Isbn = isbn;
                    book.BookName = bookName;
                    book.Author1 = bookName;
                    book.Category1 = Category;
                    book.Language = language;
                    book.Publisher = publisher;
                    book.Pages = pages;
                    book.PublishYear = publishYear;

                    // and then add that user object into a list
                    books.Add(book);
                }
                return books;



            }

        }


        public List<Books> BookSearch(string sFilter, string searchText)
        {

            DataSetBooks.TabBookDataTable tabBookDataTable = null;
            int dataCount;
            if (sFilter == "BookName")
            {
                tabBookDataTable = tabBookTableAdapter.BookNameSearch(searchText);
                dataCount = tabBookDataTable.Count;
            }

            else if (sFilter == "PublishYear")
            {
                tabBookDataTable = tabBookTableAdapter.YearSearch(Int32.Parse(searchText));
                dataCount = tabBookDataTable.Count;
            }

            else if (sFilter == "ISBN")
            {
                tabBookDataTable = tabBookTableAdapter.IsbnBookSearch(searchText);
                dataCount = tabBookDataTable.Count;
            }

            else
            {
                dataCount = 0;
            }

            // now lets transverse the tabBookDataTable and get all the data one by one 
            // check if any data is returned

            // create a list of b object
            List<Books> books = new List<Books>();

            // there are data
            foreach (DataRow row in tabBookDataTable)
            {
                String isbn = (row["ISBN"].ToString());
                String bookName = (row["BookName"].ToString());
                String Author = (row["Author"].ToString());
                int Category = Convert.ToInt32(row["Category"]);
                int language = Convert.ToInt32(row["Language"]);
                int publishYear = Convert.ToInt32(row["PublishYear"]);
                int pages = Convert.ToInt32(row["Pages"]);
                String publisher = (row["Publisher"].ToString());

                //encapsulate the above data into User object 

                Books book = new Books();
                book.Isbn = isbn;
                book.BookName = bookName;
                book.Author1 = bookName;
                book.Category1 = Category;
                book.Language = language;
                book.Publisher = publisher;
                book.Pages = pages;
                book.PublishYear = publishYear;

                // and then add that user object into a list
                books.Add(book);

            }
            return books;




        }

        public List<BorrowBooks> GetBorrowedBooks()
        {
            BorrowBookDataSet.TabBorrowDataTable tabBorrowDataTable = tabBorrowTableAdapter.DisplayAllBorrowedBooks();
            int dataCount = tabBorrowDataTable.Count;


            // now lets transverse the tabBookDataTable and get all the data one by one 
            // check if any data is returned
            if (dataCount == 0)
            {
                return null; // when there are no data in the tbales

            }
            else
            {
                // create a list of b object
                List<BorrowBooks> books = new List<BorrowBooks>();

                // there are data
                foreach (DataRow row in tabBorrowDataTable)
                {
                    int UID = Convert.ToInt32(row["UID"]);
                    string ISBN = row["ISBN"].ToString();
                    string BorrowDate = row["BorrowDate"].ToString();
                    string ReturnDate = row["ReturnDate"].ToString();
                    string ActualReturnDate = row["ActualReturnDate"].ToString();
                    string LateFee = row["LateFee"].ToString();


                    //encapsulate the above data into User object 

                    BorrowBooks book = new BorrowBooks();
                    book.UID1 = UID;
                    book.ISBN1 = ISBN;
                    book.BorrowDate1 = BorrowDate;
                    book.ReturnDate1 = ReturnDate;
                    book.ActuaReturnDate1 = ActualReturnDate;
                    book.Latefee = LateFee;


                    // and then add that user object into a list
                    books.Add(book);
                }
                return books;



            }

        }


        public void ReturnBook(string actualReturnDate, string selectedIsbn)
        {
            tabBorrowTableAdapter.UpdateTable(actualReturnDate, selectedIsbn);

        }

        public string[] FillTable(string selectedISBN)
        {
            

            TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();
            tabBookTableAdapter.FillTable(selectedISBN);

            DataSetBooks.TabBookDataTable tabBookDataTable = tabBookTableAdapter.FillTable(selectedISBN);
            int dataCount = tabBookDataTable.Count;


            foreach (DataRow row in tabBookDataTable)
            {
                bookInfo[0] = (row["BookName"].ToString());
                bookInfo[1] = (row["Author"].ToString());
                bookInfo[2] = (row["Category"].ToString());
                bookInfo[3] = (row["Language"].ToString());
                bookInfo[4] = (row["PublishYear"].ToString());
                bookInfo[5] = (row["Pages"].ToString());
                bookInfo[6] = (row["Publisher"].ToString());
                bookInfo[7] = (row["ISBN"].ToString());
            }
            return bookInfo;
             
        }

        public void AddBook(string isbn, string bookName, int author, int category, int language, int publishYear, int Pages, string publisher)
        {
            TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();
            tabBookTableAdapter.AddBook(isbn, bookName, author, category, language, publishYear, Pages, publisher );
        }

        public void UpdateBook(string isbn, string bookName, int author, int category, int language, int publishYear, int Pages, string publisher, String selectedISBN)
        {
            TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();
            tabBookTableAdapter.UpdateBooks(isbn, bookName, author, category, language, publishYear, Pages, publisher,  selectedISBN) ;
        }
        public void ReserveBook()
        {

        }
        

        public void RemoveBook(string selectedISBN)
        {
            TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();
            tabBookTableAdapter.DeleteBooks(selectedISBN) ;
        }

        public List<ReservedBooks> DisplayReserves()
        {


            DataSetReserveDao.TabReservedDataTable tabReservedDataTable = tabReservedTableAdapter.DisplayReserves();
            int dataCount = tabReservedDataTable.Count;


            // now lets transverse the tabBookDataTable and get all the data one by one 
            // check if any data is returned
            if (dataCount == 0)
            {
                return null; // when there are no data in the tbales

            }
            else
            {
                // create a list of b object
                List<ReservedBooks> reserves = new List<ReservedBooks>();

                // there are data
                foreach (DataRow row in tabReservedDataTable)
                {
                    String uid =(row["UID"]).ToString();
                    String isbn = (row["ISBN"].ToString());
                    String reservedDate = (row["ReservedDate"].ToString());
                   

                    //encapsulate the above data into User object 

                    ReservedBooks reserve = new ReservedBooks();
                    reserve.ISBN1 = isbn;
                    reserve.UID1 = uid;
                    reserve.ReservedDate1 = reservedDate;
                   

                    // and then add that user object into a list
                    reserves.Add(reserve);
                }
                return reserves;



            }

           

        }
        public void AcceptBorrowReq(string UID, string isbn, string reservedDate, string returnDate, string actualDate, int lateFee)
        {


            // add the data to borrow table
            TabBorrowTableAdapter tabBookTableAdapter = new TabBorrowTableAdapter();
            tabBookTableAdapter.AddBook(Int32.Parse(UID), isbn, reservedDate, returnDate, actualDate, lateFee);




             // Remove data from reserve table
             TabReservedTableAdapter tabReservedTableAdapter = new TabReservedTableAdapter();
            tabReservedTableAdapter.DeleteReserves(isbn);



        }

    }
}
