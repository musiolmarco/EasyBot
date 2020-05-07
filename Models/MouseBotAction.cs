using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBot.Classes
{
    public class MouseBotAction : BotAction
    {

        public int X, Y;
        public bool Left_Click { get; set; }

        public MouseBotAction(int X, int Y, bool Left_Click, int Delay)
        {
            this.X = X;
            this.Y = Y;
            this.Left_Click = Left_Click;
            this.Delay = Delay;
            this.Name = Name;

            if (Left_Click)
            {
                DisplayColor = "#74b9ff";
                Name = "Leftclick";
            }
            else
            {
                DisplayColor = "#e84393";
                Name = "Rightclick";
            }
        }

    }
}
