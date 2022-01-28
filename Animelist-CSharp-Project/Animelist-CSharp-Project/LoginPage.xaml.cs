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
        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)165, (byte)165, (byte)165));
            if (e.Source.GetType() == typeof(TextBox))
            {
                TextBox source = e.Source as TextBox;
                source.Background = brush;

                if (source != null && (source.Text == "Password" || source.Text == "Username" || source.Text == "Email"))
                {
                    source.Clear();
                }
            }
            else if (e.Source.GetType() == typeof(PasswordBox))
            {
                PasswordBox source = e.Source as PasswordBox;
                source.Background = brush;

                if (source != null && (source.Password == "Password" || source.Password == "Username"))
                {
                    source.Clear();
                }
            }
        }
        private void TextBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)201, (byte)201, (byte)201));

            if (e.Source.GetType() == typeof(TextBox))
            {
                TextBox source = e.Source as TextBox;
                source.Background = brush;
                source.Text = source.Text.Trim();
                if (source.Text == "")
                {
                    if (source.Name == "UsernameTextBox")
                    {
                        source.Text = "Username";
                    }
                    else if (source.Name == "PasswordTextBoxShow")
                    {
                        source.Text = "Password";
                    }
                }
            }
            else if (e.Source.GetType() == typeof(PasswordBox))
            {
                PasswordBox source = e.Source as PasswordBox;
                source.Background = brush;
                source.Password = source.Password.Trim();
                if (source.Password == "" && (source.Name == "PasswordTextBox" || source.Name == "ConfirmPasswordTextBox"))
                {
                    source.Password = "Password";
                }
            }
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean matchFound = false;
            Json.Users balls = Json.GetUsersList();
            for (int i = 0; i < balls.UsersList.Count() && matchFound == false; i++)
            {
                if ((UsernameTextBox.Text.ToLower() == balls.UsersList[i].Username.ToLower() || UsernameTextBox.Text.ToLower() == balls.UsersList[i].Email.ToLower()) && (PasswordTextBox.Password == balls.UsersList[i].Password || PasswordTextBoxShow.Text == balls.UsersList[i].Password))
                {
                    NavigationService.Navigate(new Homepage());
                }
            }
            if (matchFound == false) { wrongData.Opacity = 1; }
            PasswordTextBox.Password = "Password";
            PasswordTextBoxShow.Text = "Password";
        }
        private void ShowPasswordButtonEvent(object sender, RoutedEventArgs e)
        {
            var converter = new ImageSourceConverter();
            string[] path = ShowPasswordImage.Source.ToString().Split('/');
            if (path[path.Length - 1] == "HidePassword.png")
            {
                ShowPasswordImage.Source = (ImageSource)converter.ConvertFromString("../../img/ShowPassword.png");
                PasswordTextBox.Password = PasswordTextBoxShow.Text;
                PasswordTextBoxShow.Visibility = Visibility.Hidden;
                PasswordTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                ShowPasswordImage.Source = (ImageSource)converter.ConvertFromString("../../img/HidePassword.png");
                PasswordTextBoxShow.Text = PasswordTextBox.Password;
                PasswordTextBoxShow.Visibility = Visibility.Visible;
                PasswordTextBox.Visibility = Visibility.Hidden;
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage());
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                GoBackPageButton_Click(sender, e);
                LoginButton_Click(sender, e);
            }
        }

        public void GoBackPageButton_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            for (a = 0; NavigationService.CanGoBack; a++)
            {
                NavigationService.GoBack();
            }
        }
    }
}