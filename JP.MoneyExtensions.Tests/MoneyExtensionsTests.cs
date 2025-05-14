namespace JP.MoneyExtensions.Tests;

[TestClass]
public class MoneyExtensionsTest
{
    [TestMethod]
    public void ShouldConvertDecimalToInteger()
    {  
        decimal value = 297.40m;
        int result = value.ToCents();

        Assert.AreEqual(29740, result);
    }
}