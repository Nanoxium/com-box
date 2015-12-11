﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            
            //active le double buffer sur le panel de commande
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlCommand, new object[] { true }); 
             
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
        {/*
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
            control.SendCommand(control._robot.GetSendCommand());*/
        }

        private void tbxCommand_KeyUp(object sender, KeyEventArgs e)
        {
            //control.SetDirection(Robot.Direction.arret);
            //control.SendCommand(control._robot.GetSendCommand());
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

        private Point _mouseLocation;
        private const int ELLIPSE_SIZE = 10;

        private int _mouseX;
        private int _mouseY;
        private int MaxValue = 20;
                
        private readonly Pen _axes = new Pen(Color.Black);
        private readonly Pen _circle = new Pen(Color.Gray);
        private void pnlCommand_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawLine(this._axes, this.pnlCommand.Width / 2, 0, this.pnlCommand.Width / 2, this.pnlCommand.Height);
            e.Graphics.DrawLine(this._axes, 0, this.pnlCommand.Height / 2, this.pnlCommand.Width, this.pnlCommand.Height / 2);
            e.Graphics.DrawEllipse(this._circle, 0, 0, this.pnlCommand.Width-1, this.pnlCommand.Height-1);
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), new Rectangle(this._mouseLocation.X - ELLIPSE_SIZE / 2, this._mouseLocation.Y - ELLIPSE_SIZE / 2, ELLIPSE_SIZE, ELLIPSE_SIZE));
        }
        

        private void pnlCommand_MouseLeave(object sender, EventArgs e)
        {
            this._mouseLocation = new Point(this.pnlCommand.Width / 2, this.pnlCommand.Height / 2);
            Debug.WriteLine("Mouse left");
            this.pnlCommand.Invalidate();
        }

        private void pnlCommand_MouseMove(object sender, MouseEventArgs e)
        {
            const int maxvalue = 20;
            double offsetX = pnlCommand.Width/2;
            double offsetY = pnlCommand.Height/2;
            this._mouseLocation = e.Location;
            
            this._mouseX = (int)Math.Round((this._mouseLocation.X - offsetX)/offsetX*maxvalue, 0);
            this._mouseY = -(int)Math.Round((this._mouseLocation.Y - offsetY) / offsetY * maxvalue, 0);
            Debug.WriteLine("X: " + this._mouseX + ", Y: " + this._mouseY);
            this.pnlCommand.Invalidate();

            //contraule du robot
            control.SetRobotSpeed(_mouseY);
        }

        #endregion

        private void tmr_repaint_Tick(object sender, EventArgs e)
        {
            this.pnlCommand.Invalidate();
        }
    }
}
