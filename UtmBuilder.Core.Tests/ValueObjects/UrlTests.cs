using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exception;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private const string ValidUrl = "https://balta.io";
    private const string InvalidUrl = "banana";

    [TestMethod(displayName: "Deve retornar exceção quando URL for inválida.")]
    //[TestCategory("Testes de URL")]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        try
        {
            var url = new Url(InvalidUrl);
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
        new Url(InvalidUrl);
    }

    [TestMethod(displayName: "Não deve retornar exceção quando URL for válida.")]
    //[TestCategory("Testes de URL")]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
        var url = new Url(ValidUrl);
        Assert.IsTrue(true);
    }


    [TestMethod(displayName: "Não deve retornar exceção quando URL for válida.")]
    [DataRow(ValidUrl, true)]
    [DataRow(InvalidUrl, false)]
    //[TestCategory("Testes de URL")]
    public void TestUrl(string link, bool isValid)
    {
        if (!isValid)
        {
            try
            {
                var url = new Url(link);
                Assert.Fail();
            }
            catch (InvalidUrlException e)
            {
                Assert.IsTrue(true);
            }
        }
        else
        {
            var url = new Url(link);
            Assert.IsTrue(true);
        }

    }
}
