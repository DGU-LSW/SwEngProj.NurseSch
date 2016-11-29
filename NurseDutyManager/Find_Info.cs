using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseDutyManager
{
    public partial class Find_Info : Form
    {
        ClientSocket clientsocket;
        //Nurse nurse;

        public Find_Info()
        {
            InitializeComponent();
        }
        public Find_Info(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lisenceNumber = textBox2.Text;

            clientsocket.ReturnInfo(name, lisenceNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string id = textBox4.Text;
            string lisenceNumber = textBox5.Text;

            clientsocket.ReturnInfo(id, name, lisenceNumber);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
