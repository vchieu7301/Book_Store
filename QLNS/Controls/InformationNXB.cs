using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Controls
{
    class InformationNXB
    {
        private string strmanxb;
        private string strtennxb;
        private string strdiachi;
        private string strLOAI;

        public InformationNXB()
        {

        }

        public string Strmanxb
        {
            get
            {
                return strmanxb;
            }

            set
            {
                strmanxb = value;
            }
        }

        public string Strtennxb
        {
            get
            {
                return strtennxb;
            }

            set
            {
                strtennxb = value;
            }
        }

        public string Strdiachi
        {
            get
            {
                return strdiachi;
            }

            set
            {
                strdiachi = value;
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
