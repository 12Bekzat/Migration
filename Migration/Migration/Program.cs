using System;

namespace Migration
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var context = new Contex())
      {
        var author = new Author
        {
          FullName = "Абай Кунанбаев",

        };
        var book = new Book
        {
          Name = "Абай жолы",
        };
        var person = new Person
        {
          Name = "Наиль"
        };
        context.SaveChanges();
      }
    }
  }
}
