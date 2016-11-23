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
        public ModifyInfoForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("수간호사");
            comboBox1.Items.Add("일반간호사");
            comboBox2.Items.Add("남");
            comboBox2.Items.Add("여");
        }
    }
}
