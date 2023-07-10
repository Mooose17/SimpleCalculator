using System;
namespace SimpleCalculator
{
	public class InputConverter
	{
		public double ConvertInputToNumeric(string argTextInput) {
			double convertedNumber;

			bool isConvertedSuccessfully = double.TryParse(argTextInput, out convertedNumber);

            if (!isConvertedSuccessfully) {
				throw new ArgumentException("Expected a numeric value");
			}

            return convertedNumber;

        }
	}
}
