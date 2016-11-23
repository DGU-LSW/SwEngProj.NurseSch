using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseDutyManager
{
    enum SEX{
        Male,
        Female
    };
    public class Nurse
    {
        string name;
        SEX sex;
        string id;
        string pw;
        string licNum;
        string phNum;
        bool isChief;
        private string Name
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
        private SEX Sex
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
        private string ID
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
        private string Password
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
        private string LicenseNum
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
        private string PhoneNum
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
        private bool IsChiefNurse
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
