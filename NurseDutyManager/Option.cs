using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseDutyManager
{
    // 작성자	: 김수희
    // Module	: Option
    // LOC		: 

    public class Option
    {
        int[] monday;   //월
        int[] tuesday;  //화
        int[] wednesday;//수
        int[] thursday; //목
        int[] friday;   //금
        int[] weekend;  //주말
        int[] holiday;  //공휴일

        int group1; //그룹1_나이트근무
        int group2; //그룹2_나이트근무
        int group3; //그룹3_나이트근무

        public Option(string option)
        {
            String[] str = option.Split(',');
            monday[0] = int.Parse(str[0]);
            monday[1] = int.Parse(str[1]);
            monday[2] = int.Parse(str[2]);

            tuesday[0] = int.Parse(str[3]);
            tuesday[1] = int.Parse(str[4]);
            tuesday[2] = int.Parse(str[5]);

            wednesday[0] = int.Parse(str[6]);
            wednesday[1] = int.Parse(str[7]);
            wednesday[2] = int.Parse(str[8]);

            thursday[0] = int.Parse(str[9]);
            thursday[1] = int.Parse(str[10]);
            thursday[2] = int.Parse(str[11]);

            friday[0] = int.Parse(str[12]);
            friday[1] = int.Parse(str[13]);
            friday[2] = int.Parse(str[14]);

            weekend[0] = int.Parse(str[15]);
            weekend[1] = int.Parse(str[16]);
            weekend[2] = int.Parse(str[17]);

            holiday[0] = int.Parse(str[18]);
            holiday[1] = int.Parse(str[19]);
            holiday[2] = int.Parse(str[20]);

            group1 = int.Parse(str[21]);
            group2 = int.Parse(str[22]);
            group3 = int.Parse(str[23]);
        }
        
        public override string ToString()
        {
            string result = null;

            result += monday[0];
            result += ',';
            result += monday[1];
            result += ',';
            result += monday[2];
            result += ',';

            result += tuesday[0];
            result += ',';
            result += tuesday[1];
            result += ',';
            result += tuesday[2];
            result += ',';

            result += wednesday[0];
            result += ',';
            result += wednesday[1];
            result += ',';
            result += wednesday[2];
            result += ',';

            result += thursday[0];
            result += ',';
            result += thursday[1];
            result += ',';
            result += thursday[2];
            result += ',';

            result += friday[0];
            result += ',';
            result += friday[1];
            result += ',';
            result += friday[2];
            result += ',';

            result += weekend[0];
            result += ',';
            result += weekend[1];
            result += ',';
            result += weekend[2];
            result += ',';

            result += holiday[0];
            result += ',';
            result += holiday[1];
            result += ',';
            result += holiday[2];

            result = result.ToString();

            return result;
        }

        public int[] Monday
        {
            get
            {
                return monday;
            }
            set
            {
                monday = value;
            }
        }

        public int[] Tuesday
        {
            get
            {
                return tuesday;
            }
            set
            {
                tuesday = value;
            }
        }

        public int[] Wednesday
        {
            get
            {
                return wednesday;
            }
            set
            {
                wednesday = value;
            }
        }

        public int[] Thursday
        {
            get
            {
                return thursday;
            }
            set
            {
                thursday = value;
            }
        }

        public int[] Friday
        {
            get
            {
                return friday;
            }
            set
            {
                friday = value;
            }
        }

        public int[] Weekend
        {
            get
            {
                return weekend;
            }
            set
            {
                weekend = value;
            }
        }

        public int[] Holiday
        {
            get
            {
                return holiday;
            }
            set
            {
                holiday = value;
            }
        }

        public int Group1
        {
            get
            {
                return group1;
            }
            set
            {
                group1 = value;
            }
        }

        public int Group2
        {
            get
            {
                return group2;
            }
            set
            {
                group2 = value;
            }
        }

        public int Group3
        {
            get
            {
                return group3;
            }
            set
            {
                group3 = value;
            }
        }
    }
}
