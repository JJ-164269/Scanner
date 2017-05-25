using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Scanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            short[] ListaPortow = { 20, 21, 22, 55, 66, 67, 68, 89, 99 };
            string host = textBox1.Text;
            listBox1.Items.Add("Scanning for" + host);
            listBox1.Items.Add("This might take a while!");
            foreach(short port in ListaPortow)
            {
                this.Refresh();
                try
                {
                    TcpClient klient = new TcpClient(host, port);
                    listBox1.Items.Add("Port: " + port.ToString() + " is open");
                }
                catch
                {
                    listBox1.Items.Add("Port: " + port.ToString() + " is closed.");
                }
            }

        }
    }
}
