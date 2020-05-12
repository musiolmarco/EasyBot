using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

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

            TextBox_Loops.Text = MainWindow.loops.ToString();

            TextBox_Delay.Text = MainWindow.delay.ToString();

            Button_Close.Click += (s, e) => Close();

            Button_Minimize.Click += (s, e) => WindowState = WindowState.Minimized;

        }

        private void TextBox_Numbers_Only(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MainWindow.loops = Convert.ToInt32(TextBox_Loops.Text);
            }
            catch
            {
                MainWindow.loops = 0;
            }


            try { 
            MainWindow.delay = Convert.ToInt32(TextBox_Delay.Text);

            }
            catch
            {
                MainWindow.delay = 0;
            }

            this.Close();
        }

    }
}
