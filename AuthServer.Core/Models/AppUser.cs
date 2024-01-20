using Microsoft.AspNetCore.Identity;
using System;

namespace AuthServer.Core.Models
{
    public class AppUser : IdentityUser<string>
    {
        public override string Id { get; set; } = Guid.NewGuid().ToString();
        public string City { get; set; }
    }
}
