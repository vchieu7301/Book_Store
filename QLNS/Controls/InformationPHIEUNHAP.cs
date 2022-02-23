using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Controls
{
    class InformationPHIEUNHAP
    {
        private string strsopn;
        private DateTime dtngaynhap;      
        private int intgianhap;
        private int inttongtien;
        private string strLOAI;

        public InformationPHIEUNHAP()
        {

        }
        public string Strsopn
        {
            get
            {
                return strsopn;
            }

            set
            {
                strsopn = value;
            }
        }

        public DateTime Dtngaynhap
        {
            get
            {
                return dtngaynhap;
            }

            set
            {
                dtngaynhap = value;
            }
        }


        public string StrLOAI
        {
            get
            {
                return strLOAI;
            }

            set
            {
                strLOAI = value;
            }
        }


        public int Intgianhap
        {
            get
            {
                return intgianhap;
            }

            set
            {
                intgianhap = value;
            }
        }

        public int Inttongtien
        {
            get
            {
                return inttongtien;
            }

            set
            {
                inttongtien = value;
            }
        }
    }
}
