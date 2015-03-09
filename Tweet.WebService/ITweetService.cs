
namespace Tweet.WebService
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using TweetBL;

    [ServiceContract]
    public interface ITweetService
    {
        [OperationContract]
        IList<Tweet> GetTweets();

        [OperationContract]
        Tweet GetTweetByID(int tweetId);

        [OperationContract]
        void CreateTweet(Tweet newTweet);

        [OperationContract]
        void UpdateTweet(Tweet updateTweet);

        [OperationContract]
        void DeleteTweet(int deleteTweetId);
    }
}
