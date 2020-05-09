using System.Windows;

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

            Button_Close.Click += (s, e) => Close();

            Button_Minimize.Click += (s, e) => WindowState = WindowState.Minimized;
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
