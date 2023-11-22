using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserLogic
    {
        UserDAO userDAO = new UserDAO();

        public bool CheckLogin(string username, string password)
        {
            return userDAO.CheckLogin(username, password);
        }

        public void ReserveBooks(string selectedISBN, string username, string reservedDate)
        {
            userDAO.ReserveBooks(selectedISBN, username, reservedDate);
            
        }

        public void ManageUsers()
        {
            // Implement logic to manage users in the data model
            userDAO.ManageUsers();
        }
    }
}
