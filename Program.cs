using System;

namespace NestedClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            OuterClass OC = new OuterClass();
            OC.print(50);
            OuterClass.InnerClass ocic = new OuterClass.InnerClass();
            ocic.show(30,80);
        }
    }
    public class OuterClass
    {
        public int a;
        public int b;
        public void print(int a)
        {
            this.a = a;
            Console.WriteLine("This is outter class");
            Console.WriteLine("Value of A :" + a);
        }
        public class InnerClass
        {
            OuterClass oc = new OuterClass();
            public void show(int a, int b)
            {
                oc.a = a;
                oc.b = b;
                int c = oc.a + oc.b;
                Console.WriteLine("This is inner class");
                Console.WriteLine("adition of a aaand b :" + c);
            }
            
        }
    }
}
