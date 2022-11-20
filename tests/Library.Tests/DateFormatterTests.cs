using TestDateFormat;
namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FechaCorrecta()
    {
        string fecha = "05/07/2007";
        string resultado = "2007-07-05";
        Assert.AreEqual(resultado, DateFormatter.ChangeFormat(fecha));
    }

    [Test]
    public void FechaInvalida()
    {
        string fecha = "aehdroijgjvreoigwjo";
        string resultado = "La fecha ingresada es inválida.";
        Assert.AreEqual(resultado, DateFormatter.ChangeFormat(fecha));
    }

    [Test]
    public void FechaVacia()
    {
        string fecha = "";
        string resultado = "La fecha ingresada es inválida.";
        Assert.AreEqual(resultado, DateFormatter.ChangeFormat(fecha));
    }

    [Test]
    public void FechaAlReves()
    {
        string fecha = "1997-07-10";
        string resultado = "10/07/1997";
        Assert.AreEqual(resultado, DateFormatter.ChangeFormat(fecha));
    }
}