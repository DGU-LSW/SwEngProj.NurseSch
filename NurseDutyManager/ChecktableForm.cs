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
