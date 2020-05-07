using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBot.Classes
{
    public class KeyBoardBotAction : BotAction
    {

        public string Text { get; set; }

        public KeyBoardBotAction(string Text, int Delay)
        {
            this.Text = Text;
            this.Delay = Delay;
            this.Name = Name;
        }

    }
}
