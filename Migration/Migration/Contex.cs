using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migration
{
  public class Contex : DbContext
  {
    public Contex()
    {
      Database.Migrate();
    }

    DbSet<Person> People { get; set; }
    DbSet<Author> Authors { get; set; }
    DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=A-305-07;Database=MigrationTestHomework;Trusted_Connection=True;");
    }
  }
}
