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
    public class Scheduler
    {
        ClientSocket clientsocket;

        private MonthSchedule makeSchedule()
        {
            MonthSchedule result = null;

            List<Nurse> nurseList = null;
            List<Off> offList = null;
            Option option = null;

            

            return result;
        }
    }
}
