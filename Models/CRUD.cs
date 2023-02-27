/*using HospitalManagement.Migrations;*/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class CRUD
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EcomContext"].ToString());

        public string insertRecord(string id,string role)
        {
            SqlCommand cmd = new SqlCommand("insert into AspNetUserroles values('"+id+"','"+role+"')", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "Success Insertion in AspNetUserroles";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        public string FetchUserTypeInAspNetUsers(string Email)
        {
            string query = $"select User_type from AspNetUsers where Email='{Email}'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            string UserType = "";

            foreach (DataRow drow in dt.Rows)
            {
                UserType = (drow["User_type"]).ToString();

            }

            return UserType;
        }
    }
}