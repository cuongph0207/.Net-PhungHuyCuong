using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN3
{
    public class HinhChuNhat : HinhHoc
    {
        public double ChieuDai {  get; set; }
        public double ChieuRong { get; set; }
        public override double ChuVi()
        {
            return (ChieuDai+ChieuRong)*2;
        }

        public override double DienTich()
        {
            return ChieuDai * ChieuRong;
        }
    }
}
