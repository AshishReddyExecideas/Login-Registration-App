using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace EmployeeSolutionAssignment
{
    [ApiController]
    [Route("api/printandaddemployee")]
    public class GetEmployeeDetails : ControllerBase
    {

        List<EmployeeDetailsStructure> EmpDetails = new List<EmployeeDetailsStructure>();

        //private readonly AddandGetemployee _employeeManager;
        //public GetEmployeeDetails(AddandGetemployee employeeManager)
        //{
        //    _employeeManager = employeeManager;
        //}

        //public void AddNewEmployee(String n, int i, string mob)
        //{
        //    EmployeeDetailsStructure emp = new EmployeeDetailsStructure(n, i, mob);
        //    EmpDetails.Add(emp);

        //    //EmployeeDetailsStructure emp1 = new EmployeeDetailsStructure("Ashish", 1234, "999999");
        //    //EmployeeDetailsStructure emp2 = new EmployeeDetailsStructure("abc", 765, "5675678
        //    //EmpDetails.Add(emp2);
        //    //EmpDetails.Add(emp);

        //}

        public List<EmployeeDetailsStructure> Getemp()
        { return EmpDetails; }

        [HttpGet]

        public JsonResult GetEmpDetails()
        {

            //new List<object> emp={ { name = "ashish", id = 1, mobile = "99999" }, { name = "abc", id = 2, mobile = "12345" }};

            //List<EmployeeDetailsStructure> empDetails = new List<EmployeeDetailsStructure>();
            //empDetails.dd("Ashish",1234,"901234");
            //Addnewemployee("Ashish", 1234, "098765");

            //return new JsonResult(new List<object>
            //        {
            //            new {name="ashish",id=1,mobile="99999"},
            //            new {name="abc",id=2,mobile="12345"}
            //        });


            //AddandGetemployee empdetails = new AddandGetemployee();
            EmployeeDetailsStructure emp = new EmployeeDetailsStructure( "Ashish", 1324, "876545678" );
            EmpDetails.Add(emp);

            return new JsonResult(Getemp());


        }


        [HttpPost]
        public void AddEmpDetails(EmployeeDetailsStructure employee)
        {
            if (employee != null)
            {
                //AddandGetemployee employeeManager = new AddandGetemployee();

                //employeeManager.AddNewEmployee(employee.Name, employee.Id, employee.Mobile);

                //return Ok("Employee added successfully.");

                //AddNewEmployee(employee.Name,employee.Id,employee.Mobile);

                EmpDetails.Add(employee);
            }

            //return employee;
            //return BadRequest("Invalid employee data.");
        }
    }
}
