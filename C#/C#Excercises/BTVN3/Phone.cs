using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN3
{
    public class Phone : Product
    {
        public Phone(string name, double price) : base(name, price) { }

        public override double CalculatePrice()
        {
            return (Price * 0.1 ) + Price;
        }
    }
}
