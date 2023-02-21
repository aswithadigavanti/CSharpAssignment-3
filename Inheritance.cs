using System;

namespace Inheitance
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingExecutive m = new MarketingExecutive();
            Console.WriteLine("Enter Employee Number: ");
            m.EmpNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            m.EmpName = Console.ReadLine();

            Console.Write("Enter Employee salary: ");
            m.Salary = int.Parse(Console.ReadLine());
            m.PrintDetails();
            Console.WriteLine("Enter Kilometers travelled");
            int n = Convert.ToInt32(Console.ReadLine());
            m.KT = n;
            m.TeA = 1000;
            m.CalculateSalary();
        }
    }
}