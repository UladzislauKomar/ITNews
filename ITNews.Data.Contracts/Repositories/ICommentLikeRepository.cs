using System.Collections.Generic;
using ITNews.Data.Contracts.Entities;

namespace ITNews.Data.Contracts.Repositories
{
    public interface ICommentLikeRepository
    {
        CommentLikeEntity Create(CommentLikeEntity entity);
        void Delete(CommentLikeEntity entity);
        CommentLikeEntity Read(CommentLikeEntity entity);
        IEnumerable<CommentLikeEntity> Read();
        void Update(CommentLikeEntity entity);
    }
}