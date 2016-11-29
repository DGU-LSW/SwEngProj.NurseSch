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
    // 작성자	: 김수희
    // Module	: OffOptionForm
    // LOC		: 

    public partial class OffOptionForm : Form
    {
        ClientSocket clientsocket;
        Option option;

        public OffOptionForm()
        {
            InitializeComponent();
        }

        public OffOptionForm(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            option.Holiday[0] = int.Parse(numericUpDown2.Value.ToString());
            option.Holiday[1] = int.Parse(numericUpDown1.Value.ToString());
            option.Holiday[2] = int.Parse(numericUpDown3.Value.ToString());

            option.Weekend[0] = int.Parse(numericUpDown4.Value.ToString());
            option.Weekend[1] = int.Parse(numericUpDown5.Value.ToString());
            option.Weekend[2] = int.Parse(numericUpDown6.Value.ToString());

            option.Monday[0] = int.Parse(numericUpDown11.Value.ToString());
            option.Monday[1] = int.Parse(numericUpDown12.Value.ToString());
            option.Monday[2] = int.Parse(numericUpDown10.Value.ToString());

            option.Tuesday[0] = int.Parse(numericUpDown9.Value.ToString());
            option.Tuesday[1] = int.Parse(numericUpDown8.Value.ToString());
            option.Tuesday[2] = int.Parse(numericUpDown7.Value.ToString());

            option.Wednesday[0] = int.Parse(numericUpDown17.Value.ToString());
            option.Wednesday[1] = int.Parse(numericUpDown18.Value.ToString());
            option.Wednesday[2] = int.Parse(numericUpDown16.Value.ToString());

            option.Thursday[0] = int.Parse(numericUpDown15.Value.ToString());
            option.Thursday[1] = int.Parse(numericUpDown14.Value.ToString());
            option.Thursday[2] = int.Parse(numericUpDown13.Value.ToString());

            option.Friday[0] = int.Parse(numericUpDown21.Value.ToString());
            option.Friday[1] = int.Parse(numericUpDown20.Value.ToString());
            option.Friday[2] = int.Parse(numericUpDown19.Value.ToString());

            clientsocket.setOption(option);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NightShiftForm f1 = new NightShiftForm();
            f1.Owner = this;
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
