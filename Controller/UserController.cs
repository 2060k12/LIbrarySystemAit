using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UserController
    {
        UserLogic userLogic = new UserLogic();


        public bool CheckLogin(string username, string password)
        {
            return userLogic.CheckLogin(username, password);
        }

        public void ReserveBooks(string selectedISBN, string username)
        {
            // Get the current date without time in the desired format
            DateTime currentDate = DateTime.Today;
            string reservedDate = currentDate.ToString("MM-dd-yyyy");

            userLogic.ReserveBooks(selectedISBN, username, reservedDate);
        }

        public void ManageUsers()
        {
            // Implement logic to manage users in the data model
            userLogic.ManageUsers();

        }


    }
}