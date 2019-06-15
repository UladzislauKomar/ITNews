using ITNews.Domain.Contracts.Services;
using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ITNews.Domain.Implementation.Services.Parsers
{
    public class OnlinerNewsParserService : INewsParserService
    {
        public IEnumerable<NewsViewModel> ParseNews()
        {
            var output = new List<NewsViewModel>();
            string url = @"https://tech.onliner.by/feed";
            SyndicationFeed feed;
            using (var reader = XmlReader.Create(url))
            {
                feed = SyndicationFeed.Load(reader);
            }
            foreach (var item in feed.Items)
            {
                var model = new NewsViewModel()
                {
                    Title = item.Title.Text,
                    Created = item.PublishDate.Date,
                    Content = item.Summary.Text,
                    UserId = "f304291c-aeee-4a8b-9c5b-652699d5b882",
                    Description = @"https://img.tyt.by/620x620s/n/it/0b/10/logo-onliner-by.png",
                    SectionId = "044020ff-9a06-4d67-bd11-4a49b9cf9c8a",
                    OutUrl = item.Links.First().Uri.AbsoluteUri
                };
                output.Add(model);
            }
            return output.AsEnumerable().Take(3);
        }
    }
}
