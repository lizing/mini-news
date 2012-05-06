using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argotic.Common;
using Argotic.Syndication;
using Argotic.Extensions.Core;
using Argotic.Net;
using Argotic.Web;
using System.Xml;
using System.Collections.ObjectModel;
using System.Web;
using System.Net;
using System.Collections;

namespace RssProject
{
    [Serializable]
    class Rss
    {
        string _url;
        RssFeed feed;
        private Collection<Item> _items = new Collection<Item>();
        private string _title;
        private DateTime _lastModified;
        
        public string Url
        {
            get { return _url; }
        }

        public Collection<Item> Items
        {
            get { return _items; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        public Rss(string url)
        {
            _url = url;
            
            getFeed();
        }

        private void getFeed()
        {
            try
            {
                SyndicationResourceLoadSettings settings = new SyndicationResourceLoadSettings();
                settings.RetrievalLimit = 10;
                
                Uri feedUri = new Uri(_url);
                
                feed = RssFeed.Create(feedUri, settings);
                _title = feed.Channel.Title;
                _lastModified = feed.Channel.LastBuildDate;
                foreach (RssItem item in feed.Channel.Items)
                {
                    _items.Add(new Item(item));
                }
            }
            catch (FormatException)
            {
                return;
            }
            catch (ArgumentNullException)
            {
                return;
            }
            catch (Exception)
            {
                return;
            }
           
        }

        public void updateItems()
        {
            feed.Load(new Uri(_url), CredentialCache.DefaultNetworkCredentials, null);

            foreach (RssItem item in feed.Channel.Items)
            {
                if (item.PublicationDate > _lastModified)
                {
                    _items.Add(new Item(item));
                }
            }

            _lastModified = feed.Channel.LastBuildDate;

        }

        public void delReadItems()
        {
            for (int i = _items.Count - 1; i >= 0; i--)
            {
                if (_items[i].Read == true)
                    _items.RemoveAt(i);
            }
        }

    }
}
