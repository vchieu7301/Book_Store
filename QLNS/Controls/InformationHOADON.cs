using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Controls
{
    class InformationHOADON
    {
        private string strsohd;
        private DateTime dtngaylap;               
        private int intdongia;
        private int inttongtien;
        private string strLOAI;

        public InformationHOADON()
        {

        }
        public string Strsohd
        {
            get
            {
                return strsohd;
            }

            set
            {
                strsohd = value;
            }
        }

        public DateTime Dtngaylap
        {
            get
            {
                return dtngaylap;
            }

            set
            {
                dtngaylap = value;
            }
        }

        

        public int Intdongia
        {
            get
            {
                return intdongia;
            }

            set
            {
                intdongia = value;
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

        
    }
}
