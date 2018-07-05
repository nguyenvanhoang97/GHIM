using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    public class WorkV2
    {

        public int ID { get; set; }
        public DateTime Deadline { get; set; }
        public string HangMuc { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayBatDau { get; set; }
        public string NguoiThucHien { get; set; }
        public string NguoiYeuCau { get; set; }
        public string PhanHe { get; set; }
        public string Status { get; set; }
        public string TenDuAn { get; set; }
        public object NgayHoanThanh { get; set; }
    }
}
