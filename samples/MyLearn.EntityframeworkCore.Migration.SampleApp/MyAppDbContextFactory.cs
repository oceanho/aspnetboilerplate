using System;
using System.Collections.Generic;
using System.Text;

namespace MyLearn.EntityframeworkCore.Migrations.SampleApp
{
    public class MyAppDbContextFactory : MyLearnDbContextFactory<MyAppDbContext>
    {
        public override string GetConectionString()
        {
            return "Server=localhost;User Id=root;Password=abc123;Database=mylearn";
        }
    }
}
