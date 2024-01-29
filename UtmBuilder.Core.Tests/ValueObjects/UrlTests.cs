using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exception;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    [TestMethod(displayName: "Deve retornar exceção quando URL for inválida.")]
    //[TestCategory("Testes de URL")]
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

    [TestMethod(displayName: "Deve retornar exceção quando URL for inválida.")]
    [ExpectedException(typeof(InvalidUrlException))]
    //[TestCategory("Testes de URL")]
    public void ExpectedExceptionWhenUrlIsInvalid()
    {
        new Url("qualquer-coisa-que-nao-seja-url-valida");
    }

    [TestMethod(displayName: "Não deve retornar exceção quando URL for válida.")]
    //[TestCategory("Testes de URL")]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
        var url = new Url("https://balta.io");
        Assert.IsTrue(true);
    }
}
