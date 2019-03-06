using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Domain.Contracts.Services
{
    public interface INewsService
    {
        NewsViewModel Post(NewsViewModel model);
        bool Edit(NewsViewModel model);
        bool Delete(NewsViewModel model);
        IEnumerable<NewsViewModel> GetNewsList();
        IEnumerable<NewsViewModel> GetNewsByUser(UserViewModel model);
        NewsViewModel GetNewsDetails(NewsViewModel model);
        NewsViewModel GetNewsDetails(string newsId);
    }
}
