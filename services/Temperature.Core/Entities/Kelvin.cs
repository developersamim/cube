using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature.Core.Entities
{
    public class Kelvin : Common.Temperature 
    {
        public Kelvin()
            :base(Common.ScaleType.Kelvin)
        {

        }
    }
}
