using System.Collections.Generic;
using ITNews.Data.Contracts.Entities;

namespace ITNews.Data.Contracts.Repositories
{
    public interface ISectionRepository
    {
        SectionEntity Create(SectionEntity entity);
        void Delete(SectionEntity entity);
        SectionEntity Read(SectionEntity entity);
        IEnumerable<SectionEntity> Read();
        void Update(SectionEntity entity);
    }
}