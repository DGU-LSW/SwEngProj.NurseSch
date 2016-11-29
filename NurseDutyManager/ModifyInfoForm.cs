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
    public partial class ModifyInfoForm : Form
    {
        ClientSocket clientsocket;
        Nurse currentNurse;

        public ModifyInfoForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("수간호사");
            comboBox1.Items.Add("일반간호사");
            comboBox2.Items.Add("남");
            comboBox2.Items.Add("여");
            currentNurse = new Nurse();
        }
        public ModifyInfoForm(ClientSocket _clientsocket, string _id)
        {
            clientsocket = _clientsocket;
            currentNurse = clientsocket.getNurse(_id);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("수간호사"))
            {
                currentNurse.IsChiefNurse = true;
            }
            else
            {
                currentNurse.IsChiefNurse = false;
            }
            currentNurse.Name = textBox1.Text;
            currentNurse.Password = textBox2.Text;
            if (comboBox2.SelectedItem.Equals("남"))
            {
                currentNurse.Sex = SEX.Male;
            }
            else
            {
                currentNurse.Sex = SEX.Female;
            }
            currentNurse.LicenseNum = textBox4.Text;
            currentNurse.PhoneNum = textBox5.Text;
            currentNurse.Group = GROUP.Group3;
            //MessageBox.Show("수정 완료");
        }
    }
}
