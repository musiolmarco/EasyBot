using EasyBot.Classes;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
namespace EasyBot.Views
{
    /// <summary>
    /// Interaktionslogik für KeyBoardBotActionSettings.xaml
    /// </summary>
    public partial class KeyBoardBotActionSettings : Window
    {
        public KeyBoardBotActionSettings(KeyBoardBotAction keyBoardBotAction)
        {
            InitializeComponent();

            TextBox_Text.Text = keyBoardBotAction.Text;

            TextBox_Delay.Text = keyBoardBotAction.Delay.ToString();

            Button_Close.Click += (s, e) => Close();

            Button_Minimize.Click += (s, e) => WindowState = WindowState.Minimized;

        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {

            string Text = TextBox_Text.Text;

            int Delay;

            try
            {
                Delay = Convert.ToInt32(TextBox_Delay.Text);
            }
            catch
            {
                Delay = 0;
            }

            KeyBoardBotAction keyBoardBotAction = new KeyBoardBotAction(Text, Delay);

            MainWindow.ChangeBotAction(keyBoardBotAction);

            this.Close();

        }

        private void TextBox_Delay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.DeleteBotAction();

            this.Close();
        }
    }
}
