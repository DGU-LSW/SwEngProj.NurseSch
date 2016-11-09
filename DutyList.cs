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
	public partial class DutyList : Form
	{
		DateTime today = DateTime.Today;
		int thisyear;
		int thismonth;
		int timerCount=0;

		#region 프로그레스바 테스트
		// 프로그레스바 테스트용 임시변수
		Timer timer;
		#endregion

		public DutyList()
		{
			InitializeComponent();

			thisyear = today.Year;
			thismonth = today.Month;

			for (int i = 0; i < 3; i++)
			{
				comboBox1.Items.Add(thisyear + i);
			}

			comboBox1.SelectedIndex = comboBox1.Items.IndexOf(thisyear);

			comboBox2.Items.Clear();

			for (int i = thismonth; i <= 12; i++)
			{
				comboBox2.Items.Add(i);
			}

			#region 프로그레스 바 테스트용

			// 프로그레스바 테스트용 임시변수
			timer = new Timer();

			timer.Interval = 500;
			timer.Tick += new EventHandler(timer_Tick);

			#endregion
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex != 0)
			{
				comboBox2.Items.Clear();

				for (int i = 1; i <= 12; i++)
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
			if(comboBox2.SelectedItem == null)
			{
				MessageBox.Show("몇월 근무표를 만들지 선택해주십시오!", "알림");
			}
			else
			{
				label3.Visible = true;
				progressBar1.Visible = true;

				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;

				timer.Start();
			}
		}

		#region 프로그레스바 테스트3
		//프로그레스바 테스트용
		void timer_Tick(object sender, EventArgs e)
		{
			// 한 스텝 이동
			progressBar1.PerformStep();

			// 타이머 중지 조건
			if (++timerCount == 10)
			{
				timer.Stop();
			}
		}
		#endregion

		// 엑셀 파일로 저장
		private void button2_Click(object sender, EventArgs e)
		{

		}

		// 취소
		private void button3_Click(object sender, EventArgs e)
		{

		}
	}
}
