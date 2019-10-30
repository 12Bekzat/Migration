using System;
using System.Collections;
using System.Collections.Generic;

namespace Migration
{
  public class Person
  {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>();
  }
}