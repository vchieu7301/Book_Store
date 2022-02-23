using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Controls
{
    class InformationPHIEUTHU
    {
        private string strsopt;
        private DateTime dtngaythu;
        private string strLOAI;

        public InformationPHIEUTHU()
        {

        }
        public string Strsopt
        {
            get
            {
                return strsopt;
            }

            set
            {
                strsopt = value;
            }
        }

        public DateTime Dtngaythu
        {
            get
            {
                return dtngaythu;
            }

            set
            {
                dtngaythu = value;
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
