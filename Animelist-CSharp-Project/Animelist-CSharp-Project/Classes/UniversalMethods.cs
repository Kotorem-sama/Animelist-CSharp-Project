using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Animelist_CSharp_Project
{
    class UniversalMethods
    {
        public static void TextBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var BackgroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)201, (byte)201, (byte)201));
            var ForegroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)105, (byte)105, (byte)105));

            if (e.Source.GetType() == typeof(TextBox))
            {
                TextBox source = e.Source as TextBox;

                source.Background = BackgroundBrush;
                source.Foreground = ForegroundBrush;
                source.Text = source.Text.Trim();

                if (source.Name == "UsernameTextBox" && source.Text == "") { source.Text = "Username"; }
                else if (source.Name == "EmailTextBox" && source.Text == "") { source.Text = "Email"; }
                else if (source.Name == "PasswordTextBoxShow" && source.Text == "") { source.Text = "Password"; }
                else if (source.Name == "ConfirmPasswordTextBoxShow" && source.Text == "") { source.Text = "Password"; }
            }
            else if (e.Source.GetType() == typeof(PasswordBox))
            {
                PasswordBox source = e.Source as PasswordBox;

                source.Background = BackgroundBrush;
                source.Foreground = ForegroundBrush;
                source.Password = source.Password.Trim();

                if (source.Password == "" && (source.Name == "PasswordTextBox" || source.Name == "ConfirmPasswordTextBox"))
                {
                    source.Password = "Password";
                }
            }
        }
        public static void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var BackgroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)165, (byte)165, (byte)165));
            var ForegroundBrush = new SolidColorBrush(Color.FromArgb(255, (byte)69, (byte)69, (byte)69));

            if (e.Source.GetType() == typeof(TextBox))
            {
                TextBox source = e.Source as TextBox;

                source.Background = BackgroundBrush;
                source.Foreground = ForegroundBrush;

                if (source != null && (source.Text == "Password" || source.Text == "Username" || source.Text == "Email"))
                {
                    source.Clear();
                }
            }
            else if (e.Source.GetType() == typeof(PasswordBox))
            {
                PasswordBox source = e.Source as PasswordBox;
                source.Background = BackgroundBrush;
                source.Foreground = ForegroundBrush;

                if (source != null && (source.Password == "Password" || source.Password == "Username"))
                {
                    source.Clear();
                }
            }
        }
    }
}
