using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MovieProject.EntityFrameworkCore
{
    public static class MovieProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MovieProjectDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MovieProjectDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
