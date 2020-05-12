using EasyBot.Classes;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using wf = System.Windows.Forms;

namespace EasyBot.Views
{
    /// <summary>
    /// Interaktionslogik für MouseBotActionSettings.xaml
    /// </summary>
    public partial class MouseBotActionSettings : Window
    {

        private bool SetMouseLocation = false;

        public MouseBotActionSettings(MouseBotAction mouseBotAction, int Index)
        {
            InitializeComponent();

            Label_X_Value.Content = mouseBotAction.x;

            Label_Y_Value.Content = mouseBotAction.y;

            if (mouseBotAction.leftClick)
            {
                RadioButton_Leftclick.IsChecked = true;
            }
            else
            {
                RadioButton_Rightclick.IsChecked = true;
            }

            TextBox_Delay.Text = mouseBotAction.delay.ToString();

            Button_Close.Click += (s, e) => Close();

            Button_Minimize.Click += (s, e) => WindowState = WindowState.Minimized;

        }
        private void SetPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);


        private void TextBox_Delay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void Button_SetLocation_Click(object sender, RoutedEventArgs e)
        {

            SetMouseLocation = true;
            Label_SetLocationInfo.Visibility = Visibility.Visible;


        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F8 && SetMouseLocation)
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

            int x = Convert.ToInt32(Label_X_Value.Content);
            int y = Convert.ToInt32(Label_Y_Value.Content);

            SetPosition(x, y);

        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.DeleteBotAction();

            this.Close();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {

            int x = Convert.ToInt32(Label_X_Value.Content);
            int y = Convert.ToInt32(Label_Y_Value.Content);
            int delay;

            try
            {
                delay = Convert.ToInt32(TextBox_Delay.Text);
            }
            catch
            {
                delay = 0;
            }

            bool leftClick;

            if ((bool)RadioButton_Leftclick.IsChecked)
            {
                leftClick = true;
            }
            else
            {
                leftClick = false;
            }


            MouseBotAction mouseBotAction = new MouseBotAction(x, y, leftClick, delay);

            MainWindow.ChangeBotAction(mouseBotAction);

            this.Close();
        }

    }
}
