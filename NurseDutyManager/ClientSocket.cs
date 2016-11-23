using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseDutyManager
{
    public class ClientSocket
    {
        //ID, PW를 보내서 로그인 시도
        //0은 실패, 1은 chief, 2는 general
        public int logIn(string ID, string PW)
        {
            int result = 0;
            return result;
        }

        //서버에 저장된 Off 목록을 가지고 온다.
        public List<Off> getOffList()
        {
            List<Off> result = null;
            return result;
        }

        //신청할 off를 서버로 보낸다.
        //성공이면 true 실패면 false
        public bool sendOff(Off off)
        {
            bool result = false;
            return result;
        }

        //서버에 있는 nurse 목록을 가지고 온다.
        public List<Nurse> getNurseList()
        {
            List<Nurse> list = null;
            return list;
        }

        //ID에 해당하는 nurse 정보를 가지고 온다.
        public Nurse getNurse(string ID)
        {
            Nurse result = null;
            return result;
        }

        //개인정보 수정한 것을 서버로 보낸다.
        //성공하면 true 실패하면 false
        public bool modifyNurse(string ID, Nurse nurse)
        {
            bool result = false;
            return result;
        }
        
        //서버에 있는 option을 가지고 온다.
        public Option getOption()
        {
            Option result = null;
            return result;
        }
        
        //서버에 option을 저장한다.
        //성공하면 true 실패하면 false
        public bool setOption(Option option)
        {
            bool result = false;
            return result;
        }

        //서버에 schedule을 보낸다.
        //성공하면 true 실패하면 false
        public bool sendMonthSchedule(MonthSchedule schedule)
        {
            bool result = false;
            return result;
        }

        //서버에 있는 schedule를 가지고 온다.
        //ex) year = 2016 month = 03
        public MonthSchedule getMonthSchedule(string year, string month)
        {
            MonthSchedule result = null;
            return result;
        }
    }
}
