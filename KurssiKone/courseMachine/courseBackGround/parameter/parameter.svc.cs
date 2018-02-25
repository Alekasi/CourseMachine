using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace courseBackGround.parameter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "parameter" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select parameter.svc or parameter.svc.cs at the Solution Explorer and start debugging.
    public class parameter : Iparameter
    {
        private string data = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public List<parameterClass> readString(string childId)
        {
            if(childId == null || childId.Length <= 0)
            {
                return new List<parameterClass>();
            }
            try
            {
                List<parameterClass> response = read(new Guid(childId));
                return response;
            }
            catch(Exception ex)
            {
                List<parameterClass> response = read(new Guid(childId));
                parameterClass parameter = new parameterClass();
                parameter.value = ex.ToString();
                response.Add(parameter);
                return response;
            }
        }

        public List<parameterClass> read(Guid childId)
        {
            List<parameterClass> response = new List<parameterClass>();
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("SELECT * FROM courseParameter WHERE childId = @childId ORDER BY parameterOrder ASC", con);
                cmd.Parameters.AddWithValue("@childId", childId);
                SqlDataReader Dr;
                con.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    parameterClass parameter = new parameterClass();
                    parameter.creator = new Guid(Dr["creator"].ToString());
                    parameter.type = Dr["type"].ToString();
                    parameter.value = Dr["value"].ToString();
                    parameter.parameterId = new Guid(Dr["parameterId"].ToString());
                    parameter.childId = childId;
                    parameter.order = Dr["parameterOrder"].ToString();
                    parameter.status = Dr["status"].ToString();
                    parameter.additional_1 = Dr["additional_1"].ToString();
                    parameter.additional_2 = Dr["additional_2"].ToString();
                    parameter.additional_3 = Dr["additional_3"].ToString();
                    parameter.additional_4 = Dr["additional_4"].ToString();
                    response.Add(parameter);
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                //  Log error
                parameterClass parameter = new parameterClass();
                parameter.value = ex.ToString();
                response.Add(parameter);
            }
            catch(Exception ex)
            {
                //  Log error
                parameterClass parameter = new parameterClass();
                parameter.value = ex.ToString();
                response.Add(parameter);
            }
            return response;
        }

        public string createString(string type, string childId, string creator)
        {
            parametercreate para = new parametercreate();
            string response = "";
            try
            {
                para.type = type;
                para.childId = new Guid(childId);
                para.creator = new Guid(creator);
                response = create(para);
            }
            catch(Exception ex)
            {
                response = "Error:" + ex.ToString();
            }

            return response;
        }

        public string create(parametercreate use)
        {
            Guid parameterId = Guid.NewGuid();
            string response = parameterId.ToString();
            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("INSERT INTO courseParameter(childId, parameterId, type, creator) VALUES (@childId, @parameterId, @type, @creator)", con);
            cmd.Parameters.AddWithValue("@childId", use.childId);
            cmd.Parameters.AddWithValue("@parameterId", parameterId);
            cmd.Parameters.AddWithValue("@type", use.type);
            cmd.Parameters.AddWithValue("@creator", use.creator);
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                response = ex.ToString();
            }
            catch(Exception ex)
            {
                response = ex.ToString();
            }
            con.Close();
            return response;
        }
        
        public string updateString(string childId, string parameterId, string creator, string type, string value, string order, string status)
        {
            string response = "";
            List<parameterClass> list = new List<parameterClass>();
                try
                {
                if (parameterId == null || parameterId.Length <= 5)
                {
                    //  Do Stuff
                    parametercreate para = new parametercreate();
                    para.childId = new Guid(childId);
                    para.creator = new Guid(creator);
                    para.type = type;
                    parameterId = create(para);
                }

                parameterClass parameter = new parameterClass();
                    parameter.childId = new Guid(childId);
                    parameter.parameterId = new Guid(parameterId);
                    parameter.creator = new Guid(creator);
                    parameter.type = type;
                    parameter.value = value;
                    parameter.order = order;

                    list.Add(parameter);
                    response = update(list);
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            return response;
        }
        
        public string update(List<parameterClass> use)
        {
            string response = "";
            if(use.Count() <= 0)
            {
                return "UpdateNull";
            }
            
            SqlConnection con = new SqlConnection(data);
            SqlCommand cmd = new SqlCommand("UPDATE courseParameter SET parameterOrder = @order, value = @value WHERE childId = @childId AND parameterId = @parameterId", con);
            con.Open();
            for(int i = 0; i < use.Count(); i++)
            {
                if (use[i].parameterId == null)
                {
                    //  Do Stuff
                    parametercreate para = new parametercreate();
                    para.childId = use[i].childId;
                    para.creator = use[i].creator;
                    para.type = use[i].type;
                    use[i].parameterId = new Guid(create(para));
                }
                if(use[i].value == null || use[i].value.Length <= 0)
                {
                    continue;
                }

                //  Check if the status of the parameter is delete
                //  if the status is del or delete script will call delete function
                //  else it will just update
                if (use[i].status.Contains("del") || use[i].status.Contains("Del"))
                {
                    parameterDelete del = new parameterDelete();
                    del.creator = use[i].creator;
                    del.parameterId = use[i].parameterId;
                    response += delete(del) +" /n ";
                }else
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@value", use[i].value);
                        cmd.Parameters.AddWithValue("@order", Convert.ToInt32(use[i].order));
                        cmd.Parameters.AddWithValue("@childId", use[i].childId);
                        cmd.Parameters.AddWithValue("@parameterId", use[i].parameterId);
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        response += ex.ToString() + " /n ";
                    }
                    catch (Exception ex)
                    {
                        response += ex.ToString() + " /n ";
                    }
                }
            }
            con.Close();
            return response;
        }

        public string deleteString(string creator, string parameterId)
        {
            string response = "";
            parameterDelete para = new parameterDelete();
            try
            {
                para.creator = new Guid(creator);
                para.parameterId = new Guid(parameterId);
                response = delete(para);
            }
            catch(Exception ex)
            {
                response = ex.ToString();
            }

            return response;
        }

        public string delete(parameterDelete use)
        {
            string response = "Success";
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("DELETE FROM courseParameter WHERE parameterId = @parameterId", con);
                cmd.Parameters.AddWithValue("@parameterId", use.parameterId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(SqlException ex)
            {
                response = ex.ToString();
            }
            catch(Exception ex)
            {
                response = ex.ToString();
            }
            return response;
        }

        public string deleteAllString(string creator, string childId)
        {
            string response = "";
            parameterDeleteAll para = new parameterDeleteAll();
            try
            {
                para.creator = new Guid(creator);
                para.childId = new Guid(childId);
                response = deleteAll(para);
            }
            catch (Exception ex)
            {
                response = ex.ToString();
            }

            return response;
        }

        public string deleteAll(parameterDeleteAll use)
        {
            string response = "Success";
            try
            {
                SqlConnection con = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand("DELETE FROM courseParameter WHERE childId = @childId", con);
                cmd.Parameters.AddWithValue("@childId", use.childId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                response = ex.ToString();
            }
            catch (Exception ex)
            {
                response = ex.ToString();
            }
            return response;
        }
    }
}
