using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 * 작성: 정창훈
 * Module: ModifyInfoForm
 * LOC: 125
 */
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

			if (currentNurse == null)
			{
				MessageBox.Show("getNurse 에러");

				return;
			}
			#region 콤보박스 셋팅
            if (currentNurse.IsChiefNurse == true)  //수간호사 일 경우
            {
                comboBoxType.SelectedIndex = 0;
            }
            else
            {
                comboBoxType.SelectedIndex = 1;
            }

            if (currentNurse.Sex == SEX.Male)   //남자일 경우
            {
                comboBoxSex.SelectedIndex = 0;
            }
            else
            {//여자일 경우
                comboBoxSex.SelectedIndex = 1;
            }
            textBoxName.Text = currentNurse.Name;
            textBoxID.Text = currentNurse.ID;
            textBoxPW.Text = textBoxPW2.Text = currentNurse.Password;
            textBoxLic.Text = currentNurse.LicenseNum;
            textBoxPh.Text = currentNurse.PhoneNum;
            #endregion
        }
        private void button1_Click(object sender, EventArgs e)
        {
			List<Nurse> nurseList = clientsocket.getNurseList();

            #region 비일번호 일치 검사
            if (!textBoxPW.Text.Equals(textBoxPW2.Text))     //비밀번호 일치 검사
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return;
            }
            #endregion
            #region 기존의 라이센스 검사
            List<Nurse> list = clientsocket.getNurseList();
            for (int i = 0; i < list.Count; i++)    //라이센스 번호 검사
            {
                if (textBoxLic.Text.Equals(list[i].LicenseNum) &&
                    !textBoxID.Text.Equals(list[i].ID))
                {
                    MessageBox.Show("라이센스 번호가 이미 존재합니다.");
                    return;
                }
            }
            #endregion
            //string 입력은 , << 제거 처리
            #region 정보 입력
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
            #endregion
            #region 서버에 저장
            bool result = clientsocket.modifyNurse(currentNurse.ID, currentNurse, nurseList);
            if (result)
            {
                MessageBox.Show("수정완료");
            }
            else
            {
                MessageBox.Show("수정실패");
            }
            #endregion
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
