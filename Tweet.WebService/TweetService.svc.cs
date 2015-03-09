
namespace Tweet.WebService
{
    using System.Collections.Generic; 
    using TweetBL;

    // NOTE: In order to launch WCF Test Client for testing this service, please select TweetService.svc or TweetService.svc.cs at the Solution Explorer and start debugging.
    public class TweetService : ITweetService
    {
        private TweetBL.TweetService _businessLayerTweetService;

        public TweetService()
        {
            _businessLayerTweetService = new TweetBL.TweetService();
        }

        public IList<Tweet> GetTweets()
        {
            return _businessLayerTweetService.GetTweets();
        }

        public Tweet GetTweetByID(int tweetId)
        {
            return _businessLayerTweetService.GetTweetById(tweetId);
        }

        public void CreateTweet(Tweet newTweet)
        {
            _businessLayerTweetService.CreateTweet(newTweet);
        }

        public void UpdateTweet(Tweet updateTweet)
        {
            _businessLayerTweetService.UpdateTweet(updateTweet);
        }

        public void DeleteTweet(int deleteTweetId)
        {
            _businessLayerTweetService.DeleteTweet(deleteTweetId);
        }
    }
}
