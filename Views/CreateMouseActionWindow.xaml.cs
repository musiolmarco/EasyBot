using System;
using System.Windows;
using System.Windows.Input;
using wf = System.Windows.Forms;
using System.Runtime.InteropServices;
using EasyBot.Classes;
using System.Text.RegularExpressions;

namespace EasyBot.Views
{
    /// <summary>
    /// Interaktionslogik für CreateMouseAction.xaml
    /// </summary>
    public partial class CreateMouseActionWindow : Window
    {

        bool setMouseLocation = false;
        

        public CreateMouseActionWindow()
        {
            InitializeComponent();

            Label_X_Value.Content = 0;
            Label_Y_Value.Content = 0;

            Button_Close.Click += (s, e) => Close();

            Button_Minimize.Click += (s, e) => WindowState = WindowState.Minimized;


        }

        private void SetPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(Label_X_Value.Content);
            int y = Convert.ToInt32(Label_Y_Value.Content);
            int delay;
            bool leftClick;

            try
            {
                delay = Convert.ToInt32(TextBox_Delay.Text);
            }
            catch
            {
                delay = 0;
            }

            if ((bool)RadioButton_Leftclick.IsChecked)
            {
                leftClick = true;
            }
            else
            {
                leftClick = false;
            }

            MouseBotAction mouseBotAction = new MouseBotAction(x, y, leftClick, delay);

            MainWindow.AddBotAction(mouseBotAction);

            MainWindow.RefreshListBox();

            this.Close();

        }

        private void Button_SetLocation_Click(object sender, RoutedEventArgs e)
        {
            setMouseLocation = true;
            Label_SetLocationInfo.Visibility = Visibility.Visible;

            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F8 && setMouseLocation)
            {

                System.Drawing.Point mousePositionPoint = wf.Control.MousePosition;

                Label_X_Value.Content = mousePositionPoint.X.ToString();
                Label_Y_Value.Content = mousePositionPoint.Y.ToString();

                Label_SetLocationInfo.Visibility = Visibility.Collapsed;

                setMouseLocation = false;
            }
        }


        private void Button_TestLocation_Click(object sender, RoutedEventArgs e)
        {

            int x = Convert.ToInt32(Label_X_Value.Content);
            int y = Convert.ToInt32(Label_Y_Value.Content);

            SetPosition(x, y);

        }

        private void TextBox_Delay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
