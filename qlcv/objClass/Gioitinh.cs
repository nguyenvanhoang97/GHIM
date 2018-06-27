using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.objClass
{
    public class GioiTinh
    {
        public int ID { get; set; }
        public string gt { get; set; }
        public GioiTinh(int iD, string gt)
        {
            ID = iD;
            this.gt = gt;
        }
    }
}
