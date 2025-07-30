namespace Assignment_4._1._2
{
    public class MyMath : ICalculator
    {
        public static double Num1 { get; set; }
        public static double Num2 { get; set; }
        public static string Operator { get; set; }
        public static bool IsNum1Input { get; set; }
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public void SetNumber(string num)
        {
            if (IsNum1Input)
            {
                Num1 = double.Parse(num);
                IsNum1Input = false;
            }
            else
                Num2 = double.Parse(num);
        }
    }
}
