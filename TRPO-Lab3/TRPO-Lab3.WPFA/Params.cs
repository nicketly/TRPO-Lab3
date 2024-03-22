using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.WPFA
{
    public class Params
    {
        public double Length { set; get; }
        public double Height { set; get; }

        public double Volume;
        public double Result
        {
            get { return FormulaLib.Pyramid_Reg4_Volume(this.Length, this.Height); }
            set { Volume = value; }
        }
    }
}
