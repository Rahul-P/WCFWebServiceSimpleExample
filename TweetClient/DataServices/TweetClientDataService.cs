
namespace TweetClient.DataServices
{
    using System.Collections.Generic;
    using TweetClient.WCFTweetService;

    class TweetClientDataService
    {
        private TweetServiceClient _client;

        public TweetClientDataService()
        {
            _client = new WCFTweetService.TweetServiceClient();
        }
        public IList<Tweet> GetTweets()
        {
            return _client.GetTweets();
        }

        public Tweet GetTweetByID(int tweetId)
        {
            return _client.GetTweetByID(tweetId);
        }

        public void CreateTweet(Tweet newTweet)
        {
            _client.CreateTweet(newTweet);
        }

        public void UpdateTweet(Tweet updateTweet)
        {
            _client.UpdateTweet(updateTweet);
        }

        public void DeleteTweet(int deleteTweetId)
        {
            _client.DeleteTweet(deleteTweetId);
        }
    }
}
