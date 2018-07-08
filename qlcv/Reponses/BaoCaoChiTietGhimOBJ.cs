using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    public class BaoCaoChiTietGhimOBJ
    {
        public int ID { get; set; }
        public int IdHangMuc { get; set; }
        public string LyDo { get; set; }
        public int SoGhim { get; set; }
        public DateTime NgayTao { get; set; }
        public int IdUserTao { get; set; }
        public int IdUserNhan { get; set; }
        public int IdLoaiGhim { get; set; }
        public string HangMuc { get; set; }
        public string MoTa { get; set; }
        public string Name { get; set; }
        public string TenLoai { get; set; }
        public int Tien { get; set; }
        public DateTime ThoiGianHoanThanh { get; set; }
    }
}
