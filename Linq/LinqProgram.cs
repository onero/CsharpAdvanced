using System;
using System.Collections.Generic;
using System.Linq;
using VideoApp;

namespace Linq
{
    static class LinqProgram
    {
        static void Main(string[] args)
        {
            var videos = new List<Video>
            {
                new Video {Title = "Video 1"},
                new Video {Title = "Video 2"},
                new Video {Title = "Video 3"}
            };

            // Linq Query Operators
            var operatorAscendingBookTitles =
                from video in videos
                orderby video.Title
                select video.Title;

            foreach (var operatorDescendingBookTitle in operatorAscendingBookTitles)
            {
                Console.WriteLine(operatorDescendingBookTitle);
            }

            //Linq Extension Methods
            var methodDescendingBookTitles = videos
                .OrderByDescending(b => b.Title)
                .Select(b => b.Title);

            foreach (var methodDescendingBookTitle in methodDescendingBookTitles)
            {
                Console.WriteLine(methodDescendingBookTitle);
            }



        }
    }
}