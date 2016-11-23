using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseDutyManager
{
    public enum SEX{
        Male,
        Female
    };
    public enum GROUP
    {
        Group1,
        Group2,
        Group3
    };
    public class Nurse : Object
    {
        string name;
        SEX sex;
        string id;
        string pw;
        string licNum;
        string phNum;
        GROUP groupID;
        bool isChief;
        public Nurse(string _info) { }
        public override string ToString()
        {
            string result = null;
            result += name;
            result += ",";
            if (sex == SEX.Male)
            {
                result += "Male";
            }
            else
            {
                result += "Female";
            }
            result += ",";
            result += id;
            result += ",";
            result += pw;
            result += ",";
            result += licNum;
            result += ",";
            result += phNum;
            result += ",";
            if (groupID == GROUP.Group1)
            {

            }
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
