using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Linq.Expressions;

namespace com_box
{
    class Controleur
    {
        private SerialPort _bluetoothSerialPort = null;
        private Form _view = null;

        public Controleur(Form view)
        {
            _view = view;
        }

        public bool ConnectBluetoothPort(string com)
        {
            bool connectionMade = true;
            try
            {
                _bluetoothSerialPort = new SerialPort(com);
            }
            catch (IOException e)
            {
                connectionMade = false;
            }

            return connectionMade;
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
                _bluetoothSerialPort.Write("N");

                //Récupère et sépare les valeurs des capteurs
                string[] answer = _bluetoothSerialPort.ReadLine().Split(',');

                //Créer le tableau de valeur
                values = new int[answer.Length - 1];

                //Parcourt le tableau de valeur et les converti
                for (int i = 1; i < answer.Length; i++)
                {
                    values[i] = Convert.ToInt32(answer[i]);
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
    }
}
