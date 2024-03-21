using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN3
{
    internal class HinhTron : HinhHoc
    {
        const double PI = Math.PI;
        public double BanKinh { get; set; }
        public override double ChuVi()
        {
            return 2 * PI * BanKinh;
        }

        public override double DienTich()
        {
            return PI * BanKinh * BanKinh;
        }
    }
}
