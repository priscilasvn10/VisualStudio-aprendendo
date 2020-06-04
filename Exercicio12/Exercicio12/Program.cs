using System;
using Exercicio12.Entidades.Enums;
using Exercicio12.Entidades;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dp = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
           
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine());


            Department dep = new Department(dp);
            Worker worker = new Worker(name, level, salary, dep);



            Console.Write("How many contracts to this worker?");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {

                Console.WriteLine("Enter #"+(i+1)+" contract data:");
                Console.Write("Date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours):");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value, hours);

                worker.AddContract(contract);

            }

            Console.WriteLine();     
            
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY):");
            string monthAndYears = Console.ReadLine();
            int month = int.Parse(monthAndYears.Substring(0, 2));
            int year = int.Parse(monthAndYears.Substring(3));

            Console.WriteLine();

            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for "+ monthAndYears+": R$ "+ worker.Income(year, month));


            
        }
    }
}
