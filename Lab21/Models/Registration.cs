using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Lab21.Models
{
    public class Registration
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
        [Range(1,100)]
        public int age { get; set; }


        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string confirm { get; set; }


    }

    public class DBRegistrationContext : DbContext
    {
        public DbSet<Registration> Users { get; set; }

    }


}