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
    public partial class ModifyPwForm : Form
    {
        ClientSocket clientSocket = null;
        Nurse target = null;
        public ModifyPwForm()
        {
            InitializeComponent();
        }
        public ModifyPwForm(ClientSocket _clientsocket, Nurse _target) : this()
        {
            clientSocket = _clientsocket;
            target = _target;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBoxPW.Text.Equals(textBoxPW2.Text))
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            }
            else
            {
                target.Password = textBoxPW.Text;
                bool result = clientSocket.modifyNurse(target.ID, target);
                if (result)
                {
                    MessageBox.Show("변경 완료");
                }
                else
                {
                    MessageBox.Show("변경 실패");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPW.Text = null;
            textBoxPW2.Text = null;
            this.Close();
        }
    }
}
