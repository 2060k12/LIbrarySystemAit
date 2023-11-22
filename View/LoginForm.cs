using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username, password;
            username = userNameTextBox.Text;
            password = passwordTextBox.Text;
            
            UserController userController = new UserController();
            userController.CheckLogin(username, password);
            if(userController.CheckLogin(username, password) && username == "admin")
            {
                AdminForms adminForms = new AdminForms();
                adminForms.Show();  
                this.Hide();
            } 
            else if(userController.CheckLogin(username, password) && username != "admin")
            {
                UserForms userForms = new UserForms();
                userForms.Show();
                this.Hide();
            }
            else {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show("Invalid Username/Password\nTry Again", "Error", MessageBoxButtons.OK, icon);
                
            }
           
            

        }
    }
}
