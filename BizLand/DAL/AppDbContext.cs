using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BizLand.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BizLand.DAL
{
    public class AppDbContext :IdentityDbContext<AppUser>
    {
        AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<SocialMedias> SocialMedias { get; set; }
    }
}
