
namespace Tweet.WebService
{
    using System;
    using System.Collections.Generic;

    // NOTE: In order to launch WCF Test Client for testing this service, please select TweetService.svc or TweetService.svc.cs at the Solution Explorer and start debugging.
    public class TweetService : ITweetService
    {
        public IList<Tweet> GetTweets()
        {
            throw new NotImplementedException();
        }

        public Tweet GetTweetByID(int tweetId)
        {
            throw new NotImplementedException();
        }

        public void CreateTweet(Tweet newTweet)
        {
            throw new NotImplementedException();
        }

        public void UpdateTweet(Tweet updateTweet)
        {
            throw new NotImplementedException();
        }

        public void DeleteTweet(int updateTweetId)
        {
            throw new NotImplementedException();
        }
    }
}
