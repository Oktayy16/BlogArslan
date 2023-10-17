using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArslan.Data.Concrete
{
    public class User :IdentityUser
    {
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<BlogEntry>? BlogEntries { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
