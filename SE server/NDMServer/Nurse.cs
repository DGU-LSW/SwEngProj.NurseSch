using System;

namespace NurseDutyManager
{
    public enum SEX
	{
        Male,
        Female
    };
    public enum GROUP
    {
        Group1,
        Group2,
        Group3
    };
    /*
     * 작성자 : 이신우
     * 
     */
    public class Nurse : Object
    {
        string name;    //1
        SEX sex;        //2
        string id;      //3
        string pw;      //4
        string licNum;  //5
        string phNum;   //6
        GROUP groupID;  //7
        bool isChief;   //8
        public Nurse() { }
        public Nurse(string _info)
        {
            string[] str = _info.Split(',');
            name = str[0];              //1
            if (str[1].Equals("Male"))  //2
            {
                sex = SEX.Male;
            }
            else
            {
                sex = SEX.Female;
            }
            id = str[2];    //3
            pw = str[3];    //4
            licNum = str[4];//5
            phNum = str[5]; //6
            if (str[6].Equals("1")) //7
            {
                groupID = GROUP.Group1;
            }
            else if (str[6].Equals("2"))
            {
                groupID = GROUP.Group2;
            }
            else if (str[6].Equals("3"))
            {
                groupID = GROUP.Group3;
            }

            if (str[7].Equals("True"))  //8
            {
                isChief = true;
            }
            else
            {
                isChief = false;
            }
        }
        public Nurse(Nurse _nurse)
        {
            name = _nurse.name;
            sex = _nurse.sex;
            id = _nurse.id;
            pw = _nurse.pw;
            licNum = _nurse.licNum;
            phNum = _nurse.phNum;
            groupID = _nurse.groupID;
            isChief = _nurse.isChief;
        }
        public override string ToString()
        {
            string result = null;
            result += name; //1
            result += ",";
            if (sex == SEX.Male)    //2
            {
                result += "Male";
            }
            else
            {
                result += "Female";
            }
            result += ",";
            result += id;           //3
            result += ",";
            result += pw;           //4
            result += ",";
            result += licNum;       //5
            result += ",";
            result += phNum;        //6
            result += ",";
            if (groupID == GROUP.Group1)        //7
            {
                result += "1";
            }
            else if(groupID == GROUP.Group2)
            {
                result += "2";
            }
            else if (groupID == GROUP.Group3)
            {
                result += "3";
            }
            result += ",";
            result += isChief.ToString();//8
            return result;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public SEX Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }
        public string ID
        {

            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Password
        {
            get
            {
                return pw;
            }
            set
            {
                pw = value;
            }
        }
        public string LicenseNum
        {
            get
            {
                return licNum;
            }
            set
            {
                licNum = value;
            }
        }
        public string PhoneNum
        {
            get
            {
                return phNum;
            }
            set
            {
                phNum = value;
            }
        }
        public GROUP Group
        {
            get
            {
                return groupID;
            }
            set
            {
                groupID = value;
            }
        }
        public bool IsChiefNurse
        {
            get
            {
                return isChief;
            }
            set
            {
                isChief = value;
            }
        }
    }
}
