using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    public class LocOBJ
    {
        public string Start { get; set; }
        public string End { get; set; }
        /// <summary>Record Constructor</summary>
        /// <param name="start"><see cref="Start"/></param>
        /// <param name="end"><see cref="End"/></param>
        public LocOBJ(string start, string end)
        {
            Start = start;
            End = end;
        }
    }
}
