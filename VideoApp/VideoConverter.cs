using System;

namespace Deletegate
{
    public class VideoConverter
    {
        public void ConvertVideo(Video videoToConvert, Action<Video> conversionHandler)
        {
            conversionHandler(videoToConvert);
        }

        public void ConvertToMp4(Video video)
        {
            Console.WriteLine($"Converting {video.Title} to mp4");
        }

        public void ConvertToMkv(Video video)
        {
            Console.WriteLine($"Converting {video.Title} to Mkv");
        }
    }
}