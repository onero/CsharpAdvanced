using Deletegate;

namespace Events
{
    public interface INotification
    {
        /// <summary>
        /// React on video converted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="video"></param>
        void OnVideoConverted(object sender, Video video);
    }
}