using Microsoft.AspNetCore.Identity;

namespace Ksiegarnia.Models
{
    public class ManageUserRolesViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public List<string> UserRoles { get; set; } = new List<string>();
    }
}
