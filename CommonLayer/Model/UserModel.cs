using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.Model
{
    public class UserModel
    {
        [Key]
        public int Id
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }
        
        public string LastName
        {
            get; set;
        }

        public string UserName
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public string UserType
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

    }
}
