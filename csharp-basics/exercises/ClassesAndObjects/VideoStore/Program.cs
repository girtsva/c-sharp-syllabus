using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Program
    {
        private const int _countOfMovies = 3;
        private static VideoStore _videoStore = new VideoStore();
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to leave a rating (as user)");
                Console.WriteLine("Choose 5 to list inventory");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        LeaveRating();
                        break;
                    case 5:
                        ListInventory();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            _videoStore.ListInventory();
        }

        private static void FillVideoStore()
        {
            for (var i = 0; i < _countOfMovies; i++)
            {
                string movieName = EnterMovie();
                _videoStore.AddVideo(movieName);

                LeaveRating(movieName);
            }
        }

        private static void RentVideo()
        {
            _videoStore.Checkout(EnterMovie());
        }

        private static void ReturnVideo()
        {
            _videoStore.ReturnVideo(EnterMovie());
        }

        private static string EnterMovie()
        {
            Console.Write("Enter movie name: ");
            string movieName = Console.ReadLine();
            return movieName;
        }

        private static void LeaveRating()
        {
            string movieName = EnterMovie();
            Console.Write("Enter rating: ");
            if (!int.TryParse(Console.ReadLine(), out int rating))
            {
                Console.WriteLine("Invalid rating entered!");
            }
            _videoStore.TakeUsersRating(rating, movieName);
        }

        private static int LeaveRating(string movieName)
        {
            Console.Write("Enter rating: ");
            if (!int.TryParse(Console.ReadLine(), out int rating))
            {
                Console.WriteLine("Invalid rating entered!");
            }
            _videoStore.TakeUsersRating(rating, movieName);
            return rating;
        }
    }
}
