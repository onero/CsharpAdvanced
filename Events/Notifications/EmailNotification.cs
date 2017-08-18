using System;
using System.Threading;
using VideoApp;

namespace Events
{
    public sealed class EmailNotification : INotification
    {
        public void OnVideoConverted(object sender, Video video)
        {
            Console.WriteLine($"Email notification: {video.Title} converted!");
        }
    }
}