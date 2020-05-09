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
    /// Interaktionslogik für SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();

            TextBox_Loops.Text = MainWindow.Loops.ToString();

            TextBox_Delay.Text = MainWindow.Delay.ToString();

        }

        private void TextBox_Numbers_Only(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Loops = Convert.ToInt32(TextBox_Loops.Text);
            MainWindow.Delay = Convert.ToInt32(TextBox_Delay.Text);

            this.Close();
        }

    }
}
