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
        
        public int rSpeed { get; set; }
        public int lSpeed { get; set; }

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



        /// <summary>
        /// Retourne la commande a envoyer
        /// </summary>
        /// <returns></returns>
        public string GetSendCommand()
        {
            return "D," + lSpeed + "," + rSpeed + "";;
        }
    }
}
