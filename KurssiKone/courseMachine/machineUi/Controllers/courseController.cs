using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using machineUi.Models;
using System.Net.Http;
using System.Web.Http;
using System.Web.SessionState;
using System.IO;

namespace courseMachine.Controllers
{
    public class courseController : ApiController
    {

        //  Set up Linq db connection for this stuff to work
        
        [RoutePrefix("api/create")]
        public class createController : ApiController
        {
            private string data = "Data Source=cmachine.database.windows.net;Initial Catalog=courseMachine;Integrated Security=False;User ID=alekasi;Password=Pikkusisko97;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            [HttpGet]
            [Route("course")]
            public string courseCreate(string name)
            {
                if (name.Length <= 0 || name == null) { return "nameNull"; }
                Guid creator = Guid.NewGuid();
                Guid course = Guid.NewGuid();
                try
                {


                    SqlConnection con = new SqlConnection(data);
                    SqlCommand cmd = new SqlCommand("INSERT INTO courseData (courseId, courseName, creator) VALUES (@course, @name, @creator)", con);
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@creator", creator);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch(SqlException ex)
                {
                    return ex.ToString();
                }
                catch
                {
                    return "FUCK";
                }

                return course.ToString();
            }

            [HttpGet]
            [Route("parent")]
            public string parentCreate(string name, string creator, string course)
            {
                if (name == null || name.Length <= 0) return "nameNull";
                if (creator == null || creator.Length <= 0) return "creatorNull";
                if (course == null || course.Length <= 0) return "courseNull";
                Guid parent = Guid.NewGuid();

                try
                {
                    SqlConnection con = new SqlConnection(data);
                    SqlCommand cmd = new SqlCommand("INSERT INTO parent (parentId, name, creator, courseId) VALUES (@parent, @name, @creator, @course)", con);
                    cmd.Parameters.AddWithValue("@parent", parent);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@creator", new Guid(creator));
                    cmd.Parameters.AddWithValue("@course", new Guid(course));

                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        // Maybe error reporting
                    }

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch
                {
                    return "error";
                }

                return parent.ToString();
            }

            [HttpGet]
            [Route("child")]
            public string childCreate(string name, string creator, string course, string parent)
            {
                if (name == null || name.Length <= 0) return "nameNull";
                if (creator == null || creator.Length <= 0) return "creatorNull";
                if (course == null || course.Length <= 0) return "courseNull";
                if (parent == null || parent.Length <= 0) return "parentNull";

                Guid child = Guid.NewGuid();

                try
                {
                    SqlConnection con = new SqlConnection(data);
                    SqlCommand cmd = new SqlCommand("INSERT INTO child (childId, name, creator, courseId, parentId) VALUES (@child, @name, @creator, @course, @parent)", con);
                    cmd.Parameters.AddWithValue("@child", child);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@creator", new Guid(creator));
                    cmd.Parameters.AddWithValue("@course", new Guid(course));
                    cmd.Parameters.AddWithValue("@parent", new Guid(parent));

                    con.Open();

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        //  Return some error message to logs
                    }
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch
                {
                    return "error";
                }

                return child.ToString();
            }

            [HttpGet]
            [Route("parameter")]
            public string parameterCreate(string type, string creator, string course, string child)
            {
                if (creator == null || creator.Length <= 0) return "creatorNull";
                if (course == null || course.Length <= 0) return "courseNull";
                if (child == null || child.Length <= 0) return "childNull";

                Guid parameter = Guid.NewGuid();

                try
                {
                    SqlConnection con = new SqlConnection(data);
                    SqlCommand cmd = new SqlCommand("INSERT INTO parameter (parameterId, ChildId, creator, type, value) VALUES (@parameter, @child, @creator, @type, @value)", con);
                    cmd.Parameters.AddWithValue("@child", new Guid(child));
                    cmd.Parameters.AddWithValue("@parameter", parameter);
                    cmd.Parameters.AddWithValue("@creator", new Guid(creator));
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@value", "");

                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        return "error";
                    }
                    con.Close();
                    return parameter.ToString();

                }catch(SqlException ex)
                {
                    return ex.ToString();
                }
                catch
                {
                    return "someError";
                }
            }
        }

        [RoutePrefix("api/update")]
        public class updateController : ApiController
        {
            private string data = "";

            [HttpGet]
            [Route("course")]
            public string courseUpdate(string course, string updater)
            {

                return data;
            }

            [HttpGet]
            [Route("parent")]
            public string parentUpdate()
            {
                return data;
            }

            [HttpGet]
            [Route("child")]
            public string childUpdate()
            {
                return "";
            }

            [HttpGet]
            [Route("parameter")]
            public string parameterUpdate()
            {
                return "";
            }
        }

        [RoutePrefix("api/read")]
        public class readController : ApiController
        {
            //  Fetch the whole course
            [HttpGet]
            [Route("course")]
            public IEnumerable<course> fetchController(string course)
            {
                IEnumerable<course> response = Enumerable.Empty<course>();
                if (course == null || course.Length <= 0) return response;

                return response;
            }
        }

        [RoutePrefix("api/check")]
        public class workerController: ApiController
        {
            private string data = "Data Source=cmachine.database.windows.net;Initial Catalog=courseMachine;Integrated Security=False;User ID=alekasi;Password=Pikkusisko97;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // 0 dont exist
            // 1 allready exists
            // 2 sql error
            // 3 no name
            [HttpGet]
            [Route("CourseExists")]
            public int CourseExists(string course)
            {
                string count = "";
                List<string> list = new List<string>();
                try
                {
                    if (course == null || course.Length <= 0) { return 3; }
                    SqlConnection con = new SqlConnection(data);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM courseData WHERE courseName = @course", con);
                    cmd.Parameters.AddWithValue("@course", course);
                    SqlDataReader Dr;

                    con.Open();
                    Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        count += Dr[1].ToString();
                        list.Add(count);
                        count = "";
                    }
                    con.Close();
                }
                catch
                {
                    return 2;
                }

                return list.Count();
            }
        }
        
        [RoutePrefix("api/userConfig")]
        public class userConfig: ApiController
        {
            private string data = "Data Source=cmachine.database.windows.net;Initial Catalog=courseMachine;Integrated Security=False;User ID=alekasi;Password=Pikkusisko97;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            [HttpGet]
            [Route("register")]
            public string register()
            {

                return "";
            }

            [HttpGet]
            [Route("login")]
            public string login()
            {
                return "";
            }
        }
        //  End of the controller of Lord Chanka
    }
}