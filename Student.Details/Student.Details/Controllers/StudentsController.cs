//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data.SqlClient;
//using System.Web.Http;

//namespace YourProjectName.Controllers
//{
//    public class StudentsController : Controller
//    {
//        private readonly string connectionString = ConfigurationManager.ConnectionStrings["StudentConnection"].ConnectionString;

//        [HttpGet]
//        public IHttpActionResult GetAllStudents()
//        {
//            List<Student> students = new List<Student>();

//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                string query = "SELECT * FROM Students";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            students.Add(new Student
//                            {
//                                Id = Convert.ToInt32(reader["Id"]),
//                                Name = Convert.ToString(reader["Name"]),
//                                RollNumber = Convert.ToString(reader["RollNumber"]),
//                                Branch = Convert.ToString(reader["Branch"])
//                            });
//                        }
//                    }
//                }
//            }

//            return Ok(students);
//        }

//        [HttpPost]
//        public IHttpActionResult AddStudent(Student student)
//        {
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                string query = "INSERT INTO Students (Name, RollNumber, Branch) VALUES (@Name, @RollNumber, @Branch)";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    command.Parameters.AddWithValue("@Name", student.Name);
//                    command.Parameters.AddWithValue("@RollNumber", student.RollNumber);
//                    command.Parameters.AddWithValue("@Branch", student.Branch);
//                    command.ExecuteNonQuery();
//                }
//            }

//            return Ok("Student added successfully");
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Http;

namespace YourProjectName.Controllers
{
    public class StudentsController : ApiController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["StudentConnection"].ConnectionString;

        [HttpGet]
        public IHttpActionResult GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Students";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = Convert.ToString(reader["Name"]),
                                RollNumber = Convert.ToString(reader["RollNumber"]),
                                Branch = Convert.ToString(reader["Branch"])
                            });
                        }
                    }
                }
            }

            return Ok(students);
        }

        [HttpPost]
        public IHttpActionResult AddStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Students (Name, RollNumber, Branch) VALUES (@Name, @RollNumber, @Branch)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@RollNumber", student.RollNumber);
                    command.Parameters.AddWithValue("@Branch", student.Branch);
                    command.ExecuteNonQuery();
                }
            }

            return Ok("Student added successfully");
        }
    }
}
