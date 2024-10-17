using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee instance
            Console.WriteLine("Employee");
            Employee emp1 = new Employee
            {
                Name = "John Doe",
                Age = 30,
                Salary = 50000
            };
            emp1.DisplayDetails();
            Console.WriteLine($"Annual Salary: {emp1.CalculateAnnualSalary()}");

            // Create a BankAccount instance
            Console.WriteLine("BankAccount");
            BankAccount acc1 = new BankAccount
            {
                AccountNumber = "12345",
                AccountHolderName = "Jane Smith",
                /*                Balance = 1000
                */
            };
            acc1.DisplayAccountDetails();
            acc1.Deposit(500);
            acc1.DisplayAccountDetails();
            acc1.Withdraw(200);
            acc1.DisplayAccountDetails();

            // Test MathHelper class
            Console.WriteLine("MathHelper class");
            Console.WriteLine("Enter the size of the array:");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] numbers = new int[sizeOfArray]; // Create an array of the specified size

            Console.WriteLine($"Enter {sizeOfArray} numbers:");

            for (int i = 0; i < sizeOfArray; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); // Read each number into the array
            }
            double average = MathHelper.CalculateAverage(numbers);
            Console.WriteLine($"Average of numbers: {average}");



            Car myCar = new Car();
            myCar.StartEngine();
            myCar.StopEngine();







            k newK = new k();
            newK.xyz();


            String exit = Console.ReadLine();
            if (exit == "exit")
            {
                Console.WriteLine("Thankyou Madam");
            }

        }
    }
    public class k
    {
        public void xyz()
        {
            Console.WriteLine("test");
        }
    }
}
