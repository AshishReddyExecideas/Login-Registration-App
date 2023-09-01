//using System;

//class Program
//{

//    static void Main(string[] args)
//    {
//        //Console.WriteLine("Welcome to Bethany's Pie Shop HRM");
//        //Console.WriteLine("Enter you name : ");
//        //string name=Console.ReadLine();
//        //string name2=Console.ReadLine();
//        //string name_2=Console.ReadLine();
//        //string Name_2 = Console.ReadLine();
//        //string Name2=Console.ReadLine();
//        //// string 2name=Console.ReadLine();

//        //int monthlyWage = 1234;
//        //int months = 12, bonus = 1000;
//        //bool isActive = true;
//        //double rating = 99.25;
//        ////byte numberOfEmployees = 300;
//        //int hoursWorked;
//        //hoursWorked = 125;
//        //hoursWorked = 148;

//        //const double interestrate = 9.5;

//        //string firstname = "Bethany";
//        //string lastname = "Smith";

//        //string emptystring = "";

//        //Console.WriteLine("Enter your name : ");
//        //string name_1=Console.ReadLine();

//        //double rateperHour = 12.34;
//        //int numberofHoursWroked = 165;
//        //int bonus = 1000;
//        //double currentMonthWage = rateperHour * numberofHoursWroked + bonus;
//        //Console.WriteLine(currentMonthWage);

//        //rateperHour += 3;
//        //Console.WriteLine(rateperHour);

//        //if(currentMonthWage>2000)
//        //    Console.WriteLine("Top Paid Employee");

//        //int numberOfEmployees = 15;
//        //numberOfEmployees--;

//        //bool a;
//        //int b;

//        //Console.WriteLine(numberOfEmployees);

//        //int intMinValue=int.MinValue;
//        //int intMaxValue=int.MaxValue;
//        //double doubleMaxValue=double.MaxValue;

//        //Console.WriteLine(doubleMaxValue+" \n"+intMaxValue+" \n"+intMinValue);

//        //char userSelection = 'a';
//        //char upperVersion = char.ToUpper(userSelection);
//        //bool isDigit=char.IsDigit(upperVersion);
//        //bool isLetter=char.IsLetter(upperVersion);
//        //bool isWhite=char.IsWhiteSpace(upperVersion);

//        //Console.ReadLine();

//        //DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
//        //Console.WriteLine(hireDate);

//        //DateTime exitDate = new DateTime(2025, 12, 11);
//        //Console.WriteLine(exitDate);


//        //DateTime startDate = hireDate.AddDays(15);
//        //Console.WriteLine(startDate);

//        //DateTime currentDate = DateTime.Now;

//        //bool areWeInDst = currentDate.IsDaylightSavingTime();

//        //DateTime startHour=DateTime.Now;
//        //TimeSpan workTime = new TimeSpan(8,35,0);
//        //DateTime endHour = startHour.Add(workTime);

//        //Console.WriteLine(startHour.ToLongDateString());
//        //Console.WriteLine(endHour.ToShortDateString());

//        //int numberOfHoursWorked = 165;
//        //long veryLongMonth = numberOfHoursWorked;
//        //double d = 123456789.0;
//        //int x = (int)d;
//        //int intveryLongMonth = (int)veryLongMonth;
//        //Console.ReadLine();

//        //int age = 23;

//        //bool a = age == 23;

//        //Console.WriteLine("Your age is 23 : " + a);

//        //bool b = age >= 23;
//        //Console.WriteLine("Age is greater than 23 : " + b);

//        //bool c=(age >= 18) && (age<=65);
//        //Console.WriteLine("Age is between 18 and 65 : " + c);

//        //age = 16;
//        //bool d = (age >= 18) && (age <= 65);
//        //Console.WriteLine("Age is between 18 and 65 : " + d);

//        //age = 66;
//        //bool e = (age >= 18) && (age <= 65);
//        //Console.WriteLine("Age is between 18 and 65 : " + e);

//        //Console.WriteLine("Enter the age of candidate : ");
//        //int age=int.Parse(Console.ReadLine());

//        //if(age<18)
//        //{
//        //    Console.WriteLine("Too Young to Apply");
//        //    Console.WriteLine("Send email to candidate");
//        //}
//        //else if(age>65)
//        //{
//        //    Console.WriteLine("Sorry the selected age is too old");
//        //    Console.WriteLine("Send email to candiate");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("Great you can now start with the application!");
//        //}

