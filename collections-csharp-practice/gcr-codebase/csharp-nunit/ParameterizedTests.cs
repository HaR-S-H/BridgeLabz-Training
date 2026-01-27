[TestFixture]
public class NumberUtilsTests
{
    private NumberUtils utils = new NumberUtils();

    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_Test(int number, bool expected)
    {
        Assert.AreEqual(expected, utils.IsEven(number));
    }
}
    