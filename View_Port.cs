using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace com_box
{
    public partial class View_Port : Form
    {
        public string PortName
        {
            get;
            set;
        }

        public View_Port()
        {
            InitializeComponent();
            string[] range = SerialPort.GetPortNames();
            cmbCom.Items.AddRange(range);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.PortName = this.cmbCom.Text;
        }
    }
}
