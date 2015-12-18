using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace com_box
{
    class Controleur
    {
        #region Fields
        private SerialPort _bluetoothSerialPort = null;
        private Form _view = null;
        public Robot _robot;
        private bool robotConnected = false;
        #endregion

        #region Controller
        public Controleur(Form view)
        {
            _view = view;
            _robot = new Robot();
        }
        #endregion


        /// <summary>
        /// Connecte le programme au port bluetooth utilisé par l'adaptateur
        /// </summary>
        /// <param name="com"></param>
        /// <returns></returns>
        public bool ConnectBluetoothPort(string com)
        {
            bool connectionMade = true;
            try
            {
                _bluetoothSerialPort = new SerialPort(com, 9600);
                _bluetoothSerialPort.Open();
                robotConnected = true;
            }
            catch (IOException e)
            {
                MessageBox.Show("Erreur de connection");
                connectionMade = false;
            }

            return connectionMade;
        }

        /// <summary>
        /// Termine la connection
        /// </summary>
        public void CloseConnection()
        {
            
            if (_bluetoothSerialPort != null)
                _bluetoothSerialPort.Close();
        }

        /// <summary>
        /// Retourne un tableau de valeur des capteurs suivants dans l'ordre
        ///  Left, Front_Left, Front, Front_Right, Right, Rear,
        ///  Ground_Left, Ground_Front_Left, Ground_Front_Right, Ground_Right
        /// </summary>
        /// <returns>int[] values</returns>
        public int[] GetSensorValues()
        {
            int[] values = new int[10];
            try
            {
                //Envoie la commande
                _bluetoothSerialPort.DiscardInBuffer();
                _bluetoothSerialPort.WriteLine("N");

                //Récupère et sépare les valeurs des capteurs
                string[] answer = _bluetoothSerialPort.ReadLine().Split(',');

                //Créer le tableau de valeur
                values = new int[answer.Length - 1];

                //Parcourt le tableau de valeur et les converti
                for (int i = 0; i < answer.Length - 1; i++)
                {
                    values[i] = Convert.ToInt32(answer[i + 1]);
                }
            }
            catch (Exception e)
            {
                values = null;
                MessageBox.Show("Erreur lors de la récupération de la valeur des capteurs de proximité" + Environment.NewLine + e.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return values;
        }

        /// <summary>
        /// Défini la vitesse du robot
        /// </summary>
        /// <param name="ySpeed"></param>
        /// <param name="xSpeed"></param>
        public void SetRobotSpeed(int ySpeed, int xSpeed)
        {
           //Si le robot doit se deplacer
            if (ySpeed != 0)
            {
                //Si le robot se dirige ver la droite
                if (xSpeed > 0)
                {
                    _robot.lSpeed = ySpeed + xSpeed;
                    _robot.rSpeed = ySpeed;
                }
                else
                {
                    _robot.lSpeed = ySpeed;
                    _robot.rSpeed = ySpeed - xSpeed;
                }
            }
            else
            {
                //Le robot tourne sur lui meme
                _robot.lSpeed = xSpeed;
                _robot.rSpeed = -xSpeed;
            }
        }

        /// <summary>
        /// Envoi une commande au robot
        /// </summary>
        /// <param name="command">Commande a envoyer</param>
        public void SendCommand(string command)
        {
            //si le bluetooth est bien connecté
            if(robotConnected)
                _bluetoothSerialPort.WriteLine(command);
            
                
        }
    }
}
