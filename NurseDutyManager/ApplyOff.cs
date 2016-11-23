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
	public partial class ApplyOff : Form
	{
		DateTime today = DateTime.Today;
		int thisyear;
		int thismonth;
		Panel[] panelList;

        ClientSocket clientsocket;

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
		}

        public ApplyOff(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
        }

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

		// 신청버튼
		private void button2_Click(object sender, EventArgs e)
		{

		}

		// 취소버튼
		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void printCalendar(int year, int month)
		{
			DateTime thismonth = new DateTime(year, month, 1);

			int day = (int)thismonth.DayOfWeek;
			int date = 1;
			int row = 1;
			int col = 0;
			
			for(int i = 0; i < day; i++) { col++;}

			panelList = new Panel[DateTime.DaysInMonth(year, month)];
			
			while (date <= DateTime.DaysInMonth(year, month))
			{
				tableLayoutPanel1.Controls.Add(panelList[date-1] = new Panel(), col, row);
				panelList[date - 1].Controls.Add(new Label() { Text = date.ToString() });

				col++;
				day++;
				date++;

				if(day % 7 == 0)
				{
					day = 0;
					col = 0;
					row++;
				}
			}
		}
	}
}