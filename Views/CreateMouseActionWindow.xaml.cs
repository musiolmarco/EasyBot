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
using wf = System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

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
        }

        private void SetPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
