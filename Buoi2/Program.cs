using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat(2, 3);
            HinhTron ht = new HinhTron(5);

            Console.WriteLine("Hinh chu nhat: Chu vi: " + hcn.ChuVi() + " Dien tich: " + hcn.DienTich());
            Console.WriteLine("Hinh trong: Chu vi: " + ht.ChuVi() + " Dien tich: " + ht.DienTich());
        }
    }
}
