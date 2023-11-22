using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Model.DataSetBooksTableAdapters;
using Model.DataSetReserveDaoTableAdapters;
using Model.DataSetUsersTableAdapters;

using static Model.DataSetBooks;
using static Model.DataSetUsers;

namespace Model
{
    public class UserDAO
    {
        // Connect to the database
        TabUserTableAdapter tabUserTableAdapter = new TabUserTableAdapter();
       
        public bool CheckLogin(string username, string password)
        {
           
            string userCheck =  tabUserTableAdapter.CheckLogin(username, password).ToString();
            //int dataCount = tabUserDataTable.Count;

            if (userCheck == "0")
            {
                return false;
            }

            else
            {
                return true;

            }

        }


        public void ReserveBooks(string selectedISBN, string UID, string reservedDate)
        {

            TabReservedTableAdapter tabReservedTableAdapter = new TabReservedTableAdapter();
            tabReservedTableAdapter.InsertQuery(reservedDate, Int32.Parse(UID), selectedISBN);

        }


        public void ManageUsers()
        {

        }

    }


}