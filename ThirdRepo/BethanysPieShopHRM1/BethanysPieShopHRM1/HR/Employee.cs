using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM1.HR
{
    internal class Employee : IEmployee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double? hourlyRate;

        public DateTime birthday;

        const int minimalHoursWorkedUnit = 1;

        public EmployeeType employeeType;

        public static double taxRate = 0.15;

        public Address address;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        public string Email
        {
            get { return  email; }
            private set { email = value; }
        }

        public int NumberOfHoursWorked
        {
            get
            {
                return numberOfHoursWorked;
            }
            protected set 
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get
            {
                return wage;
            }
            private set { wage = value; }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            private set 
            {
                if(hourlyRate<0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }

        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }


        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0, EmployeeType.StoreManager)
        {
        }

        public Employee(string first, string last, string em, DateTime bd, double? rate, EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthday = bd;
            hourlyRate = rate ?? 10;
            employeeType = empType;
        }

        public Employee(string first, string last, string em, DateTime bd, double? rate, string v, EmployeeType empType,string street,string houseNumber,string zip,string city)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthday = bd;
            hourlyRate = rate ?? 10;
            employeeType = empType;

            Address = new Address(street, houseNumber, zip, city);
        }

        public Employee(string first, string last, string em, DateTime bd, int v) : this(first, last, em, bd)
        {
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
            //numberOfHoursWorked++;
            //Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s)");

        }

        public void PerformWork(int numberofHours)
        {
            numberOfHoursWorked += numberofHours;
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s)");
        }

        //public double ReceiveWage(bool resetHours = true)
        //{
        //    wage = numberOfHoursWorked * hourlyRate;

        //    Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s)");

        //    if (resetHours)
        //        numberOfHoursWorked = 0;

        //    return wage;
        //}

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail:\t\t{email}\nBirthday: \t{birthday.ToShortDateString()}\t{taxRate}");
        }

        public static void displayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        public double ReceiveWage(Boolean resetHours= true)
        {
            double? wageBeforeTax = 0.0;

            if(employeeType==EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {firstName} is a Manager");
                wageBeforeTax = numberOfHoursWorked * hourlyRate * 1.25;
            }
            else
            {
                wageBeforeTax = numberOfHoursWorked * hourlyRate;
            }

            double? taxAmount = wageBeforeTax * taxRate;
            wage = (double)(wageBeforeTax - taxAmount);

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if(resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }

        public static implicit operator Employee(StoreManager v)
        {
            throw new NotImplementedException();
        }




    }
}
