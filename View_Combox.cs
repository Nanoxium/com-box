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
                if (item == "COM7")
                {
                    cmbCom.Text = item.ToString();
                }
            }
        }

        public void UpdateSensor()
        {

            int[] sensor = control.GetSensorValues();
            if (sensor.Length == 10)
            {
                sensor1.Sensor_Front.Value = sensor[2];
                sensor1.Sensor_Front_L1.Value = sensor[1];
                sensor1.Sensor_Front_L2.Value = sensor[0];
                sensor1.Sensor_Front_R1.Value = sensor[3];
                sensor1.Sensor_Front_R2.Value = sensor[4];
                sensor1.Sensor_Back.Value = sensor[5];
                sensor1.Sensor_Bot_L1.Value = sensor[7];
                sensor1.Sensor_Bot_L2.Value = sensor[6];
                sensor1.Sensor_Bot_R1.Value = sensor[8];
                sensor1.Sensor_Bot_R2.Value = sensor[9];
            }
        }

        private void tms_sensor_Tick(object sender, EventArgs e)
        {
            UpdateSensor();
        }

        private void btnChangePort_Click(object sender, EventArgs e)
        {
            bool connected = control.ConnectBluetoothPort(this.cmbCom.SelectedItem.ToString());

            if (connected)
            {
                tms_sensor.Enabled = true;
                cmbCom.Enabled = false;
            }
            this.Focus();
        }

        private void View_Combox_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.CloseConnection();
        }

        private void tbxCommand_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: control.SetDirection(Robot.Direction.haut);
                    break;
                case Keys.Down: control.SetDirection(Robot.Direction.bas);
                    break;
                case Keys.Left: control.SetDirection(Robot.Direction.gauche);
                    break;
                case Keys.Right: control.SetDirection(Robot.Direction.droite);
                    break;

            }
            control.SendCommand(control._robot.GetSendCommand());
        }

        private void tbxCommand_KeyUp(object sender, KeyEventArgs e)
        {
            control.SetDirection(Robot.Direction.arret);
            control.SendCommand(control._robot.GetSendCommand());
        }

        private void View_Combox_Load(object sender, EventArgs e)
        {

        }

        private void tmr_movement_Tick(object sender, EventArgs e)
        {

        }

        private void View_Combox_KeyDown(object sender, KeyEventArgs e)
        {
            //this.ActiveControl = tbxCommand;
        }

        private void View_Combox_KeyUp(object sender, KeyEventArgs e)
        {
            //this.ActiveControl = tbxCommand;
        }




        #region Mouse Control

        private Point mouseLocation;
        private int ellipse_size = 10;

        private void pnlCommand_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black), pnlCommand.Width / 2, 0, pnlCommand.Width / 2, pnlCommand.Height);
            e.Graphics.DrawLine(new Pen(Color.Black), 0, pnlCommand.Height / 2, pnlCommand.Width, pnlCommand.Height / 2);
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), new Rectangle(mouseLocation.X - ellipse_size / 2, mouseLocation.Y - ellipse_size / 2, ellipse_size, ellipse_size));
        }


        private void pnlCommand_MouseEnter(object sender, EventArgs e)
        {

        }
        private void pnlCommand_MouseLeave(object sender, EventArgs e)
        {
            mouseLocation = new Point(pnlCommand.Width / 2, pnlCommand.Height / 2);

            pnlCommand.Invalidate();
        }
        private void pnlCommand_MouseMove(object sender, MouseEventArgs e)
        {
            mouseLocation = e.Location;

            pnlCommand.Invalidate();
        }

        #endregion

        private void tmr_repaint_Tick(object sender, EventArgs e)
        {
            pnlCommand.Invalidate();
        }
    }
}
