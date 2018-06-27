using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    class TrangThaiCongViec
    {
        public int ID { get; set; }
        public string TenTrangThai { get; set; }

        public TrangThaiCongViec(int iD, string tenTrangThai)
        {
            ID = iD;
            TenTrangThai = tenTrangThai;
        }
    }
}
