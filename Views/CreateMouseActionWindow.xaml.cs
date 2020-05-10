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

        bool SetMouseLocation = false;
        

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
            int X = Convert.ToInt32(Label_X_Value.Content);
            int Y = Convert.ToInt32(Label_Y_Value.Content);
            int Delay;
            bool Left_Click;

            try
            {
                Delay = Convert.ToInt32(TextBox_Delay.Text);
            }
            catch
            {
                Delay = 0;
            }

            if ((bool)RadioButton_Leftclick.IsChecked)
            {
                Left_Click = true;
            }
            else
            {
                Left_Click = false;
            }

            MouseBotAction mouseBotAction = new MouseBotAction(X, Y, Left_Click, Delay);

            MainWindow.AddBotAction(mouseBotAction);

            MainWindow.RefreshListBox();

            this.Close();

        }

        private void Button_SetLocation_Click(object sender, RoutedEventArgs e)
        {
            SetMouseLocation = true;
            Label_SetLocationInfo.Visibility = Visibility.Visible;

            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F8 && SetMouseLocation)
            {

                System.Drawing.Point MousePositionPoint = wf.Control.MousePosition;

                Label_X_Value.Content = MousePositionPoint.X.ToString();
                Label_Y_Value.Content = MousePositionPoint.Y.ToString();

                Label_SetLocationInfo.Visibility = Visibility.Collapsed;

                SetMouseLocation = false;
            }
        }


        private void Button_TestLocation_Click(object sender, RoutedEventArgs e)
        {

            int X = Convert.ToInt32(Label_X_Value.Content);
            int Y = Convert.ToInt32(Label_Y_Value.Content);

            SetPosition(X, Y);

        }

        private void TextBox_Delay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
