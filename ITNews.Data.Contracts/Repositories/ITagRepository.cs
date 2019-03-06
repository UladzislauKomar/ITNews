using System.Collections.Generic;
using ITNews.Data.Contracts.Entities;

namespace ITNews.Data.Contracts.Repositories
{
    public interface ITagRepository
    {
        TagEntity Create(TagEntity entity);
        void Delete(TagEntity entity);
        TagEntity Read(TagEntity entity);
        IEnumerable<TagEntity> Read();
        void Update(TagEntity entity);
    }
}