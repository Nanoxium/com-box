using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com_box
{
    public partial class View_Combox : Form
    {
        Controleur control;

        public View_Combox()
        {
            InitializeComponent();
            control = new Controleur();
            
            foreach (string item in System.IO.Ports.SerialPort.GetPortNames())
            {   
                cmbCom.Items.Add(item);
            }
            
        }


        public void UpdateSensor()
        {
            /*
            sensor1.Sensor_Front.Value = f;
            sensor1.Sensor_Front_L1.Value = fl1;
            sensor1.Sensor_Front_L2.Value = fl2;
            sensor1.Sensor_Front_R1.Value = fr1;
            sensor1.Sensor_Front_R2.Value = fr2;
            sensor1.Sensor_Back.Value = back;
            sensor1.Sensor_Bot_L1.Value = bl1;
            sensor1.Sensor_Bot_L2.Value = bl2;
            sensor1.Sensor_Bot_R1.Value = br1;
            sensor1.Sensor_Bot_R2.Value = br2;
             */
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int value = 500;
            sensor1.Sensor_Front.Value = value;
            sensor1.Sensor_Front_L1.Value = value;
            sensor1.Sensor_Front_L2.Value = value;
            sensor1.Sensor_Front_R1.Value = value;
            sensor1.Sensor_Front_R2.Value = value;
            sensor1.Sensor_Back.Value = value;
            sensor1.Sensor_Bot_L1.Value = value;
            sensor1.Sensor_Bot_L2.Value = value;
            sensor1.Sensor_Bot_R1.Value = value;
            sensor1.Sensor_Bot_R2.Value = value;
        }

        private void tms_sensor_Tick(object sender, EventArgs e)
        {
            UpdateSensor();
        }
    }
}
