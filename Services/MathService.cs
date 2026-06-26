namespace RestWithASPNET10Study.Services
{
    public class MathService
    {
        public decimal Sum(decimal firstNumber, decimal secondNumber)
            => firstNumber + secondNumber;
        public decimal Media(decimal firstNumber, decimal secondNumber)
            => (firstNumber + secondNumber) / 2;
        public double Square(decimal number)
        {
            if (number < 0) throw new ArgumentException(
                    "Cannot calculate the square root of a negative number.");
            return Math.Sqrt((double)number);
        }

    }
}
