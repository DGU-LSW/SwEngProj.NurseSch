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
    /*
     * 작성자 : 이신우
     * Module : 
     * LOC : 
     */
    public partial class UI : Form
    {
        
        ApplyOff applyOffForm;
        ChiefMenuForm chidfMenuForm;
        DutyList dutyListForm;
        LoginForm loginForm;
        ManageMemberForm manageMemberForm;
        NightShiftForm nightShiftForm;
        OffOptionForm offOptionForm;
        SignupForm signupForm;
        Find_Info findInfoForm;

		ClientSocket clientSocket;

        string currentID;

        public UI()
        {
            InitializeComponent();
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
                    panelLogin.Visible = false;
                    panelNurseMenu.Visible = false;
                    panelChiefMenu.Visible = true;
                    break;
                case 2://general menu
                    MessageBox.Show("일반 간호사 로그인");
                    currentID = id;
                    textBoxID.Text = "";
                    textBoxPW.Text = "";
                    panelLogin.Visible = false;
                    panelChiefMenu.Visible = false;
                    panelNurseMenu.Visible = true;
                    break;
            }
        }
        //회원가입
        private void buttonRegist_Click(object sender, EventArgs e)
        {
            signupForm = new SignupForm(clientSocket);
            this.ShowDialog(signupForm);
        }
        //ID,PW 찾기
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            findInfoForm = new Find_Info(clientSocket);
            this.ShowDialog(findInfoForm);
        }
        //표생성
        private void buttonCreateSch_Click(object sender, EventArgs e)
        {
            dutyListForm = new DutyList(clientSocket);
            this.ShowDialog(dutyListForm);
        }
        //간호사 관리
        private void buttonMangNur_Click(object sender, EventArgs e)
        {
            manageMemberForm = new ManageMemberForm(clientSocket);
            this.ShowDialog(manageMemberForm);
        }
        //옵션
        private void buttonOpt_Click(object sender, EventArgs e)
        {
            offOptionForm = new OffOptionForm(clientSocket);
            this.ShowDialog(offOptionForm);
        }
        //시간표확인_chief
        private void buttonChcekSch_chief_Click(object sender, EventArgs e)
        {

        }
        //off신청_chief
        private void buttonApplyOff_chief_Click(object sender, EventArgs e)
        {

        }
        //개인정보수정_chief
        private void buttonModifyInfo_chief_Click(object sender, EventArgs e)
        {

        }
        //표확인_일반
        private void button3_Click(object sender, EventArgs e)
        {

        }
        //off신청_일반
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //개인정보수정_일반
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //그룹별나이트근무설정
        private void buttonNightShift_Click(object sender, EventArgs e)
        {

        }
    }
}
