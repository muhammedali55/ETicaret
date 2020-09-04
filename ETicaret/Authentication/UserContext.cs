using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Authentication
{
    public class UserContext: IdentityDbContext<User>
    {

        public UserContext() { 
        
        }

        public UserContext(DbContextOptions<UserContext> options): base(options) { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    ("Data Source=DESKTOP-G3OBBSA;Initial Catalog=DBIdentityUser;" +
                    "User ID=muhammedali55;Password=Ankara06*;" +
                    "Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}
