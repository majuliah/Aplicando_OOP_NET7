using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    [TestMethod("Deve retornar uma exceção quando URL for inválida")]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        new Url("");
    }
    
    [TestMethod]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
        new Url("https://maju.io");
        Assert.IsTrue(true);
    }
}