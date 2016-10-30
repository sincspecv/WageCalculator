using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HOURLY WAGE CALCULATOR v0.1");
            Console.WriteLine("by Matthew Schroeter https://github.com/sincspecv \n");

            Salary salary = new Salary();

            Console.Write("What is your hourly wage? $");
            string wageInput = Console.ReadLine();
            double wage = Convert.ToDouble(wageInput);
            salary.HourlyWage = wage;

            Console.Write("How many hours do you work per week? ");
            string hoursInput = Console.ReadLine();
            double hours = Convert.ToDouble(hoursInput);
            salary.Hours = hours;

            double weeklySalary = salary.GetWagePerWeek();
            Console.WriteLine("You make {0} per week.", weeklySalary.ToString("C2"));

            double yearlySalary = salary.GetWagePerYear();
            Console.WriteLine("You make {0} per year.", yearlySalary.ToString("C2"));

        }

    }
}
