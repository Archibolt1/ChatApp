using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.Data
{
    public class AspNetUsers : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
