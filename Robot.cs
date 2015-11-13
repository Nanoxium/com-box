using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_box
{
    class Robot
    {
        public enum Direction
        {
            haut,
            bas,
            gauche,
            droite,
            arret
        }

        public int Speed { get; set; }
        Direction dir = Direction.arret;

        public Robot()
        {
            Speed = 5;
        }

        public string SendCommand()
        {
            switch(dir)
            {                    
                case Direction.arret: return "A,0,0,1";
                case Direction.haut: return "A,"+Speed+","+Speed+",10";
                case Direction.bas: return "A,-" + Speed + ",-" + Speed + ",10";
                case Direction.gauche: return "A,0," + Speed + ",10";
                case Direction.droite: return "A," + Speed + ",0,10";
            }
            return "A,0,0,1";

        }
    }
}
