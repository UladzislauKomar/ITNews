using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Domain.Contracts.Services
{
    public interface INewsTagService
    {
        void SetTags(string newsId, IEnumerable<string> tags);
        IEnumerable<NewsViewModel> GetNewsByTag(TagViewModel model);
        IEnumerable<TagViewModel> GetTagsByNews(NewsViewModel model);
    }
}
