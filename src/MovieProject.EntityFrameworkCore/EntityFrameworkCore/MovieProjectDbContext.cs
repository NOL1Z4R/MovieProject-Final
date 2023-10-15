using System;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MovieProject.Authorization.Roles;
using MovieProject.Authorization.Users;
using MovieProject.Entities;
using MovieProject.MultiTenancy;

namespace MovieProject.EntityFrameworkCore
{
    public class MovieProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MovieProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public MovieProjectDbContext(DbContextOptions<MovieProjectDbContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
    }
}
