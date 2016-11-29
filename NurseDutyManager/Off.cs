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
    public class Off : Object
    {
        DateTime date;
        bool isHolidayOff;
        string nurseID;
        public Off(string _info)
        {
            string[] str = _info.Split(',');
            date = new DateTime(int.Parse(str[0]), int.Parse(str[1]), int.Parse(str[2]));
            if (str[3].Equals("True"))
            {
                isHolidayOff = true;
            }
            else
            {
                isHolidayOff = false;
            }
            nurseID = str[4];
        }
        public override string ToString()
        {
            string result = null;
            result += date.Year.ToString();
            result += ",";
            result += date.Month.ToString();
            result += ",";
            result += date.Day.ToString();
            result += ",";
            result += isHolidayOff.ToString();
            result += ",";
            result += nurseID;
            return result;
        }
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
