using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN3
{
    internal class Book : Product
    {
        public Book(string name, double price) : base(name, price) { }
        public override double CalculatePrice()
        {
            return (Price * 0.05) + Price;
        }
    }
}
