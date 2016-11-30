using System;
using System.Windows.Forms;

namespace NurseDutyManager
{
    public partial class Find_Info : Form
    {
        ClientSocket clientsocket = null;
        ModifyPwForm modifyPwForm = null;
        public Find_Info()
        {
            InitializeComponent();
        }
        public Find_Info(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
        }

        private void buttonFind_ID_Click(object sender, EventArgs e)
        {
            Nurse info = clientsocket.ReturnInfo(textBoxName_ID.Text, textBoxLicNum_ID.Text);
            if (info != null)
            {
                MessageBox.Show(info.Name + " 의 ID는 " + info.ID + "입니다.");
            }
            else
            {
                MessageBox.Show("찾기 실패");
                textBoxLicNum_ID.Text = null;
                textBoxName_ID.Text = null;
            }
        }

        private void buttonFind_PW_Click(object sender, EventArgs e)
        {
            Nurse info = clientsocket.ReturnInfo(textBoxID_PW.Text, textBoxName_PW.Text, textBoxLicNum_PW.Text);
            if (info != null)
            {
                modifyPwForm = new ModifyPwForm(clientsocket, info);

				modifyPwForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("찾기 실패");
                textBoxID_PW.Text = null;
                textBoxLicNum_PW.Text = null;
                textBoxName_PW.Text = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxID_PW.Text = null;
            textBoxLicNum_ID.Text = null;
            textBoxLicNum_PW.Text = null;
            textBoxName_ID.Text = null;
            textBoxName_PW.Text = null;

            this.Close();
        }
    }
}
