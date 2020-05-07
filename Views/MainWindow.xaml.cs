using EasyBot.Classes;
using EasyBot.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EasyBot.Views
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MouseBotAction TestMouseBotAction = new MouseBotAction(500, 200, true, 200);

        private static List<BotAction> Actions = new List<BotAction>();

        public static ListBox listBox;

        public MainWindow()
        {
            InitializeComponent();

            listBox = ListBox_Actions;

            listBox.ItemsSource = Actions;

            Actions.Add(TestMouseBotAction);

        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            AddActionWindow addActionWindow = new AddActionWindow();
            addActionWindow.Show();
        }

        public static void AddBotAction(BotAction botAction)
        {
            Actions.Add(botAction);
        }

        public static void RefreshListBox()
        {

            listBox.Items.Refresh();

        }
    }
}
