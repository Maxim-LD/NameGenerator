using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator.Model.ViewModel
{
    public class ProfileDetailsUpdateRequestViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
