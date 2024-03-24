using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    [TestMethod("Deve retornar uma exceção quando URL for inválida")]
    [TestCategory("Teste de URL")]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        try
        {
            var url = new Url("");
            Assert.Fail();
        }
        catch (InvalidUrlException e)
        {
            Assert.IsTrue(true);
        }
    }
    
    [TestMethod]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
        Assert.Fail();
    }
}