namespace SimpleCalculator.Test.Unit;

[TestClass]
public class CalculatorEngineTest
{
    private readonly CalculatorEngine _calulatorEngine = new CalculatorEngine();

    [TestMethod]
    public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
    {
        int number1 = 1;
        int number2 = 2;
        double result = _calulatorEngine.Calculate("add", number1, number2);
        double expected = 3;
        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
    {
        int number1 = 1;
        int number2 = 2;
        double result = _calulatorEngine.Calculate("+", number1, number2);
        double expected = 3;
        Assert.AreEqual(expected, result);
    }
}
