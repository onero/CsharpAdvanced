using System;
using System.Threading;
using Deletegate;

namespace VideoApp
{
    public class VideoConverter
    {

        public EventHandler<Video> VideoConverted;

        public void ConvertVideo(Video videoToConvert, Action<Video> conversionHandler)
        {
            conversionHandler(videoToConvert);

            OnVideoConverted(videoToConvert);
        }

        public void ConvertToMp4(Video video)
        {
            Console.WriteLine($"Converting {video.Title} to mp4");
        }

        public void ConvertToMkv(Video video)
        {
            Console.WriteLine($"Converting {video.Title} to Mkv");
        }

        /// <summary>
        /// When video is converted 
        /// </summary>
        /// <param name="video"></param>
        protected virtual void OnVideoConverted(Video video)
        {
            Thread.Sleep(5000);
            VideoConverted?.Invoke(this, video);
        }
    }
}