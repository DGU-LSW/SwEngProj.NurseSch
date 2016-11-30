using System;
using System.Collections.Generic;
using System.Linq;

namespace NurseDutyManager
{
    /*
     * 작성자 : 이신우
     */
    public class MonthSchedule : Object
    {
        List<DaySchedule> dayList;
        List<Nurse> nurseList;  //그룹순으로 정렬된 list
        public MonthSchedule(List<Nurse> _nurseList, List<Off> _offList, Option _option,
            DayOfWeek _startWeek, int _monthLength)
        {
            int numNurse = _nurseList.Count; //간호사 수
            int week = 0;

            #region week요일 결정

            switch (_startWeek)//week 요일 결정
            {
                case DayOfWeek.Monday:
                    week = 0;
                    break;
                case DayOfWeek.Tuesday:
                    week = 1;
                    break;
                case DayOfWeek.Wednesday:
                    week = 2;
                    break;
                case DayOfWeek.Thursday:
                    week = 3;
                    break;
                case DayOfWeek.Friday:
                    week = 4;
                    break;
                case DayOfWeek.Saturday:
                    week = 5;
                    break;
                case DayOfWeek.Sunday:
                    week = 6;
                    break;
            }
			#endregion

			#region dayList 메모리 할당

			dayList = new List<DaySchedule>();

			for (int i = 0; i < _monthLength; i++)
            {
				DaySchedule newDay = new DaySchedule(numNurse, week);

				dayList.Add(newDay);
            }
			#endregion

			#region 간호사 정렬

			nurseList = new List<Nurse>();

            for (int i = 0; i < numNurse; i++)//group1 nurse 삽입
            {
                if(_nurseList[i].Group.Equals(GROUP.Group1))
                {
                    nurseList.Add(new Nurse(_nurseList[i]));
                }
            }
            for(int i = 0;i < numNurse; i++)    //group2
            {
                if (_nurseList[i].Group.Equals(GROUP.Group2))
                {
                    nurseList.Add(new Nurse(_nurseList[i]));
                }
            }
            for(int i = 0; i < numNurse; i++)
            {
                if (_nurseList[i].Group.Equals(GROUP.Group3))
                {
                    nurseList.Add(new Nurse(_nurseList[i]));
                }
            }

            #endregion

            #region dayList에 offList 요소 삽입

            for (int i = 0; i < _offList.Count; i++)
            {
                for (int j = 0; j < numNurse; j++)
                {
                    if (_offList[i].NurseID.Equals(nurseList[j].ID))
                    {
                        dayList[_offList[i].Date.Day - 1].setWork(j, WORK.O);
                        //off에 저장된 일의 - 1에 위치한 DaySchedule에 j순번의 nurse 위치에 WORK.O를 저장
                    }
                }
            }
            #endregion
        }
        public MonthSchedule(string _info)
        {
            dayList = new List<DaySchedule>();
            nurseList = new List<Nurse>();
            string[] tmp = _info.Split('~');
            string[] day = tmp[0].Split('-');
            string[] nurse = tmp[1].Split('-');

            for(int i =0;i<day.Count(); i++)
            {
                if (day[i].Equals(""))  //마지막 string이 공백일 경우
                {
                    break;
                }
                dayList.Add(new DaySchedule(day[i]));
            }
            for(int i = 0; i < nurse.Count(); i++)
            {
                if (nurse[i].Equals(""))    //마지막 string이 공백일 경우
                {
                    break;
                }
                nurseList.Add(new Nurse(nurse[i]));
            }
        }
        public override string ToString()
        {
            string result = null;
            for(int i = 0; i < dayList.Count; i++)
            {
                result += dayList[i].ToString();
                result += "-";
            }
            result += "~";  //daylist와nurselist 구분자
            for(int i =0;i < nurseList.Count; i++)
            {
                result += nurseList.ToString();
                result += "-";
            }
            return result;
        }
        public string print()
        {
            string result = null;
            for(int i = 0; i < nurseList.Count; i++)    //간호사 라인
            {
                result += nurseList[i].Name;
                result += "\u0009" + "\u0009";
                for(int j = 0; j < dayList.Count; j++)  //한달 순환
                {
                    result += dayList[j].getWork(i).ToString();
                    result += "\u0009";
                }
                result += "\r\n";
            }
            return result;
        }
    }
}
