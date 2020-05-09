using EasyBot.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaktionslogik für MouseBotActionSettings.xaml
    /// </summary>
    public partial class MouseBotActionSettings : Window
    {
        public MouseBotActionSettings(MouseBotAction mouseBotAction)
        {
            InitializeComponent();

            Label_X_Value.Content = mouseBotAction.X;

            Label_Y_Value.Content = mouseBotAction.Y;

            if (mouseBotAction.Left_Click)
            {
                RadioButton_Leftclick.IsChecked = true;
            }
            else
            {
                RadioButton_Rightclick.IsChecked = true;
            }

            TextBox_Delay.Text = mouseBotAction.Delay.ToString();

        }

        private void TextBox_Delay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
