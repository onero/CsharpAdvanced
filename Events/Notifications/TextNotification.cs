﻿using System;
using Deletegate;

namespace Events.Notifications
{
    public class TextNotification : INotification
    {
        public void OnVideoConverted(object sender, Video video)
        {
            Console.WriteLine($"Text notification: {video.Title} converted");
        }
    }
}