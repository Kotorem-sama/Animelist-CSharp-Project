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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        public void GoBackPageButton_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            for (a = 0; NavigationService.CanGoBack; a++)
            {
                NavigationService.GoBack();
            }
            Console.WriteLine(a);
        }
        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }
        private void ShowConfirmPasswordButtonEvent(object sender, RoutedEventArgs e)
        {
            var BackgroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)201, (byte)201, (byte)201));
            var ForegroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)105, (byte)105, (byte)105));

            ConfirmPasswordTextBox.Background = BackgroundBrush;
            ConfirmPasswordTextBox.Foreground = ForegroundBrush;
            ConfirmPasswordTextBoxShow.Background = BackgroundBrush;
            ConfirmPasswordTextBoxShow.Foreground = ForegroundBrush;

            var converter = new ImageSourceConverter();
            string[] path = ShowConfirmPasswordImage.Source.ToString().Split('/');
            if (path[path.Length - 1] == "HidePassword.png")
            {
                ShowConfirmPasswordImage.Source = (ImageSource)converter.ConvertFromString("../../Images/ShowPassword.png");
                ConfirmPasswordTextBox.Password = ConfirmPasswordTextBoxShow.Text;
                ConfirmPasswordTextBoxShow.Visibility = Visibility.Hidden;
                ConfirmPasswordTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                ShowConfirmPasswordImage.Source = (ImageSource)converter.ConvertFromString("../../Images/HidePassword.png");
                ConfirmPasswordTextBoxShow.Text = ConfirmPasswordTextBox.Password;
                ConfirmPasswordTextBoxShow.Visibility = Visibility.Visible;
                ConfirmPasswordTextBox.Visibility = Visibility.Hidden;
            }
        }
        private void ShowPasswordButtonEvent(object sender, RoutedEventArgs e)
        {
            var BackgroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)201, (byte)201, (byte)201));
            var ForegroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)105, (byte)105, (byte)105));

            PasswordTextBox.Background = BackgroundBrush;
            PasswordTextBox.Foreground = ForegroundBrush;
            PasswordTextBoxShow.Background = BackgroundBrush;
            PasswordTextBoxShow.Foreground = ForegroundBrush;

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
        private void GotKeyFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            UniversalMethods.TextBox_GotKeyboardFocus(sender, e);
        }
        private void LostKeyFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            UniversalMethods.TextBox_LostKeyboardFocus(sender, e);
        }
        private Boolean CheckAlreadyUsed(string name, string email)
        {
            Json.Users users = Json.GetUsersList();
            Boolean MatchFound = false;
            var BackgroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)255, (byte)182, (byte)0));
            var ForegroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)159, (byte)88, (byte)0));

            for (int i = 0; i < users.UsersList.Count(); i++)
            {
                if (EmailTextBox.Text.ToLower() == users.UsersList[i].Email.ToLower())
                {
                    MatchFound = true;
                    EmailTextBox.Background = BackgroundBrush;
                    EmailTextBox.Foreground = ForegroundBrush;
                }
                if (UsernameTextBox.Text.ToLower() == users.UsersList[i].Username.ToLower())
                {
                    MatchFound = true;
                    UsernameTextBox.Background = BackgroundBrush;
                    UsernameTextBox.Foreground = ForegroundBrush;
                }
            }
            if (MatchFound)
            {
                AlreadyInUse.Visibility = Visibility.Visible;
                return false;
            }
            return true;
        }
        private string[] GetPasswords()
        {
            string[] password = new string[2];

            password[0] = PasswordTextBox.Password;
            password[1] = ConfirmPasswordTextBox.Password;

            return password;
        }
        public void HideErrorMessages()
        {
            PasswordsNoMatch.Visibility = Visibility.Hidden;
            AlreadyInUse.Visibility = Visibility.Hidden;
            EmptyError.Visibility = Visibility.Hidden;
            Successfull.Visibility = Visibility.Hidden;
        }
        public void ReturnToNormal()
        {
            var BackgroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)201, (byte)201, (byte)201));
            var ForegroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)105, (byte)105, (byte)105));

            EmailTextBox.Background = BackgroundBrush;
            EmailTextBox.Foreground = ForegroundBrush;
            UsernameTextBox.Background = BackgroundBrush;
            UsernameTextBox.Foreground = ForegroundBrush;
            PasswordTextBox.Background = BackgroundBrush;
            PasswordTextBox.Foreground = ForegroundBrush;
            ConfirmPasswordTextBox.Background = BackgroundBrush;
            ConfirmPasswordTextBox.Foreground = ForegroundBrush;
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
            
            path = ShowConfirmPasswordImage.Source.ToString().Split('/');
            if (path[path.Length - 1] == "HidePassword.png")
            {
                ShowConfirmPasswordImage.Source = (ImageSource)converter.ConvertFromString("../../Images/ShowPassword.png");
                ConfirmPasswordTextBox.Password = ConfirmPasswordTextBoxShow.Text;
                ConfirmPasswordTextBoxShow.Visibility = Visibility.Hidden;
                ConfirmPasswordTextBox.Visibility = Visibility.Visible;
            }
        }
        public Boolean IsEmpty()
        {
            var BackgroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)255, (byte)89, (byte)94));
            var ForegroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)159, (byte)0, (byte)0));

            if (EmailTextBox.Text == "Email")
            {
                EmailTextBox.Background = BackgroundBrush;
                EmailTextBox.Foreground = ForegroundBrush;
            }
            if (UsernameTextBox.Text == "Username")
            {
                UsernameTextBox.Background = BackgroundBrush;
                UsernameTextBox.Foreground = ForegroundBrush;
            }
            if (PasswordTextBox.Password == "Password")
            {
                PasswordTextBox.Background = BackgroundBrush;
                PasswordTextBox.Foreground = ForegroundBrush;
            }
            if (ConfirmPasswordTextBox.Password == "Password")
            {
                ConfirmPasswordTextBox.Background = BackgroundBrush;
                ConfirmPasswordTextBox.Foreground = ForegroundBrush;
            }
            if (ConfirmPasswordTextBox.Password != "Password" && PasswordTextBox.Password != "Password" && UsernameTextBox.Text != "Username" && EmailTextBox.Text != "Email")
            {
                return true;
            }
            EmptyError.Visibility = Visibility.Visible;
            return false;
        }
        public Boolean PasswordsMatch(string[] passwords)
        {
            var BackgroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)255, (byte)89, (byte)94));
            var ForegroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)159, (byte)0, (byte)0));

            if (passwords[0] != passwords[1])
            {
                PasswordsNoMatch.Visibility = Visibility.Visible;
                PasswordTextBox.Background = BackgroundBrush;
                PasswordTextBox.Foreground = ForegroundBrush;
                ConfirmPasswordTextBox.Background = BackgroundBrush;
                ConfirmPasswordTextBox.Foreground = ForegroundBrush;
                return false;
            }
            return true;
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            UnShowPassword();
            HideErrorMessages();
            ReturnToNormal();
            if (IsEmpty())
            {
                if (CheckAlreadyUsed(UsernameTextBox.Text, EmailTextBox.Text))
                {
                    string[] passwords = GetPasswords();
                    if (PasswordsMatch(passwords))
                    {
                        Successfull.Visibility = Visibility.Visible;
                        Json.AddUserToJson(UsernameTextBox.Text, EmailTextBox.Text, passwords[0]);
                    }
                }
            }
        }
    }
}
