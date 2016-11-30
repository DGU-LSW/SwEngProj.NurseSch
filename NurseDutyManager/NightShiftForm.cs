using System;
using System.Windows.Forms;

namespace NurseDutyManager
{
    // 작성자	: 김수희
    // Module	: NightShiftForm
    // LOC		: 59

    public partial class NightShiftForm : Form
    {
        ClientSocket clientsocket;
        Option option;

        public NightShiftForm()
        {
            InitializeComponent();
        }

        public NightShiftForm(ClientSocket _clientsocket, Option _option) : this()
        {
            this.option = _option;
            this.clientsocket = _clientsocket;
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
    }
}
