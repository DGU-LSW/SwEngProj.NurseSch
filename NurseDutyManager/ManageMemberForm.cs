﻿using System;
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
    public partial class ManageMemberForm : Form
    {
        ClientSocket clientsocket = null;
        List<Nurse> list = null;
        public ManageMemberForm()
        {
            InitializeComponent();
        }
        public ManageMemberForm(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
            loadNurse();
        }
        private void loadNurse()
        {
            list = clientsocket.getNurseList();
            listBox1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                listBox1.Items.Add(list[i].Name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; //선택된 간호사의 index
            Nurse newInfo = list[index];
            if(comboBox1.SelectedIndex == 0)
            {
                newInfo.Group = GROUP.Group1;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                newInfo.Group = GROUP.Group2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                newInfo.Group = GROUP.Group3;
            }
            bool result = clientsocket.modifyNurse(newInfo.ID, newInfo);
            if (!result) { MessageBox.Show("변경 실패"); }
            else {
                MessageBox.Show("변경 완료");
                loadNurse();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Nurse selectedNurse = list[index];
            if (selectedNurse.Group == GROUP.Group1)
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (selectedNurse.Group == GROUP.Group2)
            {
                comboBox1.SelectedIndex = 1;
            }
            else if (selectedNurse.Group == GROUP.Group3)
            {
                comboBox1.SelectedIndex = 2;
            }

            textBoxID.Text = selectedNurse.Name;
            textBoxPW.Text = selectedNurse.Password;
            textBoxSex.Text = selectedNurse.Sex.ToString();
            textBoxLicNum.Text = selectedNurse.LicenseNum;
            textBoxPhNum.Text = selectedNurse.PhoneNum;
        }
    }
}
