using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Domain.Contracts.Services
{
    public interface INewsRatingService
    {
        NewsRatingViewModel Rate(NewsRatingViewModel model);
        IEnumerable<NewsRatingViewModel> GetRatingByNews(NewsViewModel model);
        IEnumerable<NewsRatingViewModel> GetRatingByUser(UserViewModel model);
    }
}
