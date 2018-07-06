using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    public class LocOBJ
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        /// <summary>Record Constructor</summary>
        /// <param name="start"><see cref="Start"/></param>
        /// <param name="end"><see cref="End"/></param>
        public LocOBJ(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }
    }
}
