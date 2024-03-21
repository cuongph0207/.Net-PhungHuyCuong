using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN3
{
    public class InternEmployee : Employee
    {
        public override double Luong()
        {
            return 1 * LuongCoBan;
        }
    }
}
