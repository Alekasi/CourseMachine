using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using courseBackGround.child;
using System.Configuration;

namespace courseBackGround.parent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "parent" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select parent.svc or parent.svc.cs at the Solution Explorer and start debugging.
    public class parent : Iparent
    {
        private string data = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public bool checkString(string name)
        {
            if(name == null || name.Length <= 0)
            {
                return false;
            }
            int Dr = 1;
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("SELECT * FROM courseParent WHERE name = @name", con);
                cmd.Parameters.AddWithValue("@name", name);

                con.Open();
                Dr = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }

            return Dr <= 0 ? false : true; ;
        }

        public bool check(Guid parentId)
        {
            if (parentId == null)
            {
                return false;
            }
            int Dr = 1;
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("SELECT * FROM courseParent WHERE parentId = @parentId", con);
                cmd.Parameters.AddWithValue("@parentId", parentId);

                con.Open();
                Dr = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }

            return Dr <= 0 ? false : true; ;
        }

        public List<parentClass> readString(string courseId)
        {
            if(courseId == null || courseId.Length <= 0)
            {
                return new List<parentClass>();
            }
            List<parentClass> response = new List<parentClass>();
            Guid id = new Guid(courseId);
            try
            {
                response = read(id);
            }
            catch(Exception ex)
            {
                parentClass add = new parentClass();
                add.name = ex.ToString();
                response.Add(add);
                return response;
            }

            return response;
        }

        public List<parentClass> read(Guid id)
        {
            if(id == null)
            {
                return new List<parentClass>();
            }

            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("SELECT * FROM courseParent WHERE courseId = @courseId", con);
            cmd.Parameters.AddWithValue("@courseId", id);

            List<parentClass> response = new List<parentClass>();
            SqlDataReader Dr;
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                parentClass parent = new parentClass();
                parent.parentId = new Guid(Dr["parentId"].ToString());
                parent.name = Dr["name"].ToString();
                parent.creator = new Guid(Dr["creator"].ToString());
                parent.courseId = new Guid(Dr["courseId"].ToString());

                child.child read = new child.child();
                parent.child = read.read(parent.parentId);

                response.Add(parent);
            }
            con.Close();

            return response;
        }

        public string createString(string name, string user, string courseId)
        {
            if(name == null || name.Length <= 0){ return "Name Null"; }
            if (user == null || user.Length <= 0) { return "user Null"; }
            if (courseId == null || courseId.Length <= 0) { return "courseId Null"; }
            string response = "Error";
            try
            {
                parentCreate creator = new parentCreate();
                creator.name = name;
                creator.user = new Guid(user);
                creator.courseId = new Guid(courseId);
                response = create(creator);
            }
            catch
            {
                return response + 2;
            }
            return response;
        }

        public string create(parentCreate parent)
        {
            Guid parentId = Guid.NewGuid();

            try{
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("INSERT INTO courseParent (parentId, name, creator, courseId) VALUES (@parentId, @name, @creator, @courseId)", con);
                cmd.Parameters.AddWithValue("@parentId", parentId);
                cmd.Parameters.AddWithValue("@name", parent.name);
                cmd.Parameters.AddWithValue("@creator", parent.user);
                cmd.Parameters.AddWithValue("@courseId", parent.courseId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }
            catch
            {
                return "Error";
            }

            return parentId.ToString();
        }

        public string updateString(string parentId, string name, string user, string courseId)
        {
            string response = "Error";
            try
            {
                if (parentId == null || parentId.Length <= 0) { return "parentId Null"; }
                if (name == null || name.Length <= 0) { return "name Null"; }
                if (user == null || user.Length <= 0) { return "userId Null"; }
                if (courseId == null || courseId.Length <= 0) { return "courseId Null"; }
                parentUpdate par = new parentUpdate();
                par.parentId = new Guid(parentId);
                par.name = name;
                par.user = new Guid(user);
                par.courseId = new Guid(courseId);

                response = update(par);
            }
            catch
            {
                response = "Error";
            }
            return response;
        }

        public string update(parentUpdate parent)
        {
            string response = "";
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("UPDATE courseParent SET name = @name WHERE parentId = @parentId AND courseId = @courseId", con);
                cmd.Parameters.AddWithValue("@name",parent.name);
                cmd.Parameters.AddWithValue("@parentId", parent.parentId);
                cmd.Parameters.AddWithValue("@courseId", parent.courseId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                response = "Success";
            }
            catch (SqlException ex)
            {
                response = ex.ToString();
            }
            catch
            {

            }
            return response;
        }
        
        public string deleteString(string parentId, string user)
        {
            string response = "";
            try
            {
                parentDelete del = new parentDelete();
                del.parentId = new Guid(parentId);
                del.user = new Guid(user);
                response = delete(del);
            }
            catch
            {
                response = "Error";
            }
            return response;
        }

        public string delete(parentDelete use)
        {
            string response = "Error";
            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("DELETE FROM courseParent WHERE parentId = @parentId", con);
            cmd.Parameters.AddWithValue("@parentId", use.parentId);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                response = "Success";
            }
            catch(SqlException ex)
            {
                response = ex.ToString();
            }
            con.Close();

            return response;
        }

        public string deleteAllString(string courseId, string user)
        {
            string response = "";
            try
            {
                parentDeleteAll del = new parentDeleteAll();
                del.courseId = new Guid(courseId);
                del.user = new Guid(user);
                response = deleteAll(del);
            }
            catch
            {
                response = "Error";
            }

            return response;
        }

        public string deleteAll(parentDeleteAll use)
        {
            string response = "";

            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("DELETE FROM courseParent WHERE courseId = @courseId", con);
            cmd.Parameters.AddWithValue("@courseId", use.courseId);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                response = "Success";
            }
            catch
            {
                response = "Error";
            }
            con.Close();

            return response;
        }

        //  Settings

        public parentOptions readOptions(Guid parentId, Guid user)
        {
            return new parentOptions();
        }

        public string updateOptions(Guid parentId, parentOptions options, Guid user)
        {
            string response = "";
            return response;
        }

        private void deleteOptions(Guid parentId, Guid user)
        {

        }
    }
}
