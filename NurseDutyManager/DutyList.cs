using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

		string message;

		// 서버로부터 리턴받을 간호사 리스트. 간호사 전원의 리스트.
		List<Nurse> nurseList;
		List<Off> offList;
		int numbOfNurse; // 간호사의 숫자

		char[,] dutyCharList;

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


			//clientsocket = new ClientSocket();

			//nurseList = clientsocket.getNurseList();


			pBarMakeDutyList.Value++;

			// 프로그레스바 pBarMakeDutyList는 getNurseList가 끝나면 1, 간호사 근무표가 한줄 완성될때마다 1씩 늘어난다.
			// 완전히 다 늘어나면 표의 visible=true을 한다

			// 표 생성 버튼을 누르면 scheduler 객체의 메소드 MakeSchedule()를 호출하고,
			// 이 클래스의 멤버 monthSchedule에 참조를 저장한다. 그리고 텍스트박스에 tostring값을 저장한다.
			// monthSchedule = scheduler.MakeSchedule();
			// tboxDutyList.Text = monthSchedule.ToString();

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

		// 서버에 저장
		// monthSchedule에 저장된 참조값을 서버로 보낸다.
		private void btnSaveList_Click(object sender, EventArgs e)
		{
			if(clientsocket.sendMonthSchedule(monthSchedule))
			{
				MessageBox.Show("서버에 저장 성공!");
			}
			else
			{
				MessageBox.Show("서버저장 실패!");
			}
		}

		// 취소
		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}
