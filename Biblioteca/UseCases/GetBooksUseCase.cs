using Biblioteca.Models;

namespace Biblioteca.UseCases
{
  public class GetBooksUseCase
  {
    public List<Book> Execute()
    {
      return new List<Book>()
      {
        new Book(1, "Libro1", "Desc1", "Auth1"),
        new Book(2, "Libro2", "Desc1", "Auth1"),
        new Book(3, "Libro3", "Desc1", "Auth1"),
        new Book(4, "Libro4", "Desc1", "Auth1"),
        new Book(5, "Libro5", "Desc1", "Auth1"),
      };
    }
  }
}
