using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMAQ
{
    class GameController
    {
        public float FPS { get; set; } = 60;
        public float UPS { get; set; } = 100;

        public bool Quit { get; set; } = false;

        public void GameLoop()
        {
            int a = 0;
            while(!Quit)
            {
                if (TimeMAQ.TimeDelta() > 1 / 60)
                {
                    Console.WriteLine(a++);
                }
            }
            
        }
    }
}
