// Notes
// A lambda is an anonymous method - it has no access modifier, name, or return statement.
// We use them for convenience.

// Syntax: args => expression
//       : () => ...
//       : x => ...
//       : (x, y, z) => ...

// to use a lambda, we need to assign it to a delegate

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // <arg, return value>
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(55));
        }

        //static int Square(int number)
        //{
        //    return number * number;
        //}
    }
}
