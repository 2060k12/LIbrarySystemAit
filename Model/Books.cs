using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Books
    {
        String isbn;
        String bookName;
        String Author ;
        int Category;
        int language;
        int publishYear;
        int pages;
        String publisher;

        public string Isbn { get => isbn; set => isbn = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Author1 { get => Author; set => Author = value; }
        public int Category1 { get => Category; set => Category = value; }
        public int Language { get => language; set => language = value; }
        public int PublishYear { get => publishYear; set => publishYear = value; }
        public int Pages { get => pages; set => pages = value; }
        public string Publisher { get => publisher; set => publisher = value; }
    }
}
