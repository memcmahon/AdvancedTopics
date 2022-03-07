namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occured.");
            }
            
        }
    }
}