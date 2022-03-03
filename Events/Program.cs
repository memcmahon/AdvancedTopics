// Notes

// Events are mechanisms for communication between objects.  Helps build loosely coupled applications.
// Event Sender - Event Receiver
// The receiver doesn't know anything aout the sender.  It just _subscribes_ to that event.
// A Delegate will be the contract between the sender and subscriber.
// Steps:
//  1 - Define a delegate
//  2 - Define an event based on that delegate
//  3 - Raise the event


namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // subscription
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // subscription

            videoEncoder.Encode(video);
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email..." + args.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text..." + args.Video.Title);
        }
    }
}