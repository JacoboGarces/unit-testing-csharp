using Biblioteca.Models;
using Biblioteca.UseCases;

namespace Test.UseCases
{
  public class GetBooksUseCaseTest
  {
    [Fact]
    public void Execute()
    {
      GetBooksUseCase useCase = new GetBooksUseCase();
      var result = useCase.Execute();

      Assert.IsType<List<Book>>(result);
      Assert.True(result.Count() >= 0);
    }
  }
}
