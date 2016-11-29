using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseDutyManager
{
    /*
     * 작성자 : 이신우
     */
    public class DaySchedule : System.Object
    {
        WORK[] work;
        DayOfWeek week;
        public DaySchedule() { }
        public DaySchedule(int numNurse, int  _week):this()
        {
            work = new WORK[numNurse];
            for(int i = 0; i < work.Count(); i++)
            {
                work[i] = WORK.V;
            }
            _week %= 7;
            switch (_week)
            {
                case 0:
                    week = DayOfWeek.Monday;
                    break;
                case 1:
                    week = DayOfWeek.Tuesday;
                    break;
                case 2:
                    week = DayOfWeek.Wednesday;
                    break;
                case 3:
                    week = DayOfWeek.Thursday;
                    break;
                case 4:
                    week = DayOfWeek.Friday;
                    break;
                case 5:
                    week = DayOfWeek.Saturday;
                    break;
                case 6:
                    week = DayOfWeek.Sunday;
                    break;
            }
        }
        public void setWork(int _index, WORK _work)
        {
            work[_index] = _work;
        }
        public WORK getWork(int _indexNurse)
        {
            return work[_indexNurse];
        }
        public DaySchedule(string _info)
        {
            string[] str = _info.Split('李');
            int i = 0;
            for(i = 0; i < str.Count(); i++)
            {
                if((i + 1) == str.Count())  //i + 1 는 week가 저장
                {
                    break;
                }
                switch (str[i])
                {
                    case "D":
                        work[i] = WORK.D;
                        break;
                    case "E":
                        work[i] = WORK.E;
                        break;
                    case "N":
                        work[i] = WORK.N;
                        break;
                    case "O":
                        work[i] = WORK.O;
                        break;
                    case "V":
                        work[i] = WORK.V;
                        break;
                }
            }
            switch (str[i + 1])
            {
                case "月":
                    week = DayOfWeek.Monday;
                    break;
                case "火":
                    week = DayOfWeek.Tuesday;
                    break;
                case "水":
                    week = DayOfWeek.Wednesday;
                    break;
                case "木":
                    week = DayOfWeek.Thursday;
                    break;
                case "金":
                    week = DayOfWeek.Friday;
                    break;
                case "土":
                    week = DayOfWeek.Saturday;
                    break;
                case "日":
                    week = DayOfWeek.Sunday;
                    break;
            }
        }
        public override string ToString()
        {
            string result = null;
            for (int i = 0; i < work.Count(); i++)
            {
                switch (work[i])
                {
                    case WORK.D:
                        result += "D";
                        break;
                    case WORK.E:
                        result += "E";
                        break;
                    case WORK.N:
                        result += "N";
                        break;
                    case WORK.O:
                        result += "O";
                        break;
                    case WORK.V:
                        result += "V";
                        break;
                }
                result += "李";
            }
            switch (week)
            {
                case DayOfWeek.Monday:
                    result += "月";
                    break;
                case DayOfWeek.Tuesday:
                    result += "火";
                    break;
                case DayOfWeek.Wednesday:
                    result += "水";
                    break;
                case DayOfWeek.Thursday:
                    result += "木";
                    break;
                case DayOfWeek.Friday:
                    result += "金";
                    break;
                case DayOfWeek.Saturday:
                    result += "土";
                    break;
                case DayOfWeek.Sunday:
                    result += "日";
                    break;
            }
                return result;
        }
    }
}
