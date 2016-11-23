﻿using System;
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
    public partial class UI : Form
    {
        static readonly string pathNurse = "C"; //간호사 리스트 위치
        static readonly string pathOption = ""; //옵션 저장 위치
        static readonly string pathOffList = "";//off신청 리스트 위치
        static readonly string pathSch = "";    //Schedul 리스트 위치

        ApplyOff applyOffForm;
        ChiefMenuForm chidfMenuForm;
        DutyList dutyListForm;
        LoginForm loginForm;
        ManageMemberForm manageMemberForm;
        NightShiftForm nightShiftForm;
        OffOptionForm offOptionForm;
        SignupForm signupForm;

        public UI()
        {
            InitializeComponent();
        }
        //로그인버튼 클릭
        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
        //회원가입
        private void buttonRegist_Click(object sender, EventArgs e)
        {

        }
        //ID,PW 찾기
        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
        //표생성
        private void buttonCreateSch_Click(object sender, EventArgs e)
        {
            dutyListForm.ShowDialog();  //매개변경필요
        }
        //간호사 관리
        private void buttonMangNur_Click(object sender, EventArgs e)
        {

        }
        //옵션
        private void buttonOpt_Click(object sender, EventArgs e)
        {

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
    }
}