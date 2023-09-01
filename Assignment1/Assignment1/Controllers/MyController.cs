namespace Assignment1.Controllers;
using Assignment1.DatabaseConnection;
using Assignment1.Entity;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

[Route("api/EmployeeDetails")]
[ApiController]
public class MyController : ControllerBase
{
    private readonly IConfiguration _config;

    public MyController(IConfiguration config)
    {
        _config = config;
    }

    // Your controller actions here...

    //1st Question
    [HttpGet("[action]")]
    public IActionResult GetEmployeeById(int id)
    {
        //connection.Open()
        DbContext dbcon=new DbContext();
        //int id = 4;
        var emp = dbcon.EmployeebyEid(id);
        return Ok(emp);
    }

    [HttpGet("[action]")]
    public IActionResult GetProjectById(int id) 
    {
        DbContext dbcon=new DbContext();
        var proj = dbcon.ProjectbyPid(id);
        return Ok(proj);
    }

    [HttpGet("[action]")]
    public IActionResult GetTeamById(int id)
    {
        DbContext dbcon = new DbContext();
        var team = dbcon.TeambyTid(id);
        return Ok(team);
    }

    //2nd question
    [HttpGet("[action]")]
    public IActionResult GetProjectsbyEmployee(int eid)
    {
        DbContext dbcon = new DbContext();
        var project = dbcon.ProjectsbyEmployee(eid);
        return Ok(project);
    }

    [HttpGet("[action]")]
    public IActionResult GetEmployeebyProject(int pid)
    {
        DbContext dbcon = new DbContext();
        var project = dbcon.EmployeebyProject(pid);
        return Ok(project);
    }

    [HttpGet("[action]")]
    public IActionResult GetEmployeebyTeam(int tid)
    {
        DbContext dbcon = new DbContext();
        var emp = dbcon.EmployeebyTeam(tid);
        return Ok(emp);
    }

    [HttpPost("[action]")]
    public IActionResult PostEmployee(Employee employee)
    {
        DbContext dbcon = new DbContext();
        //var emp = 
        dbcon.PostEmployee(employee.Name,employee.Emailid,employee.Mobile,employee.HiredDate,employee.Tid);
        return Ok();
    }


    //[HttpPost("[action]")]
    //public IActionResult CreateEmployee(Employee employee)
    //{
    //    DbContext dbcon = new DbContext();
    //    var con = dbcon.Connection;
    //    var insertQuery = "INSERT INTO Employee (eid ,name, emailid, mobile, hired_date, tid) VALUES (@Eid,@Name, @EmailId, @Mobile, @HiredDate, @Tid)";
    //    con.Execute(insertQuery, employee);

    //    return Ok("Employee created successfully.");
        
    //}

    [HttpPut("[action]")]
    public IActionResult PutEmployee(Employee employee)
    {
        DbContext dbcon = new DbContext();
        dbcon.PutEmployee(employee.Eid,employee.Emailid,employee.Mobile);
        return Ok();
    }

    [HttpPut("[action]")]
    public IActionResult PutEmployeeTestwithEmptyFields(int eid, string email, string mobile, DateOnly hireddate, int tid)
    {
        DbContext dbcon = new DbContext();
        dbcon.PutEmployeeTest(eid, email, mobile,hireddate,tid);
        return Ok();
    }

    [HttpDelete("[action]")]
    public IActionResult DeleteEmployee(int eid)
    {
        DbContext dbcon = new DbContext();
        dbcon.DeleteEmployee(eid);
        return Ok();
    }


}
