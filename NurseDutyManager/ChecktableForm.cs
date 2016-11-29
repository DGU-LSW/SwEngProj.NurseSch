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
    public partial class ChecktableForm : Form
    {
        ClientSocket clientsocket = null;

        public ChecktableForm()
        {
            InitializeComponent();
        }

        public ChecktableForm(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
        }
    }
}
