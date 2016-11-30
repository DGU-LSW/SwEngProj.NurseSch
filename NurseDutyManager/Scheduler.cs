using System;
using System.Collections.Generic;
/*
 * 작성: 이신우
 * Module: Scheduler
 * LOC: 46
 */
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
    public class Scheduler
    {
        ClientSocket clientsocket;
        List<Nurse> nurseList = null;
        List<Off> offList = null;
        Option option = null;
		DateTime date;
        DayOfWeek startWeek;
        int monthLen; //month의 길이

		public Scheduler(ClientSocket clientsocket, List<Nurse> nurseList, List<Off> offList, Option option, DateTime date)
		{
			this.clientsocket = clientsocket;
			this.nurseList = nurseList;
			this.offList = offList;
			this.option = option;
			this.date = date;

			startWeek = (new DateTime(date.Year, date.Month, 1)).DayOfWeek;
			monthLen = DateTime.DaysInMonth(date.Year, date.Month);
		}

        public MonthSchedule makeSchedule()
        {
            MonthSchedule result = new MonthSchedule(nurseList, offList, option, startWeek, monthLen);
            return result;
        }
    }
}