using System.Collections.Generic;
using ITNews.Data.Contracts.Entities;

namespace ITNews.Data.Contracts.Repositories
{
    public interface INewsRatingRepository
    {
        NewsRatingEntity Create(NewsRatingEntity entity);
        void Delete(NewsRatingEntity entity);
        NewsRatingEntity Read(NewsRatingEntity entity);
        IEnumerable<NewsRatingEntity> Read();
        void Update(NewsRatingEntity entity);
    }
}