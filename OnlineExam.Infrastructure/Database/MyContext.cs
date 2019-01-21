using System;
using Microsoft.EntityFrameworkCore;
using OnlineExam.Core.Entities;

namespace OnlineExam.Infrastructure.Database
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            :base(options)
        {
        }

        public DbSet<Examinees> Examinees { get; set; }
    }
}
