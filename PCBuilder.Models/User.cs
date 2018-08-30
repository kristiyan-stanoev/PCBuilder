using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            this.Builds = new List<PC>();
        }

        public ICollection<PC> Builds { get; set; }
    }
}
