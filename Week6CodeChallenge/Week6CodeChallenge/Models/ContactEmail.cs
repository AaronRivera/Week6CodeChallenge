using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week6CodeChallenge.Models
{
    public class ContactEmail
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }



        public string Email { get; set; }

        public string Phone { get; set; }

        public string Company {get; set;}

        public string Project {get; set;}
        public string Message { get; set; }

        public DateTime dateCreates { get; set; }

        public ContactEmail()
        {

        }

        public ContactEmail( string name, string lastName, string email, string phone, string company, string project, string message)
        {
            
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.Company = company;
            this.Project = project;
            this.Message = message;
            
        }
    }
}