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
    // Module	: NightShiftForm
    // LOC		: 

    public partial class NightShiftForm : Form
    {
        ClientSocket clientsocket;
        Option option;

        public NightShiftForm()
        {
            InitializeComponent();
        }
        
        public NightShiftForm(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            option.Group1 = int.Parse(numericUpDown1.Value.ToString());
            option.Group2 = int.Parse(numericUpDown2.Value.ToString());
            option.Group3 = int.Parse(numericUpDown3.Value.ToString());

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
