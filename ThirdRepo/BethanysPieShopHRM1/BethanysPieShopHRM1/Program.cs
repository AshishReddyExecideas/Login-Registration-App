using BethanysPieShopHRM1.HR;
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Creating an Employee");
        //Console.WriteLine("---------------------\n");

        //Employee bethany = new Employee("Bethany", "Smith", "bethany@gmail.com", new DateTime(1979, 1, 16), 25);
        //string bethanyASJson = bethany.ConvertToJson();
        //Console.WriteLine(bethanyASJson);



        //Employee employee = new Employee();

        //bethany.DisplayEmployeeDetails();

        //bethany.PerformWork();
        //bethany.PerformWork();
        //bethany.PerformWork(5);
        //bethany.PerformWork();

        //double receivedWageBethany = bethany.ReceiveWage();
        //Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");


        //Console.WriteLine("Creating an Employee");
        //Console.WriteLine("---------------------\n");

        //Employee george = new Employee("George", "Jones", "george@gmail.com", new DateTime(1984, 3, 28), 30);
        ////Employee employee = new Employee();

        //bethany.DisplayEmployeeDetails();

        //bethany.PerformWork();
        //bethany.PerformWork(3);
        //bethany.PerformWork();
        //bethany.PerformWork();
        //bethany.PerformWork(8);

        //var receivedWageGeorge = george.ReceiveWage();
        //Console.WriteLine($"Wage paid (message from Program): {receivedWageGeorge}");

        //Employee.displayTaxRate();

        //String firstName = "Bethany";
        //String lastName = "Smith";

        //StringBuilder builder = new StringBuilder();
        //builder.Append("Last name: ");
        //builder.AppendLine(lastName);
        //builder.Append("First name: ");
        //builder.AppendLine(firstName);
        //string result = builder.ToString();

        //Console.WriteLine(result);

        //BethanysPieShopHRM1.Accounting.Customer customer = new BethanysPieShopHRM1.Accounting.Customer();

        //Manager Mary = new Manager("Mary", "Jones", "maryjones@gmail.com",new DateTime(1965,1,16),30);
        //Researcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@gmail.com", new DateTime(1988, 1, 23), 17);

        ////Employee Jake = new Employee("Jake", "Nicols", "jake@gmail.com", new DateTime(1995, 8, 16), 25, "New Street", "123,"123456","Pie Ville");

        //Mary.DisplayEmployeeDetails();

        //int[] sampleArray1 = new int[5];

        //int[] sampleArray2 = new int[] { 1, 2, 3,4, 5 };
        ////int[] sampleArray3= new int[4] { 1,2, 3,4, 5 };

        //Console.WriteLine("How many employee IDs you want to register?");
        //int length=int.Parse(Console.ReadLine());
        //int[] employeeIds= new int[length];

        //var testId = employeeIds[0];
        ////var errorId = employeeIds[length];

        //for(int i=0; i<length; i++)
        //{
        //    Console.Write("Enter the Employee ID: ");
        //    int id=int.Parse(Console.ReadLine());
        //    employeeIds[i]=id;
        //}

        //for(int i=0; i<length; i++)
        //{
        //    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
        //}


        //List<int> empIds=new List<int>();

        //empIds.Add(1);
        //empIds.Add(2);
        //empIds.Add(4);

        //if(empIds.Contains(5))
        //{
        //    Console.WriteLine("It contains ID 5");
        //}

        //int numberOfEmployees = empIds.Count;
        //var empIdsArray = empIds.ToArray(); 

        //List<IEmployee> employees = new List<IEmployee>();
        //employees.Add(bethany);
        //employees.Add(Mary);
        ////employees.Add(bobJunior);
        ////employees.Add(kevin);

        //foreach(Employee employee in employees)
        //{
        //    employee.DisplayEmployeeDetails();
        //}

        Employee bethany = new StoreManager("Bethany", "Smith", "bethany@gmail.com", new DateTime(1979, 1, 16), 25);
        int numberOfHours = 0;
        string input=Console.ReadLine();
        numberOfHours = int.Parse(input);

        bethany.DisplayEmployeeDetails();
        bethany.PerformWork();
        bethany.PerformWork(numberOfHours);
    }
}


