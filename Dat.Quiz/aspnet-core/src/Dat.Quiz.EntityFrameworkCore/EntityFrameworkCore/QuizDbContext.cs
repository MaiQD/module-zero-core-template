using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dat.Quiz.Authorization.Roles;
using Dat.Quiz.Authorization.Users;
using Dat.Quiz.MultiTenancy;

namespace Dat.Quiz.EntityFrameworkCore
{
    public class QuizDbContext : AbpZeroDbContext<Tenant, Role, User, QuizDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public QuizDbContext(DbContextOptions<QuizDbContext> options)
            : base(options)
        {
        }
    }
}

