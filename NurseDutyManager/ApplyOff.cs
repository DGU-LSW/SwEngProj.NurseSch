﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NurseDutyManager
{
	// 작성자	: 임제희
	// Module	: ApplyOff
	// LOC		: 
	public partial class ApplyOff : Form
	{
		// radio버튼을 눌렀는지
		bool radiobuttonSelected = false;

		// 누른 라디오 버튼. true면 Holiday, false면 Off
		bool selectedRadioButton;
		
        ClientSocket clientsocket;

		List<Off> offList;

		string currentUserID;

		public ApplyOff()
		{
			InitializeComponent();
		}

        public ApplyOff(ClientSocket clientsocket, string currentUserID) : this()
        {
            this.clientsocket = clientsocket;
			this.currentUserID = currentUserID;
        }

		// 휴일 버튼 클릭시
		private void rbtnOff_CheckedChanged(object sender, EventArgs e)
		{
			radiobuttonSelected = true;
			selectedRadioButton = false;
		}

		// 휴가 버튼 클릭시
		private void rbtnHoliday_CheckedChanged(object sender, EventArgs e)
		{
			radiobuttonSelected = true;
			selectedRadioButton = true;
		}

		#region 버튼 이벤트

		// 추가 버튼
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if(radiobuttonSelected)
			{
				DateTime date = monthCalendar1.SelectionStart;
				// selectedOff는 선택한 날짜, twinOff는 selectedOff와 휴일인지 휴가인지만 다른 날짜.
				
				for(int i=0;i<lboxHoliday.Items.Count;i++)
				{
					if (((Off)lboxHoliday.Items[i]).Date.Equals(date))
					{
						MessageBox.Show("이미 선택한 날짜입니다!");

						return;
					}
				}

				Off selectedOff = new Off(date, selectedRadioButton, currentUserID);
				Off twinOff = new Off(date, !selectedRadioButton, currentUserID);

				lboxHoliday.Items.Add(selectedOff);
			}
			
		}

		// 신청버튼
		private void btnSave_Click(object sender, EventArgs e)
		{
			offList = new List<Off>();

			for (int i = 0; i < lboxHoliday.Items.Count; i++)
			{
				offList.Add((Off)lboxHoliday.Items[i]);
			}

			if(clientsocket.sendOff(offList))
			{
				MessageBox.Show("전송 성공!");
			}
			else
			{
				MessageBox.Show("전송 실패!");
			}
		}

		// 취소버튼
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion
	}
}