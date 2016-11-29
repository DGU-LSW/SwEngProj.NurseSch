﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseDutyManager
{

	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ApplyOff());
            //Application.Run(new ChiefMenuForm());
            //Application.Run(new DutyList());
            //Application.Run(new LoginForm());
            //Application.Run(new ManageMemberForm());
            //Application.Run(new ModifyInfoForm());
            //Application.Run(new NightShiftForm());
            //Application.Run(new OffOptionForm());
            //Application.Run(new SignupForm());

            Application.Run(new UI());
		}
	}
}
