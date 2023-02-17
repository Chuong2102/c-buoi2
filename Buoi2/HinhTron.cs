using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class HinhTron : TinhToan
    {
        double banKinh;

        public HinhTron()
        {

        }

        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }

        public override double ChuVi()
        {
            return Math.PI * 2 * banKinh;
        }

        public override double DienTich()
        {
            return Math.PI * banKinh * banKinh;
        }
    }
}
