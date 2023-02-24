using HospitalManagement.Migrations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
    }
}