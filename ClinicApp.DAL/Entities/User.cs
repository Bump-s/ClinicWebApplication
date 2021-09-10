using Microsoft.AspNetCore.Identity;
using System;

namespace ClinicApp.DAL.Entities
{
    public class User : IdentityUser<Guid>
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
