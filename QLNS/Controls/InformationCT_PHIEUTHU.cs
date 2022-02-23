using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Controls
{
    class InformationCT_PHIEUTHU
    {
        private string strsopt;
        private string strmakh;
        private int inttienthu;
        private string strLOAI;

        public InformationCT_PHIEUTHU()
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

        public string Strmakh
        {
            get
            {
                return strmakh;
            }

            set
            {
                strmakh = value;
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

        public int Inttienthu
        {
            get
            {
                return inttienthu;
            }

            set
            {
                inttienthu = value;
            }
        }
    }
}
