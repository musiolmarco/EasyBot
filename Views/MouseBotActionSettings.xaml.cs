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

            int X = Convert.ToInt32(Label_X_Value.Content);
            int Y = Convert.ToInt32(Label_Y_Value.Content);

            SetPosition(X, Y);

        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.DeleteBotAction();

            this.Close();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {

            int X = Convert.ToInt32(Label_X_Value.Content);
            int Y = Convert.ToInt32(Label_Y_Value.Content);
            int Delay;

            if (TextBox_Delay.Text != "")
            {
                Delay = Convert.ToInt32(TextBox_Delay.Text);
            }
            else
            {
                Delay = 0;
            }
            bool Left_Click;

            if ((bool)RadioButton_Leftclick.IsChecked)
            {
                Left_Click = true;
            }
            else
            {
                Left_Click = false;
            }


            MouseBotAction mouseBotAction = new MouseBotAction(X, Y, Left_Click, Delay);

            MainWindow.ChangeBotAction(mouseBotAction);

            this.Close();
        }

    }
}
