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
    /// Interaktionslogik für AddActionWindow.xaml
    /// </summary>
    public partial class AddActionWindow : Window
    {
        public AddActionWindow()
        {
            InitializeComponent();
        }

        private void Button_AddMouseAction_Click(object sender, RoutedEventArgs e)
        {

            CreateMouseActionWindow createMouseActionWindow = new CreateMouseActionWindow();
            createMouseActionWindow.Show();
            this.Close();

        }

        private void Button_AddKeyBoardAction_Click(object sender, RoutedEventArgs e)
        {
            CreateKeyboardActionWindow createKeyboardActionWindow = new CreateKeyboardActionWindow();
            createKeyboardActionWindow.Show();
            this.Close();
        }
    }
}
