using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature.Core.Entities
{
    public class Fahrenheit : Common.Temperature
    {
        public Fahrenheit()
            :base(Common.ScaleType.Fahrenheit)
        { }
    }
}
