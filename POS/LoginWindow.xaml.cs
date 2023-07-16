using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POS
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginWindowVM();
            new LoginWindowVM().CloseAction= () => Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var username = txtUser.Text;
            var password = txtPass.Password;

            using (UserDataContext context = new UserDataContext())
            {
                bool isAdminFound = context.Users.Any(admin => admin.Username == username && admin.Password == password && admin.IsAdmin == true);
                bool isUserFound = context.Users.Any(user => user.Username == username && user.Password == password && user.IsAdmin == false);

                if (isAdminFound)
                {
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                    Close();
                }
                else if (isUserFound)
                {
                    MessageBox.Show("User window", "Invalid", MessageBoxButton.OK, MessageBoxImage.Warning);
                    //UserWindow userWindow = new UserWindow();
                    //userWindow.Show();
                    //Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Invalid", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();            
        }
    }
}
