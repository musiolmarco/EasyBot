using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBot.Classes
{
    public class KeyBoardAction : BotAction
    {

        public string text { get; set; }

        public KeyBoardAction(string text, int delay)
        {
            this.text = text;
            this.delay = delay;
        }

    }
}
