using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class HinhChuNhat : ITinhToan
    {
        double dai;
        double rong;

        public HinhChuNhat()
        {

        }

        public HinhChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public double ChuVi()
        {
            return (dai + rong) * 2;
        }

        public double DienTich()
        {
            return dai * rong;
        }
    }
}
