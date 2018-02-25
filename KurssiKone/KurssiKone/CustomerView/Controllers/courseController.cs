using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace CustomerView.Controllers
{
    //  Set up Linq db connection for this stuff to work
    public class createCourse
    {
        public Guid courseId { get; set; }
        public string name { get; set; }
        public Guid creator { get; set; }
        public Guid company { get; set; }
        public DateTime created { get; set; }
        public string information { get; set; }
        public Guid img { get; set; }
        public int price { get; set; }
        public string currency { get; set; }
        public int duration { get; set; }
        public string durationUnit { get; set; }
    }

    public class parent
    {
        public Guid parentId { get; set; }
        public string name { get; set; }
        public Guid creator { get; set; } 
        public Guid courseId { get; set; }
    }

    public class child{
        public Guid childId { get; set; }
        public string name { get; set; }
        public Guid creator { get; set; }
        public Guid parentId { get; set; }
    }

    public class parameter
    {
        public Guid parameterId { get; set; }
        public Guid creator { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public Guid childId { get; set; }
        public int order { get; set; }
    }



    [RoutePrefix("api/create")]
    public class courseController : Controller
    {
        private string data = "";

        [HttpGet]
        [Route("course")]
        public string courseCreate(string name, string creator)
        {

            if(name.Length <= 0 || name == null) { return "nameNull"; }
            if(creator.Length <= 0 || creator == null) { return "creatorNull"; }
            Guid course = Guid.NewGuid();
            try
            {
                

                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("INSERT INTO courses (course, courseName, creator) VALUE (@course, @name, @creator)", con);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@creator", creator);
            }
            catch
            {

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
    }

    [RoutePrefix("api/update")]
    public class updateController : Controller
    {
        private string data = "";

        [HttpGet]
        [Route("course")]
        public string courseUpdate(string course, string updater)
        {

            return "";
        }

        [HttpGet]
        [Route("parent")]
        public string parentUpdate()
        {
            return "";
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
}
