using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM1.HR
{
    internal class Manager : Employee
    {
        public Manager(string first, string last, string em, DateTime bd, int v) : base(first, last, em, bd, v)
        {
        }

        public Manager(string first, string last, string em, DateTime bd, double? rate, EmployeeType empType) : base(first, last, em, bd, rate, empType)
        {
            
        }

        public void AttendManagementMeeting()
        {
            NumberOfHoursWorked += 10;
        }
    }
}
