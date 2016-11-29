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
    /*
작성자 : 정창훈
Module : SignupForm
LOC    : 30
*/
    public partial class SignupForm : Form
    {
        ClientSocket clientsocket;
        Nurse nurse = null;

        public SignupForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("수간호사");
            comboBox1.Items.Add("일반간호사");
            comboBox2.Items.Add("남");
            comboBox2.Items.Add("여");
        }
        public SignupForm(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nurse = new Nurse();
            if (comboBox1.SelectedItem.Equals("수간호사"))
            {
                nurse.IsChiefNurse = true;
            }
            else
            {
                nurse.IsChiefNurse = false;
            }
            nurse.Name = textBox1.Text;
            nurse.ID = textBox2.Text;
            nurse.Password = textBox3.Text;
            if (comboBox2.SelectedItem.Equals("남"))
            {
                nurse.Sex = SEX.Male;
            }
            else
            {
                nurse.Sex = SEX.Female;
            }
            nurse.LicenseNum = textBox5.Text;
            nurse.PhoneNum = textBox6.Text;
            nurse.Group = GROUP.Group3;

            bool result = clientsocket.RegisterNurse(nurse);

            if (result)
            {
                MessageBox.Show("등록완료");
                this.Close();
            }
            else
            {
                MessageBox.Show("등록실패");
            }
        }
    }
}
