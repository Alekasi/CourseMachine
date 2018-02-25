using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using courseBackGround.parentReference;

namespace courseBackGround.course
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "course" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select course.svc or course.svc.cs at the Solution Explorer and start debugging.
    public class course : Icourse
    {
        private string data = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        
        public int checkCourse(string course)
        {
            try
            {
                if (course == null || course.Length <= 0) { return 3; }
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("SELECT * FROM courseData WHERE courseName = @course", con);
                cmd.Parameters.AddWithValue("@course", course);
                SqlDataReader Dr;

                con.Open();
                Dr = cmd.ExecuteReader();
                if (Dr.Read())
                {
                    return 1;
                }
                con.Close();

                return 0;
            }
            catch
            {
                return 2;
            }
        }

        public byte[] imgToByte(System.Drawing.Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        public string createCourseString(string name, string user)
        {
            if (name.Length <= 0 || name == null) { return "nameNull"; }
            if (user.Length <= 0 || user == null) { return "userNull"; }
            string response = "Error";
            try
            {
                create use = new create();
                use.name = name;
                use.user = new Guid(user);

                response = createCourse(use).ToString();
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }

            return response;
        }

        public string createCourse(create use)
        {
            Guid courseId = Guid.NewGuid();
            try
            {
                int check = checkCourse(use.name);
                if(check != 0) { return check.ToString(); }
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("INSERT INTO courseData (courseId, courseName, creator, status, information) VALUES (@courseId, @courseName, @creator, @status, @information)", con);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.Parameters.AddWithValue("@courseName", use.name);
                cmd.Parameters.AddWithValue("@creator", use.user);
                cmd.Parameters.AddWithValue("@status", "locked");
                cmd.Parameters.AddWithValue("@information", "tere");

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            return courseId.ToString(); ;
        }
        
        public courseClass courseInfo(string course, string user)
        {
            courseClass response = new courseClass();
            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("SELECT * FROM courseData WHERE courseId = @courseId", con);
            cmd.Parameters.AddWithValue("@courseId", new Guid(course));
            SqlDataReader Dr;
            con.Open();

            Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                response.courseId = new Guid(Dr["courseId"].ToString());
                response.name = Dr["courseName"].ToString();
                response.creator = new Guid(Dr["creator"].ToString());
                response.company = new Guid(Dr["company"].ToString());
                response.created = DateTime.Parse(Dr["created"].ToString());
                response.status = Dr["status"].ToString();
                response.information = Dr[""].ToString();
                response.img = Dr["img"].ToString();
                response.price = Convert.ToInt32(Dr["price"]);
                response.currency = Dr["currency"].ToString();
                response.duration = Convert.ToInt32(Dr["duration"]);
                response.durationUnit = Dr["durationUnit"].ToString();
            }
            Dr.Close();
            con.Close();

            return response;
        }

        public List<courseClass> fetchCourses(int fetch, int jump)
        {
            fetch = fetch <= 0 ? 20 : fetch;
            jump = jump < 0 ? 0 : jump;
            List<courseClass> response = new List<courseClass>();

            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("SELECT * FROM courseData ORDER BY created DESC", con);
                SqlDataReader Dr;
                con.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    try
                    {
                        courseClass reader = new courseClass();
                        //reader.courseId = Dr.GetGuid(0);
                        //reader.name = Dr.GetString(1) == null ? "GeneralName" : Dr.GetString(1);
                        //reader.creator = Dr.GetGuid(2);
                        //reader.company = Dr.GetGuid(3);
                        //reader.status = Dr.GetString(4) == null ? "GeneralName" : Dr.GetString(4);
                        //reader.information = Dr.GetString(5) == null ? "GeneralName" : Dr.GetString(5);
                        //reader.price = Dr.GetInt32(7).ToString() == null ? 0 : Dr.GetInt32(7);
                        //reader.currency = Dr.GetString(8) == null ? "GeneralName" : Dr.GetString(8);
                        //reader.duration = Dr.GetInt32(9).ToString() == null ? 0 : Dr.GetInt32(9);
                        //reader.durationUnit = Dr.GetString(10) == null ? "GeneralName" : Dr.GetString(10);
                        //  Experimental
                        reader.courseId = Dr.GetGuid(0);
                        if (Dr.GetString(1) != null) { reader.name = Dr.GetString(1); }
                        if(Dr.GetGuid(2) != null) { reader.creator = Dr.GetGuid(2); }
                        //if (Dr.GetGuid(3) != null) { reader.company = Dr.GetGuid(3); }
                        reader.created = Dr.GetDateTime(4);

                        if (Dr.GetString(5) != null) { reader.status = Dr.GetString(5); }
                        if(Dr.GetString(6) != null) { reader.information = Dr.GetString(6); }

                        reader.price = 49;
                        reader.currency = "EUR";
                        reader.duration = 6;
                        reader.durationUnit = "DAY";

                        response.Add(reader);
                    }
                    catch(Exception ex)
                    {
                        courseClass reader = new courseClass();
                        reader.status = ex.ToString();
                        response.Add(reader);
                        continue;
                    }
                }
                Dr.Close();
                con.Close();

                if(response.Count <= 0)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        courseClass reader = new courseClass();
                        reader.name = "MyCourse" + i;
                        reader.information = "My new Course is about something cool";
                        response.Add(reader);
                    }
                }

                return response;
            }
            catch(SqlException ex)
            {
                courseClass reader = new courseClass();
                reader.courseId = new Guid();
                reader.name = "";
                reader.creator = new Guid();
                reader.company = new Guid();
                reader.created = DateTime.Now;
                reader.status = "";
                reader.information = ex.ToString();
                reader.img = "";
                reader.price = 0;
                reader.currency = "";
                reader.duration = 0;
                reader.durationUnit = "";
                response.Add(reader);
            }
            catch(Exception e)
            {
                // Add error reporting
                courseClass reader = new courseClass();
                reader.courseId = new Guid();
                reader.name = "";
                reader.creator = new Guid();
                reader.company = new Guid();
                reader.created = DateTime.Now;
                reader.status = "";
                reader.information = e.ToString();
                reader.img = "";
                reader.price = 1;
                reader.currency = "";
                reader.duration = 1;
                reader.durationUnit = "";
                response.Add(reader);
            }
            return response;
        }
        
        public string updateString(string id, courseUpdate course)
        {
            if (id == null || id.Length <= 0) { return "courseIdNull"; }
            Guid courseId = new Guid(id);
            return update(courseId, course);
        }

        public string update(Guid id, courseUpdate course)
        {
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("UPDATE courseData SET "
                    + " status = @status, "
                    + " information = @information, "
                    + " price = @price, "
                    + " currency = @currency, "
                    + " duration = @duration, "
                    + " durationUnit = @durationUnit "
                    + " WHERE courseId = @courseId"
                    , con);
                cmd.Parameters.AddWithValue("@status", course.status);
                cmd.Parameters.AddWithValue("@information", course.information);
                cmd.Parameters.AddWithValue("@price", course.price);
                cmd.Parameters.AddWithValue("@currency", course.currency);
                cmd.Parameters.AddWithValue("@duration", course.duration);
                cmd.Parameters.AddWithValue("@durationUnit", course.durationUnit);
                cmd.Parameters.AddWithValue("@courseId", id);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
                return "Success";
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }
            catch
            {
                return "Error";
            }
        }

        public string deleteString(string courseId, string user)
        {
            if(courseId == null || courseId.Length <= 0) { return "courseIdNull"; }
            if (user == null || user.Length <= 0) { return "userNull"; }
            string response = "";

            try
            {
                courseDelete del = new courseDelete();
                del.courseId = new Guid(courseId);
                del.user = new Guid(user);
                response = delete(del);
            }
            catch
            {
                response = "Error";
            }

            return response;
        }

        public string delete(courseDelete use)
        {
            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("DELETE FROM courseData WHERE courseId = @courseId", con);
            cmd.Parameters.AddWithValue("@courseId", use.courseId);
            string response = "Success";

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                response = ex.ToString();
                con.Close();
                return response;
            }
            con.Close();

            try
            {
                parentDeleteAll pare = new parentDeleteAll();
                pare.courseId = use.courseId;
                pare.user = use.user;
                IparentClient client = new IparentClient();
                response = client.deleteAll(pare);
            }
            catch(Exception ex)
            {
                response = ex.ToString();
            }

            return response;
        }
    }
}
