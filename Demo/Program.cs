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
        }
    }
}
