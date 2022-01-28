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
            var converter = new ImageSourceConverter();
            string[] path = ShowConfirmPasswordImage.Source.ToString().Split('/');
            if (path[path.Length - 1] == "HidePassword.png")
            {
                ShowConfirmPasswordImage.Source = (ImageSource)converter.ConvertFromString("../../img/ShowPassword.png");
                ConfirmPasswordTextBox.Password = ConfirmPasswordTextBoxShow.Text;
                ConfirmPasswordTextBoxShow.Visibility = Visibility.Hidden;
                ConfirmPasswordTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                ShowConfirmPasswordImage.Source = (ImageSource)converter.ConvertFromString("../../img/HidePassword.png");
                ConfirmPasswordTextBoxShow.Text = ConfirmPasswordTextBox.Password;
                ConfirmPasswordTextBoxShow.Visibility = Visibility.Visible;
                ConfirmPasswordTextBox.Visibility = Visibility.Hidden;
            }
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
                    else if (source.Name == "EmailTextBox")
                    {
                        source.Text = "Email";
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

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
