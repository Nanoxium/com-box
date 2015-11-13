namespace com_box
{
    partial class View_Combox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.btnChangePort = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxCommand = new System.Windows.Forms.TextBox();
            this.gbxSensor = new System.Windows.Forms.GroupBox();
            this.ehSensor = new System.Windows.Forms.Integration.ElementHost();
            this.sensor1 = new com_box.Sensor();
            this.gbxControls = new System.Windows.Forms.GroupBox();
            this.tms_sensor = new System.Windows.Forms.Timer(this.components);
            this.gbxSensor.SuspendLayout();
            this.gbxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(12, 12);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(121, 21);
            this.cmbCom.TabIndex = 0;
            // 
            // btnChangePort
            // 
            this.btnChangePort.Location = new System.Drawing.Point(139, 10);
            this.btnChangePort.Name = "btnChangePort";
            this.btnChangePort.Size = new System.Drawing.Size(82, 23);
            this.btnChangePort.TabIndex = 1;
            this.btnChangePort.Text = "Change port";
            this.btnChangePort.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(344, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop all";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(595, 10);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(105, 23);
            this.btnAdvance.TabIndex = 5;
            this.btnAdvance.Text = "Advance prop.";
            this.btnAdvance.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnUp.Location = new System.Drawing.Point(138, 19);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(39, 39);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLeft.Location = new System.Drawing.Point(55, 84);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(39, 39);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDown.Location = new System.Drawing.Point(138, 156);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(39, 39);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnRight.Location = new System.Drawing.Point(210, 84);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(39, 39);
            this.btnRight.TabIndex = 9;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(200, 226);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbxCommand
            // 
            this.tbxCommand.Location = new System.Drawing.Point(17, 228);
            this.tbxCommand.Name = "tbxCommand";
            this.tbxCommand.Size = new System.Drawing.Size(177, 20);
            this.tbxCommand.TabIndex = 11;
            // 
            // gbxSensor
            // 
            this.gbxSensor.Controls.Add(this.ehSensor);
            this.gbxSensor.Location = new System.Drawing.Point(12, 39);
            this.gbxSensor.Name = "gbxSensor";
            this.gbxSensor.Size = new System.Drawing.Size(326, 342);
            this.gbxSensor.TabIndex = 12;
            this.gbxSensor.TabStop = false;
            this.gbxSensor.Text = "Sensor";
            // 
            // ehSensor
            // 
            this.ehSensor.Location = new System.Drawing.Point(6, 19);
            this.ehSensor.Name = "ehSensor";
            this.ehSensor.Size = new System.Drawing.Size(313, 316);
            this.ehSensor.TabIndex = 3;
            this.ehSensor.Text = "ehSensor";
            this.ehSensor.Child = this.sensor1;
            // 
            // gbxControls
            // 
            this.gbxControls.Controls.Add(this.btnUp);
            this.gbxControls.Controls.Add(this.btnLeft);
            this.gbxControls.Controls.Add(this.tbxCommand);
            this.gbxControls.Controls.Add(this.btnDown);
            this.gbxControls.Controls.Add(this.btnSend);
            this.gbxControls.Controls.Add(this.btnRight);
            this.gbxControls.Location = new System.Drawing.Point(344, 39);
            this.gbxControls.Name = "gbxControls";
            this.gbxControls.Size = new System.Drawing.Size(356, 342);
            this.gbxControls.TabIndex = 13;
            this.gbxControls.TabStop = false;
            this.gbxControls.Text = "Controls";
            // 
            // tms_sensor
            // 
            this.tms_sensor.Enabled = true;
            this.tms_sensor.Interval = 10;
            this.tms_sensor.Tick += new System.EventHandler(this.tms_sensor_Tick);
            // 
            // View_Combox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 538);
            this.Controls.Add(this.gbxControls);
            this.Controls.Add(this.gbxSensor);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnChangePort);
            this.Controls.Add(this.cmbCom);
            this.Name = "View_Combox";
            this.Text = "View_Combox";
            this.gbxSensor.ResumeLayout(false);
            this.gbxControls.ResumeLayout(false);
            this.gbxControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.Button btnChangePort;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Integration.ElementHost ehSensor;
        private Sensor sensor1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxCommand;
        private System.Windows.Forms.GroupBox gbxSensor;
        private System.Windows.Forms.GroupBox gbxControls;
        private System.Windows.Forms.Timer tms_sensor;
    }
}