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
    public class Off
    {
        DateTime date;
        bool isHolidayOff;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public bool IsHolidayOff
        {
            get
            {
                return isHolidayOff;
            }
            set
            {
                isHolidayOff = value;
            }
        }
    }
}
