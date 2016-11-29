using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseDutyManager
{
    public class MonthSchedule : System.Object
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
            for (int i = 0; i < _monthLength; i++)
            {
                dayList.Add(new DaySchedule(numNurse, week));
            }
            #endregion
            #region 간호사 정렬
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
        public override string ToString()
        {
            string result = null;
            for(int i = 0; i < nurseList.Count; i++)    //간호사 라인
            {
                result += nurseList[i].Name;
                result += "\u0009" + "/u0009";
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
