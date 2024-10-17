using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
        }

        public decimal CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }
}
