using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
작성자 : 정창훈
Module : SignupForm
LOC    : 140
*/
namespace NurseDutyManager
{
    public partial class SignupForm : Form
    {
        ClientSocket clientsocket;
        Nurse nurse = null;
        bool isEqual_ID = true;      //ID 중복검사를 위한 변수
        bool isEqual_License = false; //면허번호 중복검사를 위한 변수
		List<Nurse> nurse_list;

		public SignupForm()
        {
            InitializeComponent();
            comboBoxNurse.Items.Add("수간호사");
            comboBoxNurse.Items.Add("일반간호사");
            comboBoxSex.Items.Add("남");
            comboBoxSex.Items.Add("여");

		}
        public SignupForm(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
            comboBoxNurse.SelectedIndex = 1;//간호사구분 : 일반 간호사 초기화
            comboBoxSex.SelectedIndex = 1;  //성별 : '여'로 초기화

			nurse_list = clientsocket.getNurseList();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            #region 면허번호 중복처리

            isEqual_License = false;


            for (int i = 1; i < nurse_list.Count; i++)
            {
                isEqual_License = textBoxLicenseNum.Text.Equals(nurse_list[i].LicenseNum);
                if (isEqual_License == true)
                {
                    MessageBox.Show("면허번호가 이미 존재합니다.");
                    return;
                }
            }
           
            #endregion
            
            //중복확인 클릭 안했을 시 처리
            if (isEqual_ID)
            {
                MessageBox.Show("ID 중복확인을 하지 않았습니다.");

                return;
            }

            #region 간호사 데이터 입력처리
            nurse = new Nurse();
            if (comboBoxNurse.SelectedItem.Equals("수간호사"))
            {
                nurse.IsChiefNurse = true;
            }
            else
            {
                nurse.IsChiefNurse = false;
            }
            nurse.Name = textBoxName.Text;
            nurse.ID = textBoxID.Text;
            nurse.Password = textBoxPW.Text;
            if (comboBoxSex.SelectedItem.Equals("남"))
            {
                nurse.Sex = SEX.Male;
            }
            else
            {
                nurse.Sex = SEX.Female;
            }
            nurse.LicenseNum = textBoxLicenseNum.Text;
            nurse.PhoneNum = textBoxPhone.Text;
            nurse.Group = GROUP.Group3;
            #endregion

            //비밀번호 및 면허번호 조건 검사
            if (textBoxPW2.Text.Equals(textBoxPW.Text) && isEqual_License == false)
            {
                bool result = clientsocket.RegisterNurse(nurse);
                if (result)
                {
                    MessageBox.Show("등록완료");
                    this.Close();
                }
            }

            else if (!textBoxPW2.Text.Equals(textBoxPW.Text))
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isEqual_ID = true;

            for (int i = 0; i < nurse_list.Count; i++)
            {
                isEqual_ID = textBoxID.Text.Equals(nurse_list[i].ID);
                if (isEqual_ID == true)
                {
                    MessageBox.Show("ID가 이미 존재합니다.");
                    break;
                }
            }
            if (isEqual_ID == false)
            {
                MessageBox.Show("사용가능한 ID입니다");
            }
        }

        //버튼 클릭 후 ID 변경 예외 처리
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isEqual_ID = true;
        }

        //취소버튼
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
