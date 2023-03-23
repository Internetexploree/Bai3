using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Le Phu Qui
            Console.Write("Nhap duong kinh: ");
            float duongKinh = float.Parse(Console.ReadLine());
            const double PI = 3.14;
            float banKinh = duongKinh/2;
            double chuVi = duongKinh * PI;
            double dienTich = Math.Pow(duongKinh,2)/4*PI;
            Console.WriteLine("Ban kinh cua hinh tron la: {0}", banKinh);
            Console.WriteLine("Dien tich cua hinh tron la: {0}", dienTich);
            Console.WriteLine("Chu vi cua hinh tron la: {0}", chuVi);
            Console.ReadKey();
        }
    }
}
