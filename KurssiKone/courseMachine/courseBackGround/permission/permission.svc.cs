using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

//using courseBackGround.errorReference;

namespace courseBackGround.permission
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "permission" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select permission.svc or permission.svc.cs at the Solution Explorer and start debugging.
    public class permission : Ipermission
    {
        private string data = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        
        public List<permissionClass> getPermission(Guid courseId, Guid user)
        {
            List<permissionClass> response = new List<permissionClass>();
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("SELECT * FROM permissions WHERE " +
                    " courseId = @courseId", con);
                cmd.Parameters.AddWithValue("@courseId", courseId);

                con.Open();
                SqlDataReader Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    permissionClass perm = new permissionClass();
                    perm.permissionId = new Guid(Dr["permissionId"].ToString());
                    perm.courseId = new Guid(Dr["courseId"].ToString());
                    perm.name = Dr["name"].ToString(); ;
                    perm.creator = new Guid(Dr["creator"].ToString());
                    perm.created = new DateTime(Convert.ToInt32(Dr["created"].ToString()));
                    string permissions = Dr["permissions"].ToString();
                    List<Guid> list = new List<Guid>();
                    response.Add(perm);
                }

                con.Close();

            }
            catch
            {

            }

            return response;
        }

        public Guid createPermission(Guid courseId, string name, int type, Guid creator, List<Guid> permissions)
        {
            Guid permission = Guid.NewGuid();
            if (name.Length <= 3) return new Guid();
            if (type > 3) return new Guid();
            if(type != 0)
            {
                if (permissions.Count <= 0)
                {
                    permissions.Add(courseId);
                }
            }
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("INSERT INTO permissions "
                    + "(permissionId, courseId, name, type, permissions, creator) "
                    + "VALUES (@id, @course, @name, @type, @list, @creator)", con);
                cmd.Parameters.AddWithValue("@id", permission);
                cmd.Parameters.AddWithValue("@course", courseId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@list", permissions);
                cmd.Parameters.AddWithValue("@creator", creator);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                
                return new Guid();
            }

            return permission;
        }

        public int updatePermission(Guid permissionId, Guid user, string name, int type, List<Guid> permissions)
        {
            int response = 0;
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("UPDATE permissions " +
                    "SET name = @name, type = @type, list = @list, creator = @creator " +
                    "WHERE permissionId = @permission", con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@list", permissions.ToString());
                cmd.Parameters.AddWithValue("@creator", user);
                cmd.Parameters.AddWithValue("@permission", permissionId);

                con.Open();
                response = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                response = 0;
            }

            return response;
        }

        public int deletePermission(Guid permissionId, Guid user)
        {
            int response = 0;
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("DELETE FROM permissions WHERE permissionId = @permission", con);
                cmd.Parameters.AddWithValue("@permission", permissionId);

                con.Open();
                response = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {

            }
            return response;
        }

        public string doStuff()
        {
            string response = "";
            List<Guid> guids = new List<Guid>();
            for(int i = 0; i < 5; i++)
            {
                guids.Add(new Guid());
            }
            response = createPermission(new Guid(), "New Permission", 1, new Guid(), guids).ToString();
            return response;
        }

        //  userStuff and all

        public string setUserPermission()
        {
            return "";
        }

        public string deleteUserPermission()
        {
            return "";
        }





    }
}
