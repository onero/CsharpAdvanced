using System;
using VideoApp;

namespace Events.Notifications
{
    public class SlackNotification : INotification
    {
        public void OnVideoConverted(object sender, Video video)
        {
            Console.WriteLine($"Slack notification {video.Title} converted");
        }
    }
}