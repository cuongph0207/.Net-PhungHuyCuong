using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN3
{
    public class FullTimeEmployee : Employee
    {
        public override double Luong()
        {
            return 2 * LuongCoBan;
        }
    }
}
