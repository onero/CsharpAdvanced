using System;
using System.Threading;
using Deletegate;

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