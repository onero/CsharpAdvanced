using System;
using VideoApp;

namespace Deletegate
{
    internal static class DelegateProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var videoConverter = new VideoConverter();
            var video = new Video() { Title = "Die Hard" };

            // Action is void delegate (Func() is a return delegate)
            Action<Video> videoConversionAction = videoConverter.ConvertToMp4;

            videoConversionAction += videoConverter.ConvertToMkv;

            videoConverter.ConvertVideo(video, videoConversionAction);
        }
    }
}
