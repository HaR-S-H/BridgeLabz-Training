[TestFixture]
public class StringUtilsTests
{
    private StringUtils utils = new StringUtils();

    [Test] public void Reverse_Test() => Assert.AreEqual("olleh", utils.Reverse("hello"));
    [Test] public void Palindrome_True_Test() => Assert.IsTrue(utils.IsPalindrome("madam"));
    [Test] public void Palindrome_False_Test() => Assert.IsFalse(utils.IsPalindrome("hello"));
    [Test] public void ToUpper_Test() => Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
}
