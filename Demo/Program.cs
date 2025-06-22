namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine("You entered: " + number);

            #endregion
            #region Q02
            string str = "123abc";
            int result = Convert.ToInt32(str); // This will throw exception

            #endregion
            #region Q03
            // برنامج بيجمع رقمين عشريين من نوع float
            float a = 5.5f;
            float b = 2.2f;
            float result = a + b;
            Console.WriteLine("Result: " + result);
            #endregion


            #region Q04
            string text = "Hello World";
            string part = text.Substring(6, 5);
            Console.WriteLine(part);

            #endregion
        }
    }
}
