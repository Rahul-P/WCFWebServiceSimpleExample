
namespace TweetClient
{
    using System;
    using System.Collections.Generic;
    using TweetClient.DataServices;
    using TweetClient.WCFTweetService;

    class Program
    {
        private static TweetClientDataService _service;

        // Constants
        private const string Quit = "Q";
        private const string Edit = "E";
        private const string Delete = "D";
        private const string New = "N";
        private const string ListAllTweets = "L";
        private const string Yes = "Y";

        static void Main(string[] args)
        {
            _service = new TweetClientDataService();

            // Space so that ToUpper Doesnt Crashes!
            string userInput = "";

            while (userInput.ToUpper() != Quit)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("L) List all Tweets");
                Console.WriteLine("#) Show specific pun");
                Console.WriteLine("N) Enter a new Tweet");
                Console.WriteLine("Q) Quit");
                Console.Write("Please enter a command: ");

                userInput = Console.ReadLine().ToUpper();
                int tweetIndex = default (int);

                if (userInput == ListAllTweets)
                {
                    ListTweets();
                }
                else if (userInput == New)
                {
                    EnterTweet();
                }
                else if (Int32.TryParse(userInput, out tweetIndex))
                {
                    DisplayTweet(tweetIndex);
                }
            }
        }

        private static void DisplayTweet(int tweetId)
        {
            Tweet tweet = _service.GetTweetByID(tweetId);
            Console.WriteLine("Tweet Id: {0}), Posted By: {1} ", tweet.Id, tweet.PostedBy);
            Console.WriteLine("Tweet: {0}", tweet.Text);
            Console.WriteLine("---------------");
            Console.WriteLine("E) Edit Tweet");
            Console.WriteLine("D) Delete Tweet");
            Console.WriteLine("C) Continue");
            Console.Write("Please enter a command: ");

            var userInput = Console.ReadLine().ToUpper();
            if (userInput == Edit)
            {
                EditTweet(tweetId);
            }
            else if (userInput == Delete)
            {
                DeleteTweet(tweetId);
            }
        }

        private static void EditTweet(int tweetId)
        {
            Console.WriteLine("---------------");

            Console.Write("Posted by? ");
            var postedBy = Console.ReadLine();

            Console.Write("New Tweet Text? ");
            var newTweetText = Console.ReadLine();            

            Tweet tweet = new Tweet
            {
                Id = tweetId,
                PostedBy = postedBy,
                Text = newTweetText
            };

            _service.UpdateTweet(tweet);
        }

        private static void EnterTweet()
        {
            Console.WriteLine("---------------");
            Console.Write("Posted by? ");
            var postedBy = Console.ReadLine();

            Console.Write("New Tweet Text? ");
            var newTweetText = Console.ReadLine(); 

            Tweet tweet = new Tweet
            {
                PostedBy = postedBy,
                Text = newTweetText
            };

            _service.CreateTweet(tweet);
        }

        static void ListTweets()
        {
            IList<Tweet> tweets = _service.GetTweets();

            Console.WriteLine("---------------");
            foreach (Tweet tweet in tweets)
            {
                Console.WriteLine("Tweet Id: {0}), Posted By: {1} ", tweet.Id, tweet.PostedBy);
                Console.WriteLine("Tweet: {0}", tweet.Text);
            }
            Console.WriteLine("---------------");
        }

        private static void DeleteTweet(int tweetId)
        {
            Console.WriteLine("---------------");
            Console.Write("Are you sure you want to delete this Tweet? (Y/N) ");

            var userInput = Console.ReadLine().ToUpper();
            if (userInput == Yes)
            {
                _service.DeleteTweet(tweetId);
            }
        }
    }
}
