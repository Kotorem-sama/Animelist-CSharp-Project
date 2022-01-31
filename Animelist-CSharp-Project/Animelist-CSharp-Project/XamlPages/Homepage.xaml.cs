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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animelist_CSharp_Project
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Page
    {
        public Homepage()
        {
            InitializeComponent();
            //if (username.Length <= 15)
            //{
            //    //LoggedInUsername.Width = username.Length * 11;
            //}
            //else
            //{
            //    LoggedInUsername.Width = 150;
            //}
            //LoggedInUsername.Content = username;
        }
        public static void SetUsernameButton()
        {
            string username = Json.GetUser().Username;
            List<char> seven = new List<char>() { 'i', 'I', 'j', 'l' };
            List<char> nine = new List<char>() { 'b', 'f', 't', 'v', 'x', 'z' };
            List<char> ten = new List<char>() { 'a', 'c', 'e', 'g', 'n', 'o', 'r', 's', 'y' };
            List<char> eleven = new List<char>() { 'd', 'F', 'h', 'k', 'p', 'q', 'u' };
            List<char> twelve = new List<char>() { 'A', 'B', 'C', 'E', 'G', 'J', 'K', 'L', 'S', 'T', 'V', 'w', 'X', 'Y' };
            List<char> thirteen = new List<char>() { 'D', 'H', 'N', 'O', 'P', 'Q', 'R', 'U' };
            List<char> fourteen = new List<char>() { 'm', 'M' };
            List<char> fifteen = new List<char>() { 'W' };

            int length = 0;
            char[] usr = username.Split("");
            for (int a = 0; length < 150; a++)
            {
                if (usr[a] in seven) { }
            }
        }
        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            Json.SetLoggedIn(new Json.User());
            NavigationService.Navigate(new LoginPage());
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfilePage());
        }
    }
}