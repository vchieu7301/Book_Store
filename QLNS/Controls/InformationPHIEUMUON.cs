using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Controls
{
    class InformationPHIEUMUON
    {
        private string strsopm;
        private DateTime dtngaymuon;
        private DateTime dtngaytra;
        private string strLOAI;
        
        public InformationPHIEUMUON()
        {

        }

        public string Strsopm
        {
            get
            {
                return strsopm;
            }

            set
            {
                strsopm = value;
            }
        }

        public DateTime Dtngaymuon
        {
            get
            {
                return dtngaymuon;
            }

            set
            {
                dtngaymuon = value;
            }
        }

        public DateTime Dtngaytra
        {
            get
            {
                return dtngaytra;
            }

            set
            {
                dtngaytra = value;
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
