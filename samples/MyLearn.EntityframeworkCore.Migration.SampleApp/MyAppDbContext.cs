
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MyLearn.EntityframeworkCore.Migrations.SampleApp
{
    public class MyAppDbContext : MyLearnDbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}