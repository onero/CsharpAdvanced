using System;
using Deletegate;

namespace Events
{
    public class SlackNotification : INotification
    {
        public void OnVideoConverted(object sender, Video video)
        {
            Console.WriteLine($"Slack notification {video.Title} converted");
        }
    }
}