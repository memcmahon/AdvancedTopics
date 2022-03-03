namespace Delegates
{
    public class PhotoFilters
    {
        public PhotoFilters()
        {
        }

        internal void ApplyBrightness(object photo)
        {
            Console.WriteLine("Applying Brightness");
        }

        internal void ApplyContrast(object photo)
        {
            Console.WriteLine("Applying Contrast");
        }

        internal void Resize(object photo)
        {
            Console.WriteLine("Resizing");
        }
    }
}