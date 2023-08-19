using System;

namespace module6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
            if(department?.City?.Name == "Санкт-Петербург" && department?.Company?.Type == "Банк")
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            var bus = new Bus();
            bus.PrintStatus();
            bus.Load = 5;
            bus.PrintStatus();
        }

        static Department GetCurrentDepartment()
        {
            // logic
            return new Department();
        }
    }
    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if(Load.HasValue)
            {
                Console.WriteLine("В автобусе {0} человек", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст");
            }

        }
    }

}
