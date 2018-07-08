using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    public class ParameterBaoCaoTongHopGhim
    {
        public string TuNgay { get; set; }
        public string DenNgay { get; set; }
        public int ID { get; set; }
        public int IDLoaiGhim { get; set; }
        /// <summary>Record Constructor</summary>
        /// <param name="tuNgay"><see cref="TuNgay"/></param>
        /// <param name="denNgay"><see cref="DenNgay"/></param>
        /// <param name="iD"><see cref="ID"/></param>
        /// <param name="iDLoaiGhim"><see cref="IDLoaiGhim"/></param>
        public ParameterBaoCaoTongHopGhim(string tuNgay, string denNgay, int iD, int iDLoaiGhim)
        {
            TuNgay = tuNgay;
            DenNgay = denNgay;
            ID = iD;
            IDLoaiGhim = iDLoaiGhim;
        }
    }
}
