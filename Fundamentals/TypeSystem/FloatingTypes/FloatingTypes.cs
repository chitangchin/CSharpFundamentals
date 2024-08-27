namespace Fundamentals.TypeSystem.FloatingTypes
{
    public class FloatingTypes
    {
        public static string Solution()
        {
            //Float can be implicitly converted to double
            //Integral types can be converted to decimal
            //Decimal cannot be turned into float or double, you must convert atleast one variable to decimal to perform operations
            double a = 1.0;
            decimal b = 2.1m;
            float f = 123.45E-2f;//exponent to -2 moves the decimal place twice forward
            double db = 1.111e2;//Outputs to 111.1 moves decimal placed twice forward
            decimal dl = 1.5E6m;//Outputs expoent 10^6 moves decimal place back 6 times: 1500000

            /*
             * Decimal: E(negative or none)(number)m
             * Double: e(negative or none)(number)
             * float: E(negative or none)(number)f
             * 
             * ONLY One implicit conversion available: float to double
             */

            return $"Decimal Arithmetic: {(decimal)a + b}, {a + (double)b}, {f}, {db}, {dl}";
        }
    }
}
