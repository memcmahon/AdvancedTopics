// Notes
// Delegates are objects that know how to all a method (or a group of methods)
// A delegate is a reference (or pointer) to a function.
// Allows us to create extensible and flexible applications (like frameworks)

// .NET comes with built in delegates - System.Action (for methods that return void) & System.Func (for methods that return object(s))

// Often you could either use an Interface or a Delegate to organize this type of problem.  Generally, use a delegate when:
// - an eventing design pattern is used
// - the caller doesn't need to access other properties or methods on the object implementing the method.

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            // this delegate can include any Method that matches the signature indicated in the delegate declaration.
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
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
