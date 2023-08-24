using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {

        public static void ParsingStrings()
        {
            Console.WriteLine("Enter a string");
            string wage = Console.ReadLine();
            //int WageValue=int.Parse(wage);

            int wageValue;
            if (int.TryParse(wage, out wageValue))
                Console.WriteLine("Parsing Success : " + wageValue);
            else
                Console.WriteLine("Parsing failed");

            string hireDateString = "12/12/2020";
            DateTime hireDate=DateTime.Parse(hireDateString);
            Console.WriteLine("Parsed date: " + hireDate);
        }

        public static void UsingStringEquality()
        {
            string name1 = "Bethany";
            string name2 = "BEThany";

            Console.Write("Are both names equal : " + (name1 == name2));
        }

        public static void UsingEscapeCharacters()
        {
            string firstname = "Bethany";
            string lastname = "Smith";
            string displayName = $"Welcome!\n{firstname}\t{lastname}";
            Console.WriteLine(displayName);

            string invalidFilePath = "C:\\data\\employeelist.xlsx";
            string marketingTagLine = "Baking the \"best pies\" ever";
        }

        public static void UsingSimpleStrings()
        {
            string firstName = "Bethany";
            string lastName = "Smith";
            string s;
            s = firstName;
            var userName = "BethanyS";
            userName = userName.ToLower();
            userName = "";
        }

        public static void ManipulatingStrings()
        {
            string firstName = "Bethany";
            string lastName = "Smith";
            string fullName = firstName + " " + lastName;
            string employeeIdentification=String.Concat(firstName, lastName);

            string empID = firstName.ToLower() + "-" + lastName.Trim().ToLower();

            int length = empID.Length;
            Console.WriteLine("Characters from 2 to 4 are " + fullName.Substring(1, 3));
        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            int local = 100;
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
            //Console.WriteLine($"Yearly wage: {monthlyWage*numberOfMonthsWorked}");
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberofMonthsWorked, int bonus)
        {
            Console.WriteLine($"Yearly wage: {monthlyWage*numberofMonthsWorked+bonus}");
            return monthlyWage*numberofMonthsWorked + bonus;
        }

        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numnberOfMonthsWorked, int bonus) => monthlyWage * numnberOfMonthsWorked + bonus;
        
        public static int UsingNamedArguments()
        {
            int amount = 1000;
            int months = 12;
            int bonus = 500;
            int yearlyWageForEmployees = CalculateYearlyWage(bonus: bonus,monthlyWage:amount,numberofMonthsWorked:months);
            return yearlyWageForEmployees;
        }
    }
}
