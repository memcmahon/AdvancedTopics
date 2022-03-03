/// Notes
/// Extension methods allow you to add functionality from existing classes
/// 

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is actually a very long message.  Like its a blog post or something.  blah blah blah...";

            var shortenedPost = post.Shorten(2);
            Console.WriteLine(shortenedPost);

            // Most often instead of creating exention methods, we will be using the ones that come from other packages:
            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 18, 12 };
            numbers.Max(); // max is an extensio method.
        }
    }

    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException(nameof(numberOfWords), "must be a positive number");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');
            
            if(words.Length <= numberOfWords)
                return str;
            
            return string.Join(' ', words[0..numberOfWords]);
        }
    }
}

