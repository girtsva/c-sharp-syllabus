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
            var video = GetVideo(title);
            if (video != null)
            {
                video.BeingCheckedOut();
            }
            else
            {
                return;
            }
        }

        public void ReturnVideo(string title)
        {
            var video = GetVideo(title);
            if (video != null)
            {
                video.BeingReturned();
            }
            else
            {
                return;
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            var video = GetVideo(title);
            if (video != null && rating != 0)
            {
                video.ReceivingRating(rating);
            }
            else
            {
                return;
            }
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
            Console.WriteLine("Video not found!");
            return null;
        }
    }
}
