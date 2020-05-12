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

        private static List<BotAction> actions = new List<BotAction>();

        public static ListBox listBox;

        public static int loops = 0;

        public static int delay = 0;

        public MainWindow()
        {
            InitializeComponent();

            
            Button_Close.Click += (s, e) => Close();

            Button_Minimize.Click += (s, e) => WindowState = WindowState.Minimized;

            listBox = ListBox_Actions;

            listBox.ItemsSource = actions;

        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            AddActionWindow addActionWindow = new AddActionWindow();
            addActionWindow.Show();
        }

        public static void AddBotAction(BotAction botAction)
        {
            actions.Add(botAction);
        }

        public static void RefreshListBox()
        {

            listBox.Items.Refresh();


        }

        private void Button_UP_Click(object sender, RoutedEventArgs e)
        {

            if(ListBox_Actions.SelectedIndex != -1 && ListBox_Actions.SelectedIndex != 0) { 

            int newIndex = ListBox_Actions.SelectedIndex - 1;

            BotAction botAction = (BotAction) ListBox_Actions.SelectedItem;

            actions.Remove(botAction);

            actions.Insert(newIndex, botAction);


            RefreshListBox();

            }
        }

        private void Button_DOWN_Click(object sender, RoutedEventArgs e)
        {
            if(ListBox_Actions.SelectedIndex != -1 && ListBox_Actions.SelectedIndex != actions.Count - 1)
            {

                int newIndex = ListBox_Actions.SelectedIndex + 1;

                BotAction botAction = (BotAction)ListBox_Actions.SelectedItem;

                actions.Remove(botAction);

                actions.Insert(newIndex, botAction);

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

            int index = listBox.SelectedIndex;

            actions.Remove((BotAction)listBox.SelectedItem);

            actions.Insert(index, botAction);

            RefreshListBox();

        }

        public static void DeleteBotAction()
        {
            actions.Remove((BotAction)listBox.SelectedItem);

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

            if (actions.Count >= 1)
            {
                Thread.Sleep(delay);

                for(int l = 0; l <= loops; l++) { 
                
                for (int i = 0; i <= actions.Count - 1; i++)
                {
                    if (actions[i] is MouseBotAction)
                    {
                        MouseBotAction mouseBotAction = (MouseBotAction)actions[i];

                        int x = mouseBotAction.x;
                        int y = mouseBotAction.y;

                        if (mouseBotAction.leftClick)
                        {
                            LeftMouseClick(x, y);
                        }
                        else
                        {
                            RightMouseClick(x, y);
                        }
                    }
                    else if (actions[i] is KeyBoardBotAction)
                    {
                        KeyBoardBotAction keyBoardBotAction = (KeyBoardBotAction)actions[i];

                        InputSimulator inputSimulator = new InputSimulator();

                        inputSimulator.Keyboard.TextEntry(keyBoardBotAction.text);
                    }

                    Thread.Sleep(actions[i].delay); 
                }
            }
            }

            this.Show();
        }
    }
}
