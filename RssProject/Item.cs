using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argotic.Syndication;
using System.Web;

namespace RssProject
{
    [Serializable]
    class Item
    {
        private string _title;
        private string _description;
        private DateTime _pubDate;
        private bool _read;
        private Uri _link;

        public string Title
        {
            get { return _title; }
        }

        public string Description
        {
            get { return _description; }
        }

        public DateTime PubDate
        {
            get { return _pubDate; }
        }

        public Uri Link
        {
            get { return _link; }
        }

        public bool Read
        {
            get { return _read; }
            set { _read = value; }
        }

        public Item(RssItem item)
        {
            _title = item.Title;
            _description = item.Description;
            _pubDate = item.PublicationDate;
            _link = item.Link;
            _read = false;
        }
    }
}
