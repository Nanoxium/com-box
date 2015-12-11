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

        public Direction Dir
        {
            get { return dir; }
            set { dir = value; }
        }

        public Robot()
        {
            Speed = 20;
        }




        public string GetSendCommand()
        {
            switch(Dir)
            {                    
                case Direction.arret: return "D,0,0";

                case Direction.haut: return "D," + Speed + "," + Speed + "";

                case Direction.bas: return "D," + -Speed + "," + -Speed + "";

                case Direction.gauche: return "D," + -Speed + "," + Speed + "";

                case Direction.droite: return "D," + Speed + "," + -Speed;

                default: return "D,0,0";
            }
        }
    }
}
