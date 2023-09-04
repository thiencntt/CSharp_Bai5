using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intA, intB, intC;
            double delta, x1, x2;
            Console.WriteLine(" ----------- CHUONG TRINH GIAI PHUONG TRINH BAC 2 ----------- ");
            Console.WriteLine(" --------------------- aX^2 + bX + c = 0 --------------------- ");
            Console.Write("Nhap a: ");
            intA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            intB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            intC = Convert.ToInt32(Console.ReadLine());

            // Nếu A = 0 thì phương trình bậc 2 trở thành phương trình bậc 1, tiến hành giải phương trình bậc 1 với bX + c = 0
            if (intA == 0)
            {
                giaiPTbac1(intB, intC);
            } else
            {
                delta = (double)Math.Pow(intB,2) - 4*intA*intC;
                Console.WriteLine("Delta = {0}", delta);
                if (delta < 0)
                {
                    // phương trình đã cho vô nghiệm.
                    Console.WriteLine("Phuong trinh VO NGHIEM");
                }
                if (delta == 0)
                {
                    // phương trình có nghiệm kép x=-b/2a
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", (double)(-intB/(2*intA)));
                }
                if (delta > 0)
                {
                    // phương trình có 2 nghiệm phân biệt.
                    x1 = (double)(-intB + Math.Sqrt(delta)) / (2 * intA);
                    x2 = (double)(-intB - Math.Sqrt(delta)) / (2 * intA);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet la x1 = {0} va x2 = {1}", x1, x2);
                }
            }
            Console.ReadKey();
        }

        static void giaiPTbac1(int intA, int intB)
        {
            Console.WriteLine("Do a = 0 nen giai theo phuong trinh bac 1 doi voi bX + c = 0");
            if (intA == 0 && intB == 0)
            {
                Console.WriteLine(" Phuong trinh co vo so nghiem");
            }
            else if (intA == 0 && intB != 0)
            {
                Console.WriteLine(" Phuong trinh vo nghiem");
            }
            else
            {
                Console.WriteLine(" Phuong trinh co 1 nghiem duy nhat x = {0}", (double)-intB / intA);
            }
        }
    }
}
