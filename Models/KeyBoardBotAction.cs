using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBot.Classes
{
    public class KeyBoardBotAction : BotAction
    {

        public string text { get; set; }

        public KeyBoardBotAction(string text, int delay)
        {
            this.text = text;
            this.delay = delay;
            this.name = "Text: \"" + text + "\"";
            this.displayColor = "#1dd1a1";
        }

    }
}
