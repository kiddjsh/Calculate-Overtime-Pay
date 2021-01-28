using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_iLabW3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            const double mTaxRate = .15;
            const double sTaxRate = .22;
            const double dTaxRate = .23;
            const double wTaxRate = .13;
            const double overtimeRate = 1.5;
            double payRate = 0;
            double hoursWorked = 0;
            double grossPay = 0;
            double taxRate = 0;
            double netPay = 0;
            double regularPay = 0;
            double overtimePay = 0;
            double taxAmount = 0;
            string maritalStatus = "";
            string customer = "josh";

            //output greeting
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi! Welcome to the Overtime Pay Calculator.");
            Console.ForegroundColor = ConsoleColor.Green;

            //inputs from user
            Console.ForegroundColor = ConsoleColor.Green;
            customer = Console.ReadLine();
            Console.Write("_________________________________________________________________");
            customer = Console.ReadLine();
            customer = Console.ReadLine();
            Console.Write("Enter the letter (M)arried, (S)ingle, (D)ivorced, (W)idowed: ");
            maritalStatus = Console.ReadLine();
            Console.Write("Enter your hours worked: ");
            hoursWorked = double.Parse(Console.ReadLine());
            Console.Write("Enter your hourly rate: $");
            payRate = double.Parse(Console.ReadLine());
            Console.Write("_________________________________________________________________");
            customer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;


            switch (maritalStatus)
            {
                case "M":
                    taxRate = mTaxRate;
                    break;
                case "S":
                    taxRate = sTaxRate;
                    break;
                case "D":
                    taxRate = dTaxRate;
                    break;
                case "W":
                    taxRate = wTaxRate;
                    break;
            }
            if (hoursWorked <= 40)  //no semicolon after the if test
            {
                customer = Console.ReadLine();
                grossPay = hoursWorked * payRate;
                Console.WriteLine("Your gross pay is: $" + grossPay);
                taxAmount = grossPay * taxRate;
                netPay = grossPay - taxAmount;
                Console.WriteLine("Your net pay is: $" + netPay);
                customer = Console.ReadLine();
                Console.Write("____________________________________________");
            }
            {
            if (hoursWorked > 40)   //overtime calculation
                {
                    customer = Console.ReadLine();
                    Console.Write("____________________________________________");
                    customer = Console.ReadLine();
                    regularPay = 40 * payRate;
                    Console.WriteLine("Your regular pay is: $" + regularPay);
                    overtimePay = (hoursWorked - 40) * payRate * overtimeRate;
                    Console.WriteLine("Your overtime pay is: $" + overtimePay);
                    grossPay = regularPay + overtimePay;
                    Console.WriteLine("Your gross pay is: $" + grossPay);
                    taxAmount = grossPay * taxRate;
                    netPay = grossPay - taxAmount;
                    Console.WriteLine("Your net pay is: $" + netPay);
                    customer = Console.ReadLine();
                    Console.Write("____________________________________________");
                    customer = Console.ReadLine();
                }
                Console.ReadLine();
            }
        }
    }
}

