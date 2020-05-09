using EasyBot.Classes;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace EasyBot.Views
{
    /// <summary>
    /// Interaktionslogik für CreateKeyboardActionWindow.xaml
    /// </summary>
    public partial class CreateKeyboardActionWindow : Window
    {
        public CreateKeyboardActionWindow()
        {
            InitializeComponent();

            Button_Close.Click += (s, e) => Close();

            Button_Minimize.Click += (s, e) => WindowState = WindowState.Minimized;

        }

        private void TextBox_Delay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            string Text = TextBox_Text.Text;

            int Delay;

            if(TextBox_Delay.Text != "") {
                Delay = Convert.ToInt32(TextBox_Delay.Text);
            }
            else
            {
                Delay = 0;
            }

            KeyBoardBotAction keyBoardBotAction = new KeyBoardBotAction(Text, Delay);

            MainWindow.AddBotAction(keyBoardBotAction);

            MainWindow.RefreshListBox();

            this.Close();
        }
    }
}
