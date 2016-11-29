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
	// 작성자	: 임제희
	// Module	: ApplyOff
	// LOC		: 
	public partial class ApplyOff : Form
	{
		Color radiobuttonSelected;

		DateTime today = DateTime.Today;
		int thisyear;
		int thismonth;
		Panel[] panelList;

        ClientSocket clientsocket;

		List<Off> offList;

		string currentUserID;

		public ApplyOff()
		{
			InitializeComponent();

			thisyear = today.Year;
			thismonth = today.Month;

			for (int i=0;i<3;i++)
			{
				comboBox1.Items.Add(thisyear + i);
			}

			comboBox1.SelectedIndex = comboBox1.Items.IndexOf(thisyear);

			comboBox2.Items.Clear();

			for (int i=thismonth;i<=12;i++)
			{
				comboBox2.Items.Add(i);
			}

			label4.Text = "일";
			label5.Text = "월";
			label6.Text = "화";
			label7.Text = "수";
			label8.Text = "목";
			label9.Text = "금";
			label10.Text = "토";

			// test
			currentUserID = "1";
			clientsocket = new ClientSocket();
		}

        public ApplyOff(ClientSocket clientsocket, string currentUserID) : this()
        {
            this.clientsocket = clientsocket;
			this.currentUserID = currentUserID;
        }

		// 연도 바꿀때.
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBox1.SelectedIndex != 0)
			{
				comboBox2.Items.Clear();

				for (int i=1;i<=12;i++)
				{
					comboBox2.Items.Add(i);
				}
			}

			else
			{
				comboBox2.Items.Clear();

				for (int i = thismonth; i <= 12; i++)
				{
					comboBox2.Items.Add(i);
				}
			}
		}

		// 조회 누를때
		private void button1_Click(object sender, EventArgs e)
		{
			if (panelList != null)
			{
				for (int i = 0; i < panelList.Length; i++)
				{
					panelList[i].Dispose();
				}
			}

			int year = (int)comboBox1.SelectedItem;
			int month = (int)comboBox2.SelectedItem;

			DateTime calendar = new DateTime(year, month, 1);

			printCalendar(calendar.Year, calendar.Month);
		}

		// 조교한테 물어볼것
		// TableLayoutPanel에 동적생성한 panel에 반복문으로 클릭 이벤트를 추가했는데 안되는 경우
		private void printCalendar(int year, int month)
		{
			DateTime thismonth = new DateTime(year, month, 1);

			int day = (int)thismonth.DayOfWeek;
			int date = 1;
			int row = 1;

			panelList = new Panel[DateTime.DaysInMonth(year, month)];
			
			while (date <= DateTime.DaysInMonth(year, month))
			{
				panelList[date - 1] = new Panel();
				panelList[date - 1].Controls.Add(new Label() { Text = date.ToString() });
				panelList[date - 1].BackColor = Color.Empty;
				panelList[date - 1].Click += panelClick;

				tableLayoutPanel1.Controls.Add(panelList[date-1], day, row);
				day++;
				date++;

				if(day % 7 == 0)
				{
					day = 0;
					row++;
				}
			}

			tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
		}

		private void panelClick(object sender, EventArgs e)
		{
			if(radiobuttonSelected == Color.Red)
			{
				((Panel)sender).BackColor = System.Drawing.Color.Red;
			}
			else if(radiobuttonSelected == Color.Blue)
			{
				((Panel)sender).BackColor = System.Drawing.Color.Blue;
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			radiobuttonSelected = Color.Red;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			radiobuttonSelected = Color.Blue;
		}

		#region 신청 취소 버튼

		// 신청버튼
		private void button2_Click(object sender, EventArgs e)
		{
			offList = new List<Off>();

			for (int i=0;i<panelList.Length;i++)
			{
				if(panelList[i].BackColor == Color.Red)
				{
					offList.Add(new Off(thisyear.ToString() + "," + thismonth + "," + (i+1).ToString() + ",True," + currentUserID));
				}
				else if(panelList[i].BackColor == Color.Blue)
				{
					offList.Add(new Off(thisyear.ToString() + "," + thismonth + "," + (i + 1).ToString() + ",False," + currentUserID));
				}
			}

			if(offList.Count != 0)
			{
				clientsocket.sendOff(offList);
			}
		}

		// 취소버튼
		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion
	}
}