using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Week6CodeChallenge.Models
{
    public class ContactDataAccess
    {
        public static bool InsertContactForm(ContactEmail contractFormvalues)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                //declares a variable for the scope of the code block
                con.Open(); //opens the conection to the database
                try
                {
                    //sql call
                    SqlCommand command = new SqlCommand("insert into ContactForm (name, lastName, email,phone, company, project, message) values (@name,@lastName,@email,@phone,@company,@project,@message)", con);
                    command.Parameters.Add(new SqlParameter("name", contractFormvalues.Name));
                    command.Parameters.Add(new SqlParameter("lastName", contractFormvalues.Name));
                    command.Parameters.Add(new SqlParameter("email", contractFormvalues.Email));
                    command.Parameters.Add(new SqlParameter("phone", contractFormvalues.Phone));
                    command.Parameters.Add(new SqlParameter("company", contractFormvalues.Name));
                    command.Parameters.Add(new SqlParameter("project", contractFormvalues.Name));
                    command.Parameters.Add(new SqlParameter("message", contractFormvalues.Message));
                    command.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

        }

    }
}