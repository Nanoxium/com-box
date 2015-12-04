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
            this.btnAdvance = new System.Windows.Forms.Button();
            this.gbxSensor = new System.Windows.Forms.GroupBox();
            this.ehSensor = new System.Windows.Forms.Integration.ElementHost();
            this.sensor1 = new com_box.Sensor();
            this.gbxControls = new System.Windows.Forms.GroupBox();
            this.pnlCommand = new System.Windows.Forms.Panel();
            this.tms_sensor = new System.Windows.Forms.Timer(this.components);
            this.tmr_repaint = new System.Windows.Forms.Timer(this.components);
            this.gbxSensor.SuspendLayout();
            this.gbxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(24, 23);
            this.cmbCom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(238, 33);
            this.cmbCom.TabIndex = 0;
            // 
            // btnChangePort
            // 
            this.btnChangePort.Location = new System.Drawing.Point(278, 19);
            this.btnChangePort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChangePort.Name = "btnChangePort";
            this.btnChangePort.Size = new System.Drawing.Size(164, 44);
            this.btnChangePort.TabIndex = 1;
            this.btnChangePort.Text = "Change port";
            this.btnChangePort.UseVisualStyleBackColor = true;
            this.btnChangePort.Click += new System.EventHandler(this.btnChangePort_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(688, 19);
            this.btnStop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(180, 44);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop all";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(1114, 19);
            this.btnAdvance.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(210, 44);
            this.btnAdvance.TabIndex = 5;
            this.btnAdvance.Text = "Advance prop.";
            this.btnAdvance.UseVisualStyleBackColor = true;
            // 
            // gbxSensor
            // 
            this.gbxSensor.Controls.Add(this.ehSensor);
            this.gbxSensor.Location = new System.Drawing.Point(24, 75);
            this.gbxSensor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxSensor.Name = "gbxSensor";
            this.gbxSensor.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxSensor.Size = new System.Drawing.Size(652, 658);
            this.gbxSensor.TabIndex = 12;
            this.gbxSensor.TabStop = false;
            this.gbxSensor.Text = "Sensor";
            // 
            // ehSensor
            // 
            this.ehSensor.Location = new System.Drawing.Point(12, 37);
            this.ehSensor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ehSensor.Name = "ehSensor";
            this.ehSensor.Size = new System.Drawing.Size(626, 608);
            this.ehSensor.TabIndex = 3;
            this.ehSensor.Text = "ehSensor";
            this.ehSensor.Child = this.sensor1;
            // 
            // gbxControls
            // 
            this.gbxControls.Controls.Add(this.pnlCommand);
            this.gbxControls.Location = new System.Drawing.Point(688, 75);
            this.gbxControls.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxControls.Name = "gbxControls";
            this.gbxControls.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxControls.Size = new System.Drawing.Size(636, 658);
            this.gbxControls.TabIndex = 13;
            this.gbxControls.TabStop = false;
            this.gbxControls.Text = "Controls";
            // 
            // pnlCommand
            // 
            this.pnlCommand.Location = new System.Drawing.Point(10, 35);
            this.pnlCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCommand.Name = "pnlCommand";
            this.pnlCommand.Size = new System.Drawing.Size(612, 612);
            this.pnlCommand.TabIndex = 0;
            this.pnlCommand.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCommand_Paint);
            this.pnlCommand.MouseLeave += new System.EventHandler(this.pnlCommand_MouseLeave);
            this.pnlCommand.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCommand_MouseMove);
            // 
            // tms_sensor
            // 
            this.tms_sensor.Tick += new System.EventHandler(this.tms_sensor_Tick);
            // 
            // tmr_repaint
            // 
            this.tmr_repaint.Tick += new System.EventHandler(this.tmr_repaint_Tick);
            // 
            // View_Combox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 738);
            this.Controls.Add(this.gbxControls);
            this.Controls.Add(this.gbxSensor);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnChangePort);
            this.Controls.Add(this.cmbCom);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "View_Combox";
            this.Text = "View_Combox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_Combox_FormClosing);
            this.Load += new System.EventHandler(this.View_Combox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.View_Combox_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.View_Combox_KeyUp);
            this.gbxSensor.ResumeLayout(false);
            this.gbxControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.Button btnChangePort;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Integration.ElementHost ehSensor;
        private Sensor sensor1;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.GroupBox gbxSensor;
        private System.Windows.Forms.GroupBox gbxControls;
        private System.Windows.Forms.Timer tms_sensor;
        private System.Windows.Forms.Panel pnlCommand;
        private System.Windows.Forms.Timer tmr_repaint;
    }
}