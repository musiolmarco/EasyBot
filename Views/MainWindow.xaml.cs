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
    public  partial class MainWindow : Window
    {

        private MouseBotAction TestMouseBotAction = new MouseBotAction(500, 200, true, 200);

        private MouseBotAction TestMouseBotAction2 = new MouseBotAction(500, 200, false, 200);

        private MouseBotAction TestMouseBotAction3 = new MouseBotAction(500, 312, false, 3122);

        private static List<BotAction> Actions = new List<BotAction>();

        public static ListBox listBox;

        public static int Loops = 0;

        public static int Delay = 0;

        public MainWindow()
        {
            InitializeComponent();

            listBox = ListBox_Actions;

            listBox.ItemsSource = Actions;

            Actions.Add(TestMouseBotAction);

            Actions.Add(TestMouseBotAction2);

            Actions.Add(TestMouseBotAction3);

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

        private void Button_UP_Click(object sender, RoutedEventArgs e)
        {

            if(ListBox_Actions.SelectedIndex != -1 && ListBox_Actions.SelectedIndex != 0) { 

            int NewIndex = ListBox_Actions.SelectedIndex - 1;

            BotAction botAction = (BotAction) ListBox_Actions.SelectedItem;

            Actions.Remove(botAction);

            Actions.Insert(NewIndex, botAction);


            RefreshListBox();

            }
        }

        private void Button_DOWN_Click(object sender, RoutedEventArgs e)
        {
            if(ListBox_Actions.SelectedIndex != -1 && ListBox_Actions.SelectedIndex != Actions.Count - 1)
            {

                int NewIndex = ListBox_Actions.SelectedIndex + 1;

                BotAction botAction = (BotAction)ListBox_Actions.SelectedItem;

                Actions.Remove(botAction);

                Actions.Insert(NewIndex, botAction);

                RefreshListBox();

            }
        }

        private void Button_Settings_Click(object sender, RoutedEventArgs e)
        {
            if(ListBox_Actions.SelectedIndex != -1)
            {

                if(ListBox_Actions.SelectedItem is MouseBotAction)
                {

                    MouseBotActionSettings mouseBotActionSettings = new MouseBotActionSettings((MouseBotAction)ListBox_Actions.SelectedItem, ListBox_Actions.SelectedIndex);

                    mouseBotActionSettings.Show();

                }
                else if (ListBox_Actions.SelectedItem is KeyBoardBotAction)
                {
                    KeyBoardBotActionSettings keyBoardBotActionSettings = new KeyBoardBotActionSettings((KeyBoardBotAction)ListBox_Actions.SelectedItem);

                    keyBoardBotActionSettings.Show();

                }

            }
            else
            {
                SettingsWindow settingsWindow = new SettingsWindow();
                settingsWindow.Show();
            }
        }

        public static void ChangeBotAction(BotAction botAction)
        {

            listBox.SelectedItem = botAction;

            int Index = listBox.SelectedIndex;

            Actions.Remove((BotAction)listBox.SelectedItem);

            Actions.Insert(Index, botAction);

            RefreshListBox();

        }

        public static void DeleteBotAction()
        {
            Actions.Remove((BotAction)listBox.SelectedItem);

            RefreshListBox();
        }

        private void Button_Deselect_Click(object sender, RoutedEventArgs e)
        {
            listBox.SelectedIndex = -1;
        }

    }
}
