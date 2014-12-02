using System;
using System.Collections.Generic;
using System.Text;

namespace RSSFeed
{
    class FeedItem
    {
        public string Content { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public Uri Link { get; set; }
        public DateTime PubDate { get; set; }
    }
}
