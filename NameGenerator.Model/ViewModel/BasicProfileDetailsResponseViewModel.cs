using System;

namespace NameGenerator.Model.ViewModel
{
    public class BasicProfileDetailsResponseViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
