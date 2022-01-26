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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox source = e.Source as TextBox;
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)165, (byte)165, (byte)165));
            // Change the TextBox color when it obtains focus.
            source.Background = brush;

            if (source != null && (source.Text == "Password" || source.Text == "Username"))
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
        private void TextBox_LostKeyboardFocusPassword(object sender, KeyboardFocusChangedEventArgs e)
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

        public class User{
            public string Username;
            public string Password;

            public User(string username, string password)
            {
                this.Username = username;
                this.Password = password;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User[] balls = { new User("User1", "password1"), new User("User2", "password2") };
            for (int i = 0; i < balls.Length; i++)
            {
                if (UsernameTextBox.Text == balls[i].Username && PasswordTextBox.Text == balls[i].Password)
                {

                }
            }
        }
    }
}
