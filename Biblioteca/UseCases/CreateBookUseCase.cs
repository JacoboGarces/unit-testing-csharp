using Biblioteca.Models;

namespace Biblioteca.UseCases
{
  public class CreateBookUseCase
  {
    public List<Book> _books = new List<Book>()
      {
        new Book(1, "Libro1", "Desc1", "Auth1"),
        new Book(2, "Libro2", "Desc1", "Auth1"),
        new Book(3, "Libro3", "Desc1", "Auth1"),
        new Book(4, "Libro4", "Desc1", "Auth1"),
        new Book(5, "Libro5", "Desc1", "Auth1"),
      };

    public Book? Execute(Book book)
    {
      if (_books.Find((_book) => _book.Id.Equals(book.Id)) != null) return null;

      _books.Add(book);
      return book;
    }
  }
}
