using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseDutyManager
{
    public class DaySchedule
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
    }
}
