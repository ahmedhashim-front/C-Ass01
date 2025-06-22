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
            #region Q05
            int a5 = 10;
            int b5 = a5;
            b5 = 20;

            Console.WriteLine("a = " + a5);
            Console.WriteLine("b = " + b5);

             // اللي هيحصل:
             //هتفضل قيمة a5زي ماهي 10 
             // لاننا لما عملنا b5 = a5 مغيرناش قيمه a5 
             // وقيمة المتغير b هتبقى 20 بعد التعديل.
             // ولما نسخنا a5 إلى b5، كل واحد بقى له نسخة مستقلة من القيمة.


            #endregion
        }
    }
}
