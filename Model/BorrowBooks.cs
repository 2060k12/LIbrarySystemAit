using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BorrowBooks
    {
        int UID;
        string ISBN;
        string BorrowDate;
        string ReturnDate;
        string ActuaReturnDate;
        string latefee;

        public int UID1 { get => UID; set => UID = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string BorrowDate1 { get => BorrowDate; set => BorrowDate = value; }
        public string ReturnDate1 { get => ReturnDate; set => ReturnDate = value; }
        public string ActuaReturnDate1 { get => ActuaReturnDate; set => ActuaReturnDate = value; }
        public string Latefee { get => latefee; set => latefee = value; }
    }
}
