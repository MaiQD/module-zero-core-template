using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Dat.Quiz.EntityFrameworkCore
{
    public static class QuizDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<QuizDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<QuizDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

