using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMAQ
{
    class Vector3
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        public double Z { get; set; } = 0;

        public override string ToString()
        {
            return String.Format("({0},{1},{2})", X, Y, Z);
        }
    }
}
