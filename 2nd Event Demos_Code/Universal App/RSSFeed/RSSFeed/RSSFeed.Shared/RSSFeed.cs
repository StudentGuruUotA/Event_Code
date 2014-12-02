using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Web.Syndication;

namespace RSSFeed
{
    //http://sxp.microsoft.com/feeds/3.0?tags=msit
    static internal class RSSFeed
    {
        public static async Task<List<FeedItem>> getFeedsAsync(string url)
        {
            //The web object that will retrieve our feeds..
            SyndicationClient client = new SyndicationClient();

            //The URL of our feeds..
            Uri feedUri = new Uri(url);

            //Retrieve async the feeds..
            var feed = await client.RetrieveFeedAsync(feedUri);

            //The list of our feeds..
            List<FeedItem> feedData = new List<FeedItem>();

            //Fill up the list with each feed content..
            foreach (SyndicationItem item in feed.Items)
            {
                FeedItem feedItem = new FeedItem();
                feedItem.Content = Regex.Replace(item.Summary.Text, @"<(.|\n)*?>", ""); 
                feedItem.Link = item.Links[0].Uri;
                feedItem.PubDate = item.PublishedDate.DateTime;
                feedItem.Title = item.Title.Text;

                try
                {
                    feedItem.Author = item.Authors[0].Name;
                }
                catch (ArgumentException)
                {
                }

                feedData.Add(feedItem);
            }

            return feedData;
        }
    }
}