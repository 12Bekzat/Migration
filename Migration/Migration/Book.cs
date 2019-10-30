using System;
using System.Collections.Generic;
using System.Text;

namespace Migration
{
  public class Book
  {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public Author Author { get; set; }
    public Person Person { get; set; }
  }
}
