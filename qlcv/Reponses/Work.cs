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
        public string Hangmuc { get; set; }
        public string Mota { get; set; }
        public DateTime Ngaybatdau { get; set; }
        public DateTime Ngayhoanthanh { get; set; }
        public int Nguoithuchien { get; set; }
        public string Nguoiyeucau { get; set; }
        public string Phanhe { get; set; }
        public string Status { get; set; }
        public string TenDuAn { get; set; }
        public Work(DateTime deadline, int iD, string hangmuc, string mota, DateTime ngaybatdau, DateTime ngayhoanthanh, int nguoithuchien, string nguoiyeucau, string phanhe, string status, string tenDuAn)
        {
            Deadline = deadline;
            ID = iD;
            Hangmuc = hangmuc;
            Mota = mota;
            Ngaybatdau = ngaybatdau;
            Ngayhoanthanh = ngayhoanthanh;
            Nguoithuchien = nguoithuchien;
            Nguoiyeucau = nguoiyeucau;
            Phanhe = phanhe;
            Status = status;
            TenDuAn = tenDuAn;
        }
    }
}
