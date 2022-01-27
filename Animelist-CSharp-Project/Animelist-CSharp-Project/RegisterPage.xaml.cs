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

        private void ShowPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
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
            TextBox source = e.Source as TextBox;
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)165, (byte)165, (byte)165));
            // Change the TextBox color when it obtains focus.
            source.Background = brush;

            if (source != null && (source.Text == "Password" || source.Text == "Username" || source.Text == "Email"))
            {
                // Clear the TextBox.
                source.Clear();
            }
        }
        private void PasswordBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            PasswordBox source = e.Source as PasswordBox;
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)165, (byte)165, (byte)165));
            // Change the TextBox color when it obtains focus.
            source.Background = brush;

            if (source != null && (source.Password == "Password" || source.Password == "Username"))
            {
                // Clear the TextBox.
                source.Clear();
            }
        }
        private void TextBox_LostKeyboardFocusUsername(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox source = e.Source as TextBox;
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)201, (byte)201, (byte)201));
            source.Background = brush;
            source.Text = source.Text.Trim();

            if (source.Text == "")
            {
                source.Text = "Username";
            }
        }
        private void TextBox_LostKeyboardFocusEmail(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox source = e.Source as TextBox;
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)201, (byte)201, (byte)201));
            source.Background = brush;
            source.Text = source.Text.Trim();

            if (source.Text == "")
            {
                source.Text = "Email";
            }
        }
        private void TextBox_LostKeyboardFocusPassword(object sender, KeyboardFocusChangedEventArgs e)
        {
            PasswordBox source = e.Source as PasswordBox;
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)201, (byte)201, (byte)201));
            source.Background = brush;
            source.Password = source.Password.Trim();

            if (source.Password == "")
            {
                source.Password = "Password";
            }
        }
        private void TextBox_LostKeyboardFocusShowPassword(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox source = e.Source as TextBox;
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)201, (byte)201, (byte)201));
            source.Background = brush;
            source.Text = source.Text.Trim();

            if (source.Text == "")
            {
                source.Text = "Password";
            }
        }
    }
}
