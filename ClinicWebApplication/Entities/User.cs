using ClinicWebApplication.Enums;
using System;

namespace ClinicWebApplication.Entities
{
    public abstract class User
    {
        public Guid Id { get; set; }
        public Role Role { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
