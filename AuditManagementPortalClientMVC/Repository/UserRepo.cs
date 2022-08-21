using AuditManagementPortalClientMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditManagementPortalClientMVC.Repository
{
    public class UserRepo : IUserRepo
    {
        public List<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
            new User{Name = "Shubhang", Password ="Shubhang123" },
            new User{Name = "Shag", Password ="Shag123" },
            new User{Name = "Sa", Password ="Sa123" },
            new User{Name = "Siddhart", Password ="Siddhart123" },
            new User{Name = "Subah", Password ="Subah123" }
            };
            return users;
        }
    }
}
