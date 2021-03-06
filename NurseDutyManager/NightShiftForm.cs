﻿using System;
using System.Windows.Forms;
/*
 * 작성: 김수희 
 * Module: NightShiftForm
 * LOC: 42
 */
namespace NurseDutyManager
{
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
            
            option.Group1 = (int)numericUpDown1.Value;
            option.Group2 = (int)numericUpDown2.Value;
            option.Group3 = (int)numericUpDown3.Value;

            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
