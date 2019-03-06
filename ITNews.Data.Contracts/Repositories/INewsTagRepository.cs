using System.Collections.Generic;
using ITNews.Data.Contracts.Entities;

namespace ITNews.Data.Contracts.Repositories
{
    public interface INewsTagRepository
    {
        NewsTagEntity Create(NewsTagEntity entity);
        void Delete(NewsTagEntity entity);
        NewsTagEntity Read(NewsTagEntity entity);
        IEnumerable<NewsTagEntity> Read();
        void Update(NewsTagEntity entity);
    }
}