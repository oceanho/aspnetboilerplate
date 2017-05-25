using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLearn.EntityframeworkCore.Migrations
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet
    /// </summary>
    public class MyLearnDbContextFactory<TDbContext> : IDbContextFactory<TDbContext>
        where TDbContext : MyLearnDbContext
    {
        public TDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<TDbContext>();
            var context = (TDbContext)Activator.CreateInstance(typeof(TDbContext), new object[] { builder.Options });
            context.ConnectionString = GetConectionString();
            return context;
        }

        public virtual string GetConectionString()
        {
            return "Server=localhost;User Id=root;Password=123456;Database=mylearn";
        }
    }
}
