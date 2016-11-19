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
    class Nurse
    {
        private string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        private SEX Sex
        {
            get
            {
                return Sex;
            }
            set
            {
                Sex = value;
            }
        }
        private string ID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        private string Password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        private string LicenseNum
        {
            get
            {
                return LicenseNum;
            }
            set
            {
                LicenseNum = value;
            }
        }
        private string PhoneNum
        {
            get
            {
                return PhoneNum;
            }
            set
            {
                PhoneNum = value;
            }
        }
        private bool IsChiefNurse
        {
            get
            {
                return IsChiefNurse;
            }
            set
            {
                IsChiefNurse = value;
            }
        }
    }
}
