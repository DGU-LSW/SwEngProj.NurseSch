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
    public partial class SignupForm : Form
    {
        ClientSocket clientsocket;
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

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
