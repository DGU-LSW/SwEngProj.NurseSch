using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NurseDutyManager
{
    /*
     * 작성자 : 이신우
     */
    class ClientSocketTest : ClientSocket
    {
        private static string pathNurse = null;
        private static string pathOff = null;
        private static string pathOption = null;
        private static string pathSchedule = null;

        List<Nurse> nurseList = null;
        List<Off> offList = null;
        public ClientSocketTest()
        {
            nurseList = new List<Nurse>();
            offList = new List<Off>();
        }
        //HDD에 저장된 nurseList를 불러온다.
        private void loadNurse()
        {
            nurseList.Clear();  //메모리 상 nurseList 초기화
            StreamReader sr = new StreamReader(pathNurse);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                nurseList.Add(new Nurse(line)); //line 당 간호사 load
            }
        }
        //HDD에 저장된 offList를 불러온다.
        private void loadOff()
        {
            offList.Clear();    //메모리 상 offList 초기화
            StreamReader sr = new StreamReader(pathOff);
            string line;
            while((line = sr.ReadLine()) != null)
            {
                offList.Add(new Off(line)); //line 당 off load
            }
        }
        //메모리 상의 nurseList를 HDD에 save한다.
        private void saveNurse()
        {
            FileInfo fi = new FileInfo(pathNurse);
            string[] str = new string[nurseList.Count];
            for(int i = 0; i < nurseList.Count; i++)
            {
                str[i] = nurseList[i].ToString();   //str배열 하나당 nurse 1
            }
            if (fi.Exists)
            {
                File.WriteAllLines(pathNurse,str);
            }
        }
        //메모리 상의 offList를 HDD에 save한다.
        private void saveOff()
        {
            FileInfo fi = new FileInfo(pathOff);
            string[] str = new string[offList.Count];
            for(int i =0; i< offList.Count; i++)
            {
                str[i] = offList[i].ToString();
            }
            if (fi.Exists)
            {
                File.WriteAllLines(pathOff, str);
            }
        }
        //메모리 상의 nurseList에서 ID, PW 검사
        //chief는 1, general은 2, 실패는 0
        public override int logIn(string ID, string PW)
        {
            int result = 0;
            int index = 0;
            for(int i =0; i < nurseList.Count; i++)
            {
                if(nurseList[i].ID.Equals(ID))   //id일치 확인
                {
                    if(nurseList[i].Password.Equals(PW)) //pw일치 확인
                    {
                        index = i;
                        result = -1;
                    }
                }
                if(result == -1)
                {
                    if(nurseList[index].IsChiefNurse == true)
                    {
                        return 1;   //chief login
                    }
                    else
                    {
                        return 2;   //general login
                    }
                }
            }
            return 0;
        }
        //HDD에 저장된 offList를 메모리에 다시 load하고 전송한다.
        public override List<Off> getOffList()
        {
            loadOff(); 
            return offList;
        }
        //HDD 상의 offList를 load하고 매개변수의 _offList를 offList에 추가하고 HDD에 save한다.
        public override bool sendOff(List<Off> _offList)
        {
            bool result = false;
            loadOff();
            for(int i =0;i < _offList.Count; i++)
            {
                offList.Add(_offList[i]);
            }
            saveOff();
            return result;
        }
        //HDD 상의 nurseList를 반환한다.
        public override List<Nurse> getNurseList()
        {
            loadNurse();
            return nurseList;
        }
        //메모리 상의 nurseList에서 ID에 해당하는 nurse를 _nurse로 바꾸고 save한다.
        public override bool modifyNurse(string ID, Nurse _nurse)
        {
            for (int i = 0; i < nurseList.Count; i++)
            {
                if (nurseList[i].ID.Equals(ID))
                {
                    nurseList[i] = _nurse;
                    saveNurse();
                    return true;
                }
            }
            return false;
        }
        //HDD의 option을 return 한다.
        public override Option getOption()
        {
            Option result = null;
            StreamReader sr = new StreamReader(pathOption);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                //result = new Option(line);
            }
            return result;
        }
        //매개변수의 option을 save한다.
        public override bool setOption(Option option)
        {
            FileInfo fi = new FileInfo(pathOption);
            string str = option.ToString();
            if (fi.Exists)
            {
                File.WriteAllText(pathOption, str);
            }
            return true;
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
        //메모리의 nurseList에서 ID가 일치하는 nurse를 전송한다.
        //실패시 null
        public override Nurse getNurse(string ID)
        {
            for(int i = 0; i < nurseList.Count; i++)
            {
                if(nurseList[i].ID.Equals(ID))
                {
                    return nurseList[i];
                }
            }
            return null;
        }
        //메모리의 nurseList에서 일치하는 nurse를 반환
        //실패시 null 반환
        public override Nurse ReturnInfo(string name, string lisenceNumber)
        {
            for(int i = 0; i < nurseList.Count; i++)
            {
                if (!nurseList[i].Name.Equals(name))
                {
                    continue;
                }
                else
                {
                    if (nurseList[i].LicenseNum.Equals(lisenceNumber))
                    {
                        return nurseList[i];
                    }
                }
            }
            return null;
        }
        //메모리 상의 nurseList에서 매개변수와 일치하는 nurse를 반환한다.
        public override Nurse ReturnInfo(string id, string name, string lisenceNumber)
        {
            for (int i = 0; i < nurseList.Count; i++)
            {
                if (!nurseList[i].ID.Equals(id))
                {
                    continue;
                }
                else
                {
                    if (nurseList[i].LicenseNum.Equals(lisenceNumber) &&
                        nurseList[i].Name.Equals(name))
                    {
                        return nurseList[i];
                    }
                }
            }
            return null;
        }
    }
}
