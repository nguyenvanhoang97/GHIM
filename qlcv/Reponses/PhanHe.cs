using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    class PhanHe
    {
        public int ID { get; set; }
        public string TenPhanHe { get; set; }
   
        public PhanHe(int iD, string tenPhanHe)
        {
            ID = iD;
            TenPhanHe = tenPhanHe;
        }
    }
}
