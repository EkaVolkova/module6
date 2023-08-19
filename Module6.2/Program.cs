using System;

namespace Module6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Pen
    {
        public string color;
        public int cost;
        public Pen()
        {
            color = "Черный";
            cost = 100;
        }
        public Pen(string color, int cost)
        {
            this.color = color;
            this.cost = cost;
        }
    }
    class Rectangle
    {
        public int a;
        public int b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Rectangle(int a)
        {
            this.a = a;
            b = a;
        }
        public Rectangle()
        {
            a = 6;
            b = 4;
        }
        public int Square()
        {
            return a * b;
        }
    }

}
