using System.Collections.Generic;
using ITNews.Data.Contracts.Entities;

namespace ITNews.Data.Contracts.Repositories
{
    public interface INewsRepository
    {
        NewsEntity Create(NewsEntity entity);
        void Delete(NewsEntity entity);
        NewsEntity Read(NewsEntity entity);
        IEnumerable<NewsEntity> Read();
        void Update(NewsEntity entity);
    }
}