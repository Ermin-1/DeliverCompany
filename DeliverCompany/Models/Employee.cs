using Microsoft.AspNetCore.Identity;

namespace DeliverCompany.Models
{
    public class Employee : IdentityUser
    {
        public string Name { get; set; }
     
    }
}
