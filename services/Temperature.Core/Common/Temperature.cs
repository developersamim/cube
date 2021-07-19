using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature.Core.Common
{
    public abstract class Temperature
    {
        public double Value { get; set; }

        public ScaleType Type { get; set; }

        public Temperature(ScaleType type)
        {
            Type = type;
        }
    }
}
