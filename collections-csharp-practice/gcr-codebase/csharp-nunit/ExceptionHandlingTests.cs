[Test]
public void Divide_ByZero_ShouldThrow()
{
    var math = new MathOperations();
    Assert.Throws<ArithmeticException>(() => math.Divide(10, 0));
}
