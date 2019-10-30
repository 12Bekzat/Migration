using System;

namespace Migration
{
  public class Author
  {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; }
    public Book Book { get; set; }
  }
}