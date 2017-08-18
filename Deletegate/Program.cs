using System;

namespace Deletegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var videoConverter = new VideoConverter();
            var video = new Video() { Title = "Die Hard" };

            // Action is void delegate (Func() is a return delegate)
            Action<Video> videoConversionHandler = videoConverter.ConvertToMp4;

            videoConversionHandler += videoConverter.ConvertToMkv;

            videoConverter.ConvertVideo(video, videoConversionHandler);
        }
    }
}
