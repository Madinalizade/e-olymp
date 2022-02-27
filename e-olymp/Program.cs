using System;

namespace e_olymp
{
    class Program
    {
        static void Main(string[] args)
        {
            //9423
            /* double x=double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
          double c = Math.Sqrt(Math.Abs(x));
            double a = Math.Pow(c, 4) + Math.Pow(k, 3);
            double y = Math.Pow(Math.Log10(a), 3) + Math.Pow(Math.Cos(x), 5);
            Console.WriteLine("{0:F2}",y);*/
            //9636
            double[] nums = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
             double a = nums[0];
             double b = nums[1];
            double c = nums[2];
             Console.Write(a*b*c+" "+2*(a*b+b*c+a*c));
            //8803
           /* int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n+1);*/
            //8804
           /* int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x-y);*/
        }
    }
}
