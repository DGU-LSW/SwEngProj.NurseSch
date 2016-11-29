using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseDutyManager
{
    public enum WORK
    {
        D,  //day
        E,  //even
        N,  //night
        O,  //off
        V   //vacum
    };
    /*
     * 작성자 : 이신우
     */
    public class Scheduler
    {
        ClientSocket clientsocket;
        List<Nurse> nurseList = null;
        List<Off> offList = null;
        Option option = null;
        DayOfWeek startWeek;
        int monthLen; //month의 길이

		public Scheduler(ClientSocket clientSocket)
		{
			this.clientsocket = clientSocket;

			nurseList = this.clientsocket.getNurseList();
			offList = this.clientsocket.getOffList();
            option = this.clientsocket.getOption();
		}

        public MonthSchedule makeSchedule()
        {
            MonthSchedule result = new MonthSchedule(nurseList, offList, option, startWeek, monthLen);
            return result;
        }
    }
}
