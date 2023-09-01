namespace Assignment1.DatabaseConnection;
using System.Data;
using System.Data.SqlClient;
using Assignment1.Entity;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

public class DbContext
{
    public IDbConnection Connection
    {
        get
        {
            return new SqlConnection("server=localhost;database=EmployeeDetails2;Integrated Security=True");
        }
    }

    public IEnumerable<T> ExecuteQuery<T>(string query)
    {
        var conn = Connection;
        return conn.Query<T>(query, commandType: CommandType.Text);
    }

    public void CallMethod()
    {
        var records = ExecuteQuery<Employee>("Select * from Employee where eid=2");
    }

    public Employee EmployeebyEid(int id)
    {
        var con = Connection;
        var queryResult = con.Query<Employee>("SELECT * FROM Employee Where eid=@id",new { id }).First();
        return queryResult;
    }

    public Project ProjectbyPid(int id)
    {
        var con = Connection;
        var queryResult = con.Query<Project>("SELECT * FROM Project Where pid=@id", new { id }).First();
        return queryResult;
    }

    public Team TeambyTid(int id)
    {
        var con = Connection;
        var queryResult = con.Query<Team>("SELECT * FROM Team Where tid=@id", new { id }).First();
        return queryResult;
    }

    public Project ProjectsbyEmployee(int id)
    {
        var con = Connection;
        var queryResult = con.Query<Project>("SELECT * FROM Project WHERE pid IN (SELECT pid FROM Employee_Project WHERE eid = @id );", new { id }).First();
        return queryResult;
    }

    public Employee EmployeebyProject(int id)
    {
        var con = Connection;
        var queryResult = con.Query<Employee>("SELECT * FROM Employee WHERE eid IN (SELECT eid FROM Employee_Project WHERE pid = @id );", new { id }).First();
        return queryResult;
    }

    public Employee EmployeebyTeam(int id)
    {
        var con = Connection;
        var queryResult = con.Query<Employee>("SELECT * FROM Employee WHERE Employee.tid=@id;", new { id }).First();
        return queryResult;
    }

    public void PostEmployee(string name, string email, string mobile, DateTime hireddate,int tid)
    {
        var con = Connection;
        var queryResult = con.Execute("INSERT INTO Employee (name, emailid, mobile, hired_date, tid) VALUES (@name, @email, @mobile, @hiredDate, @tid);", new {name, email, mobile, hireddate, tid });
        //return queryResult;
    }

    public void PutEmployee(int eid,string email,string mobile)
    {
        var con = Connection;
        var queryResult = con.Query<Employee>("UPDATE Employee SET Emailid = @email,mobile=@mobile WHERE eid=@eid;", new {email,mobile,eid});
        //return queryResult;
    }

    public void PutEmployeeTest(int eid, string email, string mobile,DateOnly hireddate,int tid)
    {
        var con = Connection;
        var queryResult = con.Query<Employee>("UPDATE Employee SET Emailid = @email,mobile=@mobile,hireddate=@hireddate,tid=@tid WHERE eid=@eid;", new { email, mobile, eid, hireddate, tid });
        //return queryResult;
    }

    public void DeleteEmployee(int eid)
    {
        var con = Connection;
        var queryResult = con.Query<Employee>("DELETE FROM Employee Where eid=@eid", new {eid} );
        //return queryResult;
    }


    //    public void InsertNewEmployee(Employee employee)
    //    {
    //        var con = Connection;
    //        var insertQuery = "INSERT INTO Employee (name, emailid, mobile, hired_date, tid) " +
    //                              "VALUES (@name, @emailid, @mobile, @hired_date, @tid)";
    //        con.Execute(insertQuery, employee);
    //    }
    //}

}
    