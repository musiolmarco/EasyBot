using EasyBot.Classes;
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
using System.Windows.Shapes;

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

        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {

            string Text = TextBox_Text.Text;
            int Delay = Convert.ToInt32(TextBox_Delay.Text);

            KeyBoardBotAction keyBoardBotAction = new KeyBoardBotAction(Text, Delay);

            MainWindow.ChangeBotAction(keyBoardBotAction);

            this.Close();

        }
    }
}