//        //    switch(age)
//        //    {
//        //        case <18: 
//        //            //Console.WriteLine("Too young to apply");
//        //            //break;
//        //        case > 65: 
//        //            Console.WriteLine("Sorry the selected age is too old");
//        //            break;
//        //        case 23:
//        //            Console.WriteLine("Wow wxactly we are looking for ");
//        //            break;
//        //        default: 
//        //            Console.WriteLine("Great you can now start with the application");
//        //            break;
//        //    }

//        //Console.WriteLine("Choose the action you want to do:");
//        //Console.WriteLine("1. Add Employee");
//        //Console.WriteLine("2. Update Employee");
//        //Console.WriteLine("3. Delete Employee");
//        //string selectedAction = Console.ReadLine();

//        //while (selectedAction != "99")
//        //{
//        //    switch (selectedAction)
//        //    {
//        //        case "1":
//        //            Console.WriteLine("Adding new Employee");
//        //            break;
//        //        case "2":
//        //            Console.WriteLine("Updating employee");
//        //            break;
//        //        case "3":
//        //            Console.WriteLine("Deleting Employee");
//        //            break;
//        //        default:
//        //            Console.WriteLine("Invalid Input");
//        //            break;
//        //    }
//        //}
//        //Console.WriteLine("Choose the action you want to do:");
//        //Console.WriteLine("1. Add Employee");
//        //Console.WriteLine("2. Update Employee");
//        //Console.WriteLine("3. Delete Employee");
//        //Console.WriteLine("99. Exit application");
//        //selectedAction = Console.ReadLine();

//        //string selectedAction = "";
//        //do
//        //{
//        //    Console.WriteLine("Choose the action you want to do:");
//        //    Console.WriteLine("1. Add Employee");
//        //    Console.WriteLine("2. Update Employee");
//        //    Console.WriteLine("3. Delete Employee");
//        //    Console.WriteLine("99.Exit Application");
//        //    selectedAction = Console.ReadLine();

//        //    while (selectedAction != "99")
//        //    {
//        //        switch (selectedAction)
//        //        {
//        //            case "1":
//        //                Console.WriteLine("Adding new Employee");
//        //                break;
//        //            case "2":
//        //                Console.WriteLine("Updating employee");
//        //                break;
//        //            case "3":
//        //                Console.WriteLine("Deleting Employee");
//        //                break;
//        //            default:
//        //                Console.WriteLine("Invalid Input");
//        //                break;
//        //        }
//        //    }

//        //} while (selectedAction != "99");
//        //Console.WriteLine("Closing application");

//        //Console.WriteLine("Enter a value : ");
//        //int max=int.Parse(Console.ReadLine());
//        //int i = 0;
//        //while(i<max)
//        //{
//        //    Console.WriteLine(i);
//        //    i++;
//        //}
//        //Console.WriteLine("Loop is executed");

//        //while (true)
//        //{
//        //    Console.WriteLine(DateTime.Now);
//        //}

//        //for(int i=0; i<10; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }

//}


using BethanysPieShopHRM;
using System;

class Program
{

    //static int CalculateYearlyWage(int monthlyWage,int numberOfMonthsWorked)
    //{
    //    if(numberOfMonthsWorked==12)
    //        return monthlyWage * (numberOfMonthsWorked+1);

    //    return monthlyWage * numberOfMonthsWorked;
    //    //Console.WriteLine($"Yearly wage: {monthlyWage*numberOfMonthsWorked}");
    //}
    static void Main(string[] args)
    {
        //int amount = 1234;
        //int months = 12;
        //int bonus = 1000;
        //Utilities.CalculateYearlyWage(amount, months, bonus);
        //int yearlyWage = Utilities.CalculateYearlyWage(months, amount, bonus);
        //int yearly = Utilities.UsingNamedArguments();
        //int yearly = Utilities.CalculateYearlyWageExpressionBodied(amount,months,bonus);
        //Console.WriteLine(yearly);
        //Utilities.ManipulatingStrings();
        //Utilities.UsingStringEquality();
        Utilities.ParsingStrings();
    }
}