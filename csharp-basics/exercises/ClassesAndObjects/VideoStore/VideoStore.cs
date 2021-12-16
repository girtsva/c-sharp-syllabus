using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        List<Video> videos;

        public VideoStore()
        {
            videos = new List<Video>();
        }

        public void AddVideo(string title)
        {
            videos.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            GetVideo(title).BeingCheckedOut();
        }

        public void ReturnVideo(string title)
        {
            GetVideo(title).BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            GetVideo(title).ReceivingRating(rating);
        }

        public void ListInventory()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Title                               |  Rtg | Available");
            Console.WriteLine("------------------------------------------------------");
            foreach (var video in videos)
            {
                Console.WriteLine(video.ToString());
            }
            Console.WriteLine("------------------------------------------------------");
        }

        public Video GetVideo(string title)
        {
            foreach (var video in videos)
            {
                if (video.Title == title)
                {
                    return video;
                }
            }
            return null;  // console.writeline ielikt pirms tam, ka neatrada tadu???
        }
    }
}
