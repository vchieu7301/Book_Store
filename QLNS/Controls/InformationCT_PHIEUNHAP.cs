using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Controls
{
    class InformationCT_PHIEUNHAP
    {
        private string strsopn;
        private int intsoluong;
        private string strmasach;
        private string strmanv;
        private string strLOAI;

        public InformationCT_PHIEUNHAP()
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

        public int Intsoluong
        {
            get
            {
                return intsoluong;
            }

            set
            {
                intsoluong = value;
            }
        }

        public string Strmasach
        {
            get
            {
                return strmasach;
            }

            set
            {
                strmasach = value;
            }
        }
        public string Strmanv
        {
            get
            {
                return strmanv;
            }

            set
            {
                strmanv = value;
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
