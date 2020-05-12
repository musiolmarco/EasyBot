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
        public bool leftClick { get; set; }

        public MouseBotAction(int x, int y, bool leftClick, int delay)
        {
            this.x = x;
            this.y = y;
            this.leftClick = leftClick;
            this.delay = delay;
            this.name = name;

            if (leftClick)
            {
                displayColor = "#74b9ff";
                name = "Leftclick";
            }
            else
            {
                displayColor = "#e84393";
                name = "Rightclick";
            }
        }

    }
}
