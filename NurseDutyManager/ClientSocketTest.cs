using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NurseDutyManager
{
    class ClientSocketTest : ClientSocket
    {
        private static string pathNurse = null;
        private static string pathOff = null;
        private static string pathOption = null;
        private static string pathSchedule = null;
        private void loadNurse()
        {
            StreamReader sr = null;
        }
        private void loadOff()
        {

        }
        public override int logIn(string ID, string PW)
        {
            int result = 0;
            return result;
        }
        public override List<Off> getOffList()
        {
            List<Off> result = null;
            return result;
        }
        public override bool sendOff(List<Off> offList)
        {
            bool result = false;
            return result;
        }

        public override List<Nurse> getNurseList()
        {
            List<Nurse> list = null;
            return list;
        }
        public override bool modifyNurse(string ID, Nurse nurse)
        {
            bool result = false;
            return result;
        }
        public override Option getOption()
        {
            Option result = null;
            return result;
        }
        public override bool setOption(Option option)
        {
            bool result = false;
            return result;
        }

        public override bool sendMonthSchedule(MonthSchedule schedule)
        {
            bool result = false;
            return result;
        }
        public override MonthSchedule getMonthSchedule(string year, string month)
        {
            MonthSchedule result = null;
            return result;
        }
        public override Nurse getNurse(string ID)
        {
            Nurse result = null;
            return result;
        }
        public override Nurse ReturnInfo(string name, string lisenceNumber)
        {
            Nurse result = null;
            return result;
        }
        public override Nurse ReturnInfo(string id, string name, string lisenceNumber)
        {
            Nurse result = null;
            return result;
        }
    }
}
