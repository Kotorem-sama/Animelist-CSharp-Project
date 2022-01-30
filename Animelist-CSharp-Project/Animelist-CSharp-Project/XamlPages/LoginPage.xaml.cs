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
using Animelist_CSharp_Project;

namespace Animelist_CSharp_Project
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void GotKeyFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            UniversalMethods.TextBox_GotKeyboardFocus(sender, e);
        }
        private void LostKeyFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            UniversalMethods.TextBox_LostKeyboardFocus(sender, e);
        }
        private void ShowPasswordButtonEvent(object sender, RoutedEventArgs e)
        {
            var converter = new ImageSourceConverter();
            string[] path = ShowPasswordImage.Source.ToString().Split('/');
            if (path[path.Length - 1] == "HidePassword.png")
            {
                ShowPasswordImage.Source = (ImageSource)converter.ConvertFromString("../../Images/ShowPassword.png");
                PasswordTextBox.Password = PasswordTextBoxShow.Text;
                PasswordTextBoxShow.Visibility = Visibility.Hidden;
                PasswordTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                ShowPasswordImage.Source = (ImageSource)converter.ConvertFromString("../../Images/HidePassword.png");
                PasswordTextBoxShow.Text = PasswordTextBox.Password;
                PasswordTextBoxShow.Visibility = Visibility.Visible;
                PasswordTextBox.Visibility = Visibility.Hidden;
            }
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage());
        }
        private void PasswordEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }
        public void UnShowPassword()
        {
            var converter = new ImageSourceConverter();
            string[] path = ShowPasswordImage.Source.ToString().Split('/');
            if (path[path.Length - 1] == "HidePassword.png")
            {
                ShowPasswordImage.Source = (ImageSource)converter.ConvertFromString("../../Images/ShowPassword.png");
                PasswordTextBox.Password = PasswordTextBoxShow.Text;
                PasswordTextBoxShow.Visibility = Visibility.Hidden;
                PasswordTextBox.Visibility = Visibility.Visible;
            }
        }
        private Json.User FindUser(Json.Users Userslist)
        {
            for (int i = 0; i < Userslist.UsersList.Count(); i++)
            {
                if ((UsernameTextBox.Text.ToLower() == Userslist.UsersList[i].Username.ToLower() || UsernameTextBox.Text.ToLower() == Userslist.UsersList[i].Email.ToLower()) && PasswordTextBox.Password == Userslist.UsersList[i].Password)
                {
                    Json.SetLoggedIn(Userslist.UsersList[i]);
                    return Userslist.UsersList[i];
                }
                else if (UsernameTextBox.Text.ToLower() == Userslist.UsersList[i].Username.ToLower() || UsernameTextBox.Text.ToLower() == Userslist.UsersList[i].Email.ToLower())
                {
                    return new Json.User("Username");
                }
            }
            return new Json.User();
        }
        private void PrepareForFailure()
        {
            wrongData.Opacity = 0;
            NoAccountMatch.Opacity = 0;
            Keyboard.ClearFocus();
            UnShowPassword();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            PrepareForFailure();
            Json.User foundUser = FindUser(Json.GetUsersList());
            if (foundUser.Username == "Username") { wrongData.Opacity = 1; }
            else if (foundUser.Username == null) { NoAccountMatch.Opacity = 1; }
            else { NavigationService.Navigate(new Homepage()); }
            PasswordTextBox.Password = "Password";
        }
    }
}