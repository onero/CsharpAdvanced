using System;
using Events.Notifications;
using VideoApp;

namespace Events
{
    internal static class EventProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var videoConverter = new VideoConverter();
            var video = new Video{Title = "Die Hard"};
            var emailNotification = new EmailNotification();
            var slackNotification = new SlackNotification();
            var textNotification = new TextNotification();

            // Add ConvertToMkv action
            Action<Video> videoConversionAction = videoConverter.ConvertToMkv;

            // Add email notification as subscriber to VideoConverted event
            videoConverter.VideoConverted += emailNotification.OnVideoConverted;
            videoConverter.VideoConverted += slackNotification.OnVideoConverted;
            videoConverter.VideoConverted += textNotification.OnVideoConverted;

            // Convert video
            videoConverter.ConvertVideo(video, videoConversionAction);
        }
    }
}
