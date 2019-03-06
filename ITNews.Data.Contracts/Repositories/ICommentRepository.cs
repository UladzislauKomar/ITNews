using System.Collections.Generic;
using ITNews.Data.Contracts.Entities;

namespace ITNews.Data.Contracts.Repositories
{
    public interface ICommentRepository
    {
        CommentEntity Create(CommentEntity entity);
        void Delete(CommentEntity entity);
        CommentEntity Read(CommentEntity entity);
        IEnumerable<CommentEntity> Read();
        void Update(CommentEntity entity);
    }
}