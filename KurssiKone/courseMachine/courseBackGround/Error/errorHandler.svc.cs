using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace courseBackGround.Error
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "errorHandler" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select errorHandler.svc or errorHandler.svc.cs at the Solution Explorer and start debugging.
    public class errorHandler : IerrorHandler
    {
        private string data = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public void createError(string origin, string message)
        {
            origin = origin.Length <= 0 ? "" : origin;
            message = message.Length <= 0 ? "" : message;

            errorClass error = new errorClass();
            try
            {
                error.errorId = Guid.NewGuid();
                error.origin = origin;
                error.message = message;

                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("INSERT INTO errors (errorId, origin, message) VALUES (@error, @origin, @message)", con);
                cmd.Parameters.AddWithValue("@error", error.errorId);
                cmd.Parameters.AddWithValue("@origin", error.origin);
                cmd.Parameters.AddWithValue("@message", error.message);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }
        }
    }
}
