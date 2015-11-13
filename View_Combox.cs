﻿using System;
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
            control = new Controleur(this);
            
            foreach (string item in System.IO.Ports.SerialPort.GetPortNames())
            {   
                cmbCom.Items.Add(item);
            }
        }


        public void UpdateSensor()
        {
            
            int[] sensor = control.GetSensorValues();
            
            sensor1.Sensor_Front.Value = sensor[2];
            sensor1.Sensor_Front_L1.Value =sensor[1];
            sensor1.Sensor_Front_L2.Value = sensor[0];
            sensor1.Sensor_Front_R1.Value = sensor[3];
            sensor1.Sensor_Front_R2.Value = sensor[4];
            sensor1.Sensor_Back.Value = sensor[5];
            sensor1.Sensor_Bot_L1.Value = sensor[7];
            sensor1.Sensor_Bot_L2.Value = sensor[6];
            sensor1.Sensor_Bot_R1.Value = sensor[8];
            sensor1.Sensor_Bot_R2.Value = sensor[9];
             
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

        private void btnChangePort_Click(object sender, EventArgs e)
        {
            bool connected = control.ConnectBluetoothPort(this.cmbCom.SelectedItem.ToString());

            if(connected)
            {
                tms_sensor.Enabled = true;
            }
        }

        private void View_Combox_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.CloseConnection();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }
    }
}
