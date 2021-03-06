﻿using System;
using System.Windows.Forms;
/*
 * 작성: 정창훈, 이신우, 김수희, 임제희 
 * Module: UI
 * LOC: 138
 */
namespace NurseDutyManager
{
    public partial class UI : Form
    {
        
        ApplyOff applyOffForm;
        CheckTableForm checktableForm;
        DutyList dutyListForm;
        ManageMemberForm manageMemberForm;
        ModifyInfoForm modifyInfoForm;
        NightShiftForm nightShiftForm;
        OffOptionForm offOptionForm;
        SignupForm signupForm;
        Find_Info findInfoForm;

		ClientSocket clientSocket;

        string currentID;

        public UI()
        {
            InitializeComponent();

			clientSocket = new ClientSocket();
        }

        //로그인버튼 클릭
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string pw = textBoxPW.Text;

            int result = clientSocket.logIn(id, pw);

            switch (result)
            {
                case 0://로그인 실패
                    MessageBox.Show("실패");
                    textBoxPW.Text = "";
                    break;
                case 1://chief menu
                    MessageBox.Show("수간호사 로그인");
                    currentID = id;
                    textBoxID.Text = "";
                    textBoxID.Text = "";
                    tabControl1.SelectedTab = tabPageChief;
                    break;
                case 2://general menu
                    MessageBox.Show("일반 간호사 로그인");
                    currentID = id;
                    textBoxID.Text = "";
                    textBoxPW.Text = "";
                    tabControl1.SelectedTab = tabPageGenaral;
                    break;
            }
        }
        //회원가입
        private void buttonRegist_Click(object sender, EventArgs e)
        {
            signupForm = new SignupForm(clientSocket);
            signupForm.ShowDialog(this);
        }
        //ID,PW 찾기
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            findInfoForm = new Find_Info(clientSocket);
            findInfoForm.ShowDialog(this);
        }
        //표생성
        private void buttonCreateSch_Click(object sender, EventArgs e)
        {
            dutyListForm = new DutyList(clientSocket);
            dutyListForm.ShowDialog(this);
        }
        //간호사 관리
        private void buttonMangNur_Click(object sender, EventArgs e)
        {
            manageMemberForm = new ManageMemberForm(clientSocket);
            manageMemberForm.ShowDialog(this);
        }
        //옵션
        private void buttonOpt_Click(object sender, EventArgs e)
        {
            offOptionForm = new OffOptionForm(clientSocket);
            offOptionForm.ShowDialog(this);
        }
        //시간표확인_chief
        private void buttonChcekSch_chief_Click(object sender, EventArgs e)
        {
            checktableForm = new CheckTableForm(clientSocket);
            checktableForm.ShowDialog(this);
        }
        //off신청_chief
        private void buttonApplyOff_chief_Click(object sender, EventArgs e)
        {
            applyOffForm = new ApplyOff(clientSocket, currentID);
            applyOffForm.ShowDialog(this);
        }
        //개인정보수정_chief
        private void buttonModifyInfo_chief_Click(object sender, EventArgs e)
        {
            modifyInfoForm = new ModifyInfoForm(clientSocket, currentID);
            modifyInfoForm.ShowDialog(this);
        }
        //표확인_일반
        private void button3_Click(object sender, EventArgs e)
        {
            checktableForm = new CheckTableForm(clientSocket);
            checktableForm.ShowDialog(this);
        }
        //off신청_일반
        private void button2_Click(object sender, EventArgs e)
        {
            applyOffForm = new ApplyOff(clientSocket, currentID);
            applyOffForm.ShowDialog(this);
        }
        //개인정보수정_일반
        private void button1_Click(object sender, EventArgs e)
        {
            modifyInfoForm = new ModifyInfoForm(clientSocket, currentID);
            modifyInfoForm.ShowDialog(this);
        }

		private void UI_FormClosing(object sender, FormClosingEventArgs e)
		{
			clientSocket.StopClient();
		}
	}
}
