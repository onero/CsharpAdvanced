using System;
using VideoApp;

namespace Events.Notifications
{
    public sealed class EmailNotification : INotification
    {
        public void OnVideoConverted(object sender, Video video)
        {
            Console.WriteLine($"Email notification: {video.Title} converted!");
        }
    }
}