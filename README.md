# Calculate-Overtime-Pay
An application that it will prompt a user for his or her hourly pay rate; his or her hours worked; whether he or she is single,  married, divorced, or widowed; calculating the user’s gross and net pay. Overtime is calculated at 1 ½ times the regular rate  and displayed separately. A flat tax rate of 15% is applied if married; if single, 22% is applied; if divorced, 23% is applied;  and if widowed, 13% is applied.

# Variable List & IPO Model
![Variable List & IPO Model](https://raw.githubusercontent.com/kiddjsh/Calculate-Overtime-Pay/main/images/Variable%20List%20%26%20IPO%20Model.PNG)

# No Overtime - Complete Working Program
![No Overtime - Complete Working Program](https://raw.githubusercontent.com/kiddjsh/Calculate-Overtime-Pay/main/images/No%20Overtime%20Example.PNG)

# With Overtime - Complete Working Program
![With Overtime - Complete Working Program](https://raw.githubusercontent.com/kiddjsh/Calculate-Overtime-Pay/main/images/Overtime%20Example.PNG)

```C#
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
```
