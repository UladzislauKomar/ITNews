using ITNews.Domain.Contracts.Services;
using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;

namespace ITNews.Domain.Implementation.Services.Parsers
{
    public class BudnyNewsParserService : INewsParserService
    {
        public IEnumerable<NewsViewModel> ParseNews()
        {
            var output = new List<NewsViewModel>();
            string url = @"http://budny.by/newmain/ctl/rss/mid/652";
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
                    Description = @"https://pp.userapi.com/c625416/v625416590/29b87/qVfQAwAr6nA.jpg",
                    SectionId = "b837c434-53c7-48d8-b750-73aa086a7573",
                    OutUrl = item.Links.First().Uri.AbsoluteUri
                };
                output.Add(model);
            }
            return output.AsEnumerable().Take(3);
        }
    }
}
