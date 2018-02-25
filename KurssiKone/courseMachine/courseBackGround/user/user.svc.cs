using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace courseBackGround
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "user" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select user.svc or user.svc.cs at the Solution Explorer and start debugging.
    public class user : Iuser
    {
        private string data = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public int checkEmail(string email)
        {
            try
            {

                if (email == null || email.Length <= 0)
                {
                    return 1;
                }
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE email = @email", con);
                cmd.Parameters.AddWithValue("@email", email);
                SqlDataReader Dr;
                con.Open();
                Dr = cmd.ExecuteReader();
                int response = 1;
                if (Dr.HasRows)
                {

                }else
                {
                    response = 0;
                }
                con.Close();

                return response;
            }
            catch (SqlException ex)
            {
                return 3;
            }
            catch
            {
                return 2;
            }
        }

        public string userRegister(register use)
        {
            try
            {
                int emailCheck = checkEmail(use.email);
                if (emailCheck == 1)
                {
                    return "EmailAllreadyInUse";
                }
                else if (emailCheck == 2)
                {
                    return "Error";
                }
                else if (emailCheck == 3)
                {
                    return "sqlError";
                }
                Guid userId = Guid.NewGuid();
                string userName = use.email.Split('@')[0].ToString();

                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("INSERT INTO users (userId, userName, email) VALUES (@id, @name, @email)", con);
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@name", userName);
                cmd.Parameters.AddWithValue("@email", use.email);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return userId.ToString();
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        public string userLogin(login use)
        {
            int emailCheck = checkEmail(use.user);
            if (emailCheck == 1)
            {
                return "EmailAllreadyInUse";
            }
            else if (emailCheck == 2)
            {
                return "Error";
            }
            else if (emailCheck == 3)
            {
                return "sqlError";
            }

            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE email = @email && password = @password && emailconfirmed != 0", con);
            cmd.Parameters.AddWithValue("@email", use.user);
            cmd.Parameters.AddWithValue("@password", use.password);

            SqlDataReader Dr;
            con.Open();
            Dr = cmd.ExecuteReader();
            if (!Dr.Read())
            {
                return "NotRegistered";
            }
            Dr.Read();
            string userId = Dr["userId"].ToString();
            con.Close();

            return userId;
        }
    }
}
