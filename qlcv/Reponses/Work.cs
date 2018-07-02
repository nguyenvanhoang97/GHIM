using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    class Work
    {
      

        public DateTime Deadline { get; set; }
        public int ID { get; set; }
        public string HangMuc { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayBatDau { get; set; }
        //public DateTime Ngayhoanthanh { get; set; }
        public int NguoiThucHien { get; set; }
        public string NguoiYeuCau { get; set; }
        public string PhanHe { get; set; }
        public string NameNguoiThucHien { get; set; }
        public string Status { get; set; }
        public string TenDuAn { get; set; }
        public Work(DateTime deadline, int iD, string hangmuc, string mota, DateTime ngaybatdau, /*DateTime ngayhoanthanh*/ int nguoithuchien, string nguoiyeucau, string phanhe, string status, string tenDuAn)
        {
            Deadline = deadline;
            ID = iD;
            HangMuc = hangmuc;
            MoTa = mota;
            NgayBatDau = ngaybatdau;
            //Ngayhoanthanh = ngayhoanthanh;
            NguoiThucHien = nguoithuchien;
            NguoiYeuCau = nguoiyeucau;
            PhanHe = phanhe;
            Status = status;
            TenDuAn = tenDuAn;
        }
       

        public Work()
        {

        }
    }
}
