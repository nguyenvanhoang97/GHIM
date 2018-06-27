using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    class DuAn
    {
        private string text;

        public int ID { get; set; }
        public string TenDuAn { get; set; }
        public DateTime NgayTao { get; set; } 
        public DuAn()
        {
            
        }
        public DuAn(int iD, string tenDuAn, DateTime ngayTao)
        {
            ID = iD;
            TenDuAn = tenDuAn;
            NgayTao = ngayTao;
        }

        public DuAn(string tenda)
        {
            this.TenDuAn = tenda;
        }
    }
}
