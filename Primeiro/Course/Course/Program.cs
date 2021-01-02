
using Course.Entities;
using Course.Entities.Enums;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //double sum = 0.0;
            //int n = int.Parse(Console.ReadLine());

            //Product[] vect = new Product[n];

            //for (int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine());

            //    vect[i] = new Product { Name = name, Price = price };
            //    sum += vect[i].Price;
            //}

            //double avg = sum / n;
            //Console.WriteLine(avg.ToString("f2"));

            //Calculator.Sum(new int[] { 2, 3 });
            //Calculator.Sum(new int[] { 2, 4, 3 });

            //Matriz.matriz();

            //Order order = new Order
            //{
            //    Id = 1080,
            //    Moment = DateTime.Now,
            //    Status = OrderStatus.Pending
            //};
            //Console.WriteLine(order);

            //string txt = OrderStatus.Pending.ToString();

            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            //Console.WriteLine(os);
            //Console.WriteLine(txt);

            Console.WriteLine("Enter department`s name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Level");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.WriteLine("Base salary");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How mnay contracts");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contracts data:");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HoursContract contract = new HoursContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year MM/YYYY ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));

        }
    }
}
