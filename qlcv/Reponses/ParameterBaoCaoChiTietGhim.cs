using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    public class ParameterBaoCaoChiTietGhim
    {
        public string TuNgay { get; set; }
        public string DenNgay { get; set; }
        public int ID { get; set; }
        /// <summary>Record Constructor</summary>
        /// <param name="tuNgay"><see cref="TuNgay"/></param>
        /// <param name="denNgay"><see cref="DenNgay"/></param>
        /// <param name="iD"><see cref="ID"/></param>
        public ParameterBaoCaoChiTietGhim(string tuNgay = default(string), string denNgay = default(string), int iD = default(int))
        {
            TuNgay = tuNgay;
            DenNgay = denNgay;
            ID = iD;
        }
    }
}
