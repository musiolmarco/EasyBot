using EasyBot.Classes;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using WindowsInput;

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

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        public static void LeftMouseClick(int X, int Y)
        {
            SetCursorPos(X, Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public static void RightMouseClick(int X, int Y)
        {
            SetCursorPos(X, Y);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();

            if (Actions.Count >= 1)
            {
                Thread.Sleep(Delay);
                
                for (int i = 0; i <= Actions.Count - 1; i++)
                {
                    if (Actions[i] is MouseBotAction)
                    {
                        MouseBotAction mouseBotAction = (MouseBotAction)Actions[i];

                        int X = mouseBotAction.X;
                        int Y = mouseBotAction.Y;

                        if (mouseBotAction.Left_Click)
                        {
                            LeftMouseClick(X, Y);
                        }
                        else
                        {
                            RightMouseClick(X, Y);
                        }
                    }
                    else if (Actions[i] is KeyBoardBotAction)
                    {
                        KeyBoardBotAction keyBoardBotAction = (KeyBoardBotAction)Actions[i];

                        InputSimulator inputSimulator = new InputSimulator();

                        inputSimulator.Keyboard.TextEntry(keyBoardBotAction.Text);
                    }

                    Thread.Sleep(Actions[i].Delay); 
                }
            }

            this.Show();
        }
    }
}
