using Microsoft.AspNetCore.Identity;

namespace AuthServer.Core.Models
{
    public class AppUser : IdentityUser<string>
    {
        public string City { get; set; }
    }
}
