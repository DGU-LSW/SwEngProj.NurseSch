using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * 작성: 임제희
 * Module: DutyList 폼
 * LOC:
 */

namespace NurseDutyManager
{
	public partial class DutyList : Form
	{
		DateTime today = DateTime.Today;
		int thisyear;
		int thismonth;
        ClientSocket clientsocket;

		Scheduler scheduler;
		MonthSchedule monthSchedule;

		// 서버로부터 리턴받을 간호사 리스트, 오프리스트, 옵션
		List<Nurse> nurseList;
		List<Off> offList;
		Option option;

		int numbOfNurse; // 간호사의 숫자

		public DutyList()
		{
			InitializeComponent();

			thisyear = today.Year;
			thismonth = today.Month;

			for (int i = 0; i < 3; i++)
			{
				cboxYear.Items.Add(thisyear + i);
			}

			cboxYear.SelectedIndex = cboxYear.Items.IndexOf(thisyear);

			cboxMonth.Items.Clear();

			for (int i = thismonth; i <= 12; i++)
			{
				cboxMonth.Items.Add(i);
			}
		}

        public DutyList(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;

			// 오프 리스트 불러오고, 간호사 리스트 불러온다!
			offList = clientsocket.getOffList();
			nurseList = clientsocket.getNurseList();
			option = clientsocket.getOption();
			numbOfNurse = nurseList.Count;
		}

		private void cboxYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboxYear.SelectedIndex != 0)
			{
				cboxMonth.Items.Clear();

				for (int i = 1; i <= 12; i++)
				{
					cboxMonth.Items.Add(i);
				}
			}

			else
			{
				cboxMonth.Items.Clear();

				for (int i = thismonth; i <= 12; i++)
				{
					cboxMonth.Items.Add(i);
				}
			}
		}

		private void btnMakeDutyList_Click(object sender, EventArgs e)
		{
			if(cboxMonth.SelectedItem == null)
			{
				MessageBox.Show("몇월 근무표를 만들지 선택해주십시오!", "알림");

				return;
			}

			SwitchButton(true);

			scheduler = new Scheduler(clientsocket, nurseList, offList, option, today);
			

			// 로딩을 완전히 마치면 표의 visible=true을 한다(SwitchButton 메소드 이용)
			// 표 생성 버튼을 누르면 scheduler 객체의 메소드 MakeSchedule()를 호출하고,
			// 이 클래스의 멤버 monthSchedule에 참조를 저장한다. 그리고 텍스트박스에 tostring값을 저장한다.
			monthSchedule = scheduler.makeSchedule();
			tboxDutyList.Text = monthSchedule.print();

			tboxDutyList.WordWrap = false;

			SwitchButton(false);
		}
		

		// 제작누르면 true, 완성되면 false를 집어넣어 버튼활성화를 바꾸는 함수
		void SwitchButton(bool making)
		{
			if(making)
			{
				lblOnProgress.Visible = true;
				pBarMakeDutyList.Visible = true;

				btnMakeDutyList.Enabled = false;
				btnSaveList.Enabled = false;
				btnCancel.Enabled = false;
			}
			else
			{
				lblOnProgress.Visible = false;
				pBarMakeDutyList.Visible = false;

				btnMakeDutyList.Enabled = true;
				btnSaveList.Enabled = true;
				btnCancel.Enabled = true;
			}
		}

		// 텍스트파일로 저장
		private void btnSaveList_Click(object sender, EventArgs e)
		{
			if(tboxDutyList.Text != null)
			{
				string savePath = thisyear + "-" + thismonth + ".txt";
				File.WriteAllText(savePath, tboxDutyList.Text, Encoding.Default);
			}
		}

		// 취소
		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}
