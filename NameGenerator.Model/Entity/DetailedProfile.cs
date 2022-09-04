using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator.Model.Entity
{
    public class DetailedProfile
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
    }
}
