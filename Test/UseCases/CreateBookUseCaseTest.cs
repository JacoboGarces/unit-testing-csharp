using Biblioteca.Models;
using Biblioteca.UseCases;

namespace Test.UseCases
{
  public class CreateBookUseCaseTest
  {
    [Fact]
    public void ExecuteWithDuplicity()
    {
      CreateBookUseCase useCase = new CreateBookUseCase ();
      Book book = new Book(1, "2", "2", "2");

      var result = useCase.Execute(book);

      Assert.Null(result);
    }

    [Fact]
    public void Execute()
    {
      CreateBookUseCase useCase = new CreateBookUseCase();
      Book book = new Book(19, "2", "2", "2");

      var result = useCase.Execute(book);
      Assert.Equal(book.Id, result?.Id);
    }
  }
}
