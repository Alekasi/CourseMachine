using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using courseMachine.resources;
using courseMachine.courseReference;
using courseMachine.parentReference;
using courseMachine.childReference;

namespace courseMachine.Controllers
{
    public class courseController : Controller
    {

        //  Set up Linq db connection for this stuff to work
        
        [RoutePrefix("api/create")]
        public class createController : Controller
        {
            private string data = "Server=tcp:cmachine.database.windows.net,1433;Initial Catalog=courseMachine;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            [HttpGet]
            [Route("course")]
            public string courseCreate(string name, string creator)
            {
                if (name.Length <= 0 || name == null) { return "nameNull"; }
                if (creator.Length <= 0 || creator == null) { return "creatorNull"; }

                IcourseClient create = new IcourseClient();
                string response = create.createCourseString(name, creator);

                return response;
            }

            [HttpGet]
            [Route("parent")]
            public string parentCreate(string name, string creator, string course)
            {
                if (name == null || name.Length <= 0) return "nameNull";
                if (creator == null || creator.Length <= 0) return "creatorNull";
                if (course == null || course.Length <= 0) return "courseNull";

                string response = "";
                Guid parentGuid = new Guid();

                try
                {
                    IparentClient create = new IparentClient();
                    string parentString = create.createString(name, creator, course);
                    try
                    {
                        parentGuid = new Guid(parentString);
                    }
                    catch
                    {
                        response = parentString;
                    }
                }
                catch
                {
                    return "Error";
                }
                
                return response.ToString();
            }

            [HttpGet]
            [Route("child")]
            public string childCreate(string name, string creator, string parent)
            {
                if (name == null || name.Length <= 0) return "nameNull";
                if (creator == null || creator.Length <= 0) return "creatorNull";
                if (parent == null || parent.Length <= 0) return "parentNull";

                string response = "";
                Guid childGuid = Guid.NewGuid();

                try
                {
                    IchildClient create = new IchildClient();
                    response = create.createString(parent, name, creator);
                    try
                    {
                        childGuid = new Guid(response);
                    }
                    catch
                    {
                        return response;
                    }
                }
                catch
                {
                    return "ErrorMachine";
                }

                return response;
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO parameter (courseId, ChildId, parameterId, creator, type) VALUES (@course, @child, @parameter, @creator, @type)", con);
                    cmd.Parameters.AddWithValue("@course", new Guid(course));
                    cmd.Parameters.AddWithValue("@child", new Guid(child));
                    cmd.Parameters.AddWithValue("@parameter", parameter);
                    cmd.Parameters.AddWithValue("@creator", new Guid(creator));
                    cmd.Parameters.AddWithValue("@type", type);

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

                }
                catch
                {
                    return "someError";
                }
            }
        }

        [RoutePrefix("api/update")]
        public class updateController : Controller
        {
            private string data = "";

            [HttpGet]
            [Route("course")]
            public string courseUpdate(string course, string updater)
            {
                courseReference.courseUpdate update = new courseReference.courseUpdate();
                courseReference.IcourseClient client = new courseReference.IcourseClient();
                string response = "Error";

                try
                {
                    update.status = "";
                    update.information = "";
                    update.price = 0;
                    update.currency = "";
                    update.duration = 0;
                    update.durationUnit = "";

                    response = client.updateString(course, update);
                }
                catch
                {
                    //  Error
                }
                return response;
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
        public class readController
        {
            //  Fetch the whole course
            [HttpGet]
            [Route("course")]
            public List<courseClass> fetchCourse(string course)
            {
                List<courseClass> response = new List<courseClass>();
                IcourseClient fetch = new IcourseClient();
                try
                {
                    response = fetch.fetchCourses(0, 0).ToList();
                }
                catch
                {

                }
                
                return response;
            }

            [HttpGet]
            [Route("parent")]
            public List<parentClass> fetchParent(string courseId)
            {
                List<parentClass> response = new List<parentClass>();
                IparentClient read = new IparentClient();
                try
                {
                    response = read.readString(courseId).ToList();
                }
                catch
                {

                }

                return response;
            }

            [HttpGet]
            [Route("child")]
            public List<childReference.childClass> fetchChild(string course, string parent)
            {
                List<childReference.childClass > response = new List<childReference.childClass> ();
                IchildClient read = new IchildClient();
                try
                {
                    response = read.readString(course, parent).ToList();
                }
                catch
                {

                }

                return response;
            }
        }

        //  End of the controller of Lord Chanka
    }
}