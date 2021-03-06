using System;
using System.Threading.Tasks;
using Tweetinvi;

namespace FireTweet
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var _ConsumerKey = Environment.GetEnvironmentVariable("ConsumerKey");
            var _ConsumerSecret = Environment.GetEnvironmentVariable("ConsumerSecret");
            var _AccessToken = Environment.GetEnvironmentVariable("AccessToken");
            var _AccessTokenSecret = Environment.GetEnvironmentVariable("AccessTokenSecret");

            var userClient = new TwitterClient(_ConsumerKey, _ConsumerSecret, _AccessToken, _AccessTokenSecret);
            var tweet = await userClient.Tweets.PublishTweetAsync($"API TEST:{DateTime.Now}");
            Console.WriteLine("Tweet Published : " + tweet);

        }
    }
}
