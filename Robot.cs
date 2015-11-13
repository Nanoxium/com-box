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

        const string VITESSE = "5";
        Direction dir = Direction.arret;

        public string SendCommand()
        {
            switch(dir)
            {                    
                case Direction.arret: return "A,0,0,1";
                case Direction.haut: return "A,"+VITESSE+","+VITESSE+",10";
                case Direction.bas: return "A,-" + VITESSE + ",-" + VITESSE + ",10";
                case Direction.gauche: return "A,0," + VITESSE + ",10";
                case Direction.droite: return "A," + VITESSE + ",0,10";
            }
            return "A,0,0,1";

        }
    }
}
