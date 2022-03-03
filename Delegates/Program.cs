// Notes
// Delegates are objects that know how to all a method (or a group of methods)
// A delegate is a reference (or pointer) to a function.
// Allows us to create extensible and flexible applications (like frameworks)

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Red Eye Removed");
        }
    }
}
