using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature.Core.Entities
{
    public class Centigrade : Common.Temperature
    {
        public Centigrade()
            :base(Common.ScaleType.Centigrade)
        {
            
        }
    }
}
