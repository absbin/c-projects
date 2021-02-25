using System;

namespace static_method
{
    public class Programe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Static method S = "+Circle.ComputeAreaStatic(15));
            Circle cr1=new Circle();
            cr1.Radius=10;
            Console.WriteLine("Ordinary method S = "+cr1.ComputeArea());

            Console.WriteLine("Pi=3");
            Circle.Pi=3;
            Console.WriteLine("Static method S = "+Circle.ComputeAreaStatic(15));
            Console.WriteLine("Ordinary method S = "+cr1.ComputeArea());
        }
    }
    public class Circle
    {
        public static double Pi=3.141;
        public double Radius;
        public static double ComputeAreaStatic(double  r)
        {
            return r*r*Pi;
        }
        public double ComputeArea()
        {
            return Radius*Radius*Pi;
        }

    }
}
