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
    public class TutByNewsParserService : INewsParserService
    {
        public IEnumerable<NewsViewModel> ParseNews()
        {
            var output = new List<NewsViewModel>();
            string url = @"https://news.tut.by/rss/42/all.rss";
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
                    Description = @"https://img.tyt.by/i/by5/tutby.jpg",
                    SectionId = "a638dae1-ea6c-4399-b222-60b39862e261",
                    OutUrl = item.Links.First().Uri.AbsoluteUri
                };
                output.Add(model);
            }
            return output.AsEnumerable().Take(3);
        }
    }
}
