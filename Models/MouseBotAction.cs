using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBot.Classes
{
    public class MouseBotAction : BotAction
    {

        public int x, y;
        public bool left_click { get; set; }

        public MouseBotAction(int x, int y, bool left_click, int delay)
        {
            this.x = x;
            this.y = y;
            this.left_click = left_click;
            this.delay = delay;
        }

    }
}
