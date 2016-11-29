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
        }
        public ModifyInfoForm(ClientSocket _clientsocket, string _id) : this()
        {
            clientsocket = _clientsocket;
            currentNurse = clientsocket.getNurse(_id);
            if (currentNurse.IsChiefNurse == true)
            {
                comboBoxType.SelectedIndex = 0;
            }
            else
            {
                comboBoxType.SelectedIndex = 1;
            }

            if (currentNurse.Sex == SEX.Male)
            {
                comboBoxSex.SelectedIndex = 0;
            }
            else
            {
                comboBoxSex.SelectedIndex = 1;
            }
            textBoxName.Text = currentNurse.Name;
            textBoxID.Text = currentNurse.ID;
            textBoxPW.Text = textBoxPW2.Text = currentNurse.Password;
            textBoxLic.Text = currentNurse.LicenseNum;
            textBoxPh.Text = currentNurse.PhoneNum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!textBoxPW.Text.Equals(textBoxPW2.Text))
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return;
            }
            //string 입력은 , << 제거 처리
            if (comboBoxType.SelectedIndex == 0)    //수간호사 선택
            {
                currentNurse.IsChiefNurse = true;
            }
            else
            {
                currentNurse.IsChiefNurse = false;
            }

            currentNurse.Name = textBoxName.Text;
            
            currentNurse.Password = textBoxPW.Text;
            if (comboBoxSex.SelectedIndex == 0)
            {
                currentNurse.Sex = SEX.Male;
            }
            else
            {
                currentNurse.Sex = SEX.Female;
            }
            currentNurse.LicenseNum = textBoxLic.Text;
            currentNurse.PhoneNum = textBoxPh.Text;
            bool result = clientsocket.modifyNurse(currentNurse.ID, currentNurse);
            if (result)
            {
                MessageBox.Show("수정완료");
            }
            else
            {
                MessageBox.Show("수정실패");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
