namespace SimpleCalculator.Test.Unit;

[TestClass]
public class InputConverterTest
{
    private readonly InputConverter _inputConverter = new InputConverter();

    [TestMethod]
    public void ConvertValidStringInputIntoDouble() {
        string inputNumber = "5";
        double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
        int expected = 5;

        Assert.AreEqual(expected, convertedNumber);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void FailsToConvertInvalidStringInputIntoDouble() {

        string inputNumber = "egg";
        double convertedNumer = _inputConverter.ConvertInputToNumeric(inputNumber);
    }
        

}
