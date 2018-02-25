using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using courseBackGround.parameterReference;
using courseBackGround.childReference;

namespace courseBackGround.child
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "child" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select child.svc or child.svc.cs at the Solution Explorer and start debugging.
    public class child : Ichild
    {
        private string data = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public List<childClass> readString(string parent)
        {
            return new List<childClass>();
        }

        public List<childClass> read(Guid parent)
        {
            if(parent == null)
            {
                return new List<childClass>();
            }

            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("SELECT * FROM courseChild WHERE parentId = @parentId", con);
                cmd.Parameters.AddWithValue("@parentId", parent);

                SqlDataReader Dr;
                List<childClass> response = new List<childClass>();
                con.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    childClass reader = new childClass();
                    reader.childId = new Guid(Dr["childId"].ToString());
                    reader.name = Dr["name"].ToString();
                    reader.creator = new Guid(Dr["creator"].ToString());
                    reader.parentId = new Guid(Dr["parentId"].ToString());
                    reader.options = readOptions(reader.childId, Guid.NewGuid());
                    response.Add(reader);
                }
                con.Close();
                return response;
            }
            catch
            {
                return new List<childClass>();
            }
        }

        public string createString(string parentId, string name, string user)
        {
            if (parentId.Length <= 0 || parentId == null) { return "parentNull"; }
            if (name.Length <= 0 || name == null) { return "nameNull"; }
            if (user.Length <= 0 || user == null) { return "userNull"; }

            string childId = "ErrorInChild";
            try
            {
                childCreate creator = new childCreate();
                creator.parentId = new Guid(parentId);
                creator.name = name;
                creator.userId = new Guid(user);
                childId = create(creator);
            }
            catch(Exception ex)
            {
                return "ErrorChildString : " + ex.ToString();
            }

            return childId;
        }

        public string create(childCreate use)
        {
            Guid childId = Guid.NewGuid();

            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("INSERT INTO courseChild (childId, parentId, name, creator) VALUES (@childId, @parentId, @name, @creator)", con);
                cmd.Parameters.AddWithValue("@childId", childId);
                cmd.Parameters.AddWithValue("@parentId", use.parentId);
                cmd.Parameters.AddWithValue("@name", use.name);
                cmd.Parameters.AddWithValue("@creator", use.userId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                createOptions(childId, use.userId);
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }
            catch(Exception ex)
            {
                return "ErrorChild : " + ex.ToString();
            }

            return childId.ToString();
        }

        public string updateString(string childId, string name, string user, string parentId)
        {
            if (childId == null || childId.Length <= 0) { return "childId Null"; }
            if (name == null || name.Length <= 0) { return "name Null"; }
            if (user == null || user.Length <= 0) { return "userId Null"; }
            if (parentId == null || parentId.Length <= 0) { return "parentId Null"; }
            string response = "Error";
            try
            {
                childUpdater chil = new childUpdater();
                chil.childId = new Guid(childId);
                chil.name = name;
                chil.userId = new Guid(user);
                chil.parentId = new Guid(parentId);

                response = update(chil);
            }
            catch
            {

            }

            return response;
        }

        public string update(childUpdater child)
        {
            string response = "Error";
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("UPDATE courseChild SET name = @name WHERE childId = @childId AND parentId = @parentId", con);
                cmd.Parameters.AddWithValue("@name", child.name);
                cmd.Parameters.AddWithValue("@childId", child.childId);
                cmd.Parameters.AddWithValue("@parentId", child.parentId);

                con.Open();
                response = cmd.ExecuteNonQuery().ToString();
                con.Close();
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }
            catch
            {
                return response;
            }

            return "Success";
        }

        public string deleteString(string childId, string user)
        {
            string response = "";
            try
            {
                childDelete del = new childDelete();
                del.childId = new Guid(childId);
                del.user = new Guid(user);
                response = delete(del);
            }
            catch
            {
                response = "Error";
            }
            return response;
        }
        
        public string delete(childDelete use)
        {
            string response = "";
            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("DELETE FROM CourseChild WHERE childId = @childId", con);
            cmd.Parameters.AddWithValue("@childId", use.childId);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                response = "Success";
                deleteOptions(use.childId, use.user);
            }
            catch (Exception ex)
            {
                response = ex.ToString();
                con.Close();
                return response;
            }

            con.Close();

            try
            {
                parameterDeleteAll del = new parameterDeleteAll();
                del.childId = use.childId;
                del.creator = use.user;

                IparameterClient para = new IparameterClient();
                response = para.deleteAll(del);
            }
            catch(Exception ex)
            {
                response = ex.ToString();
            }

            return response;
        }

        public string deleteAllString(string parentId, string user)
        {
            string response = "";
            try
            {
                childDeleteAll del = new childDeleteAll();
                del.parentId = new Guid(parentId);
                del.user = new Guid(user);
                response = deleteAll(del);
            }
            catch
            {
                response = "Error";
            }

            return response;
        }

        public string deleteAll(childDeleteAll use)
        {
            string response = "";

            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("DELETE FROM CourseChild WHERE parentId = @parentId", con);
            cmd.Parameters.AddWithValue("@parentId", use.parentId);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                response = "Success";
            }
            catch(Exception ex)
            {
                response = ex.ToString();
                con.Close();
                return response;
            }
            con.Close();

            try
            {
                childReference.childDeleteAll del = new childReference.childDeleteAll();
                del.parentId = use.parentId;
                del.user = use.user;
                IchildClient child = new IchildClient();
                response = child.deleteAll(del);
            }
            catch(Exception ex)
            {
                response = ex.ToString();
            }

            return response;
        }

        //  Settings

        public void createOptions(Guid child, Guid user)
        {
            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("INSERT INTO options (Id, type, typeId, lastModifier) VALUES (@id, @type, @child, @lastModifier)", con);
            cmd.Parameters.AddWithValue("@id", Guid.NewGuid());
            cmd.Parameters.AddWithValue("@type", "child");
            cmd.Parameters.AddWithValue("@child", child);
            cmd.Parameters.AddWithValue("@lastModifier", user);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //  Giver error reporting
            }
            con.Close();
        }

        public childOptions readOptions(Guid child, Guid user)
        {
            if(child == null || user == null)
            {
                return new childOptions();
            }
            childOptions options = new childOptions();

            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("SELECT * FROM parentOptions WHERE type = 'child' AND typeId = @childId", con);
            cmd.Parameters.AddWithValue("@childId", child);

            con.Open();
            try
            {
                SqlDataReader Dr = cmd.ExecuteReader();
                options.childId = new Guid(Dr["typeId"].ToString());
                options.user = new Guid(Dr["lastModifier"].ToString());
                options.releaseDate = Dr["openDate"] == null ? DateTime.Now : DateTime.Parse(Dr["openDate"].ToString());
                options.releaseDates = Convert.ToInt32(Dr["openAfterDays"]);
                Dr.Close();
            }
            catch(SqlException ex)
            {

            }catch(Exception ex)
            {

            }
            con.Close();

            return options;
        }

        public string updateOptions(childOptions options)
        {
            string response = "";

            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("UPDATE options SET lastModifier = @user, openDate = @openDate, openAfterDays = @openAfter WHERE type = @type, typeId = @childId", con);

            return response;
        }

        private void deleteOptions(Guid child, Guid user)
        {

        }
    }
}
