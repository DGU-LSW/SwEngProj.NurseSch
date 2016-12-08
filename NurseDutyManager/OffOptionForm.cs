using System;
using System.Windows.Forms;
/*
 * 작성: 김수희 
 * Module: OffOption
 * LOC: 109
 */
namespace NurseDutyManager
{
    public partial class OffOptionForm : Form
    {
        ClientSocket clientsocket;
        Option option;

        string opt = null;

        public OffOptionForm()
        {
            InitializeComponent();
        }

        public OffOptionForm(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
            loadOption();
        }

        private void loadOption()
        {
			if(clientsocket.getOption() != null)
			{
				option = clientsocket.getOption();
				MessageBox.Show(option.ToString());
			}
			else
			{
				option = new Option();
			}


		}

        public void button2_Click(object sender, EventArgs e)
        {
            option.Monday = new int[3];
            option.Tuesday = new int[3];
            option.Wednesday = new int[3];
            option.Thursday = new int[3];
            option.Friday = new int[3];
            option.Weekend = new int[3];
            option.Holiday = new int[3];

            for(int i = 0; i < 3; i++)
            {
                option.Monday[i] = 0;
                option.Tuesday[i] = 0;
                option.Wednesday[i] = 0;
                option.Thursday[i] = 0;
                option.Friday[i] = 0;
                option.Weekend[i] = 0;
                option.Holiday[i] = 0;
            }

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

            this.Close();
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            NightShiftForm f1 = new NightShiftForm(clientsocket, option);
            f1.Owner = this;
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
