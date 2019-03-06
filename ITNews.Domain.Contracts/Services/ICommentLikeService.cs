using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Domain.Contracts.Services
{
    public interface ICommentLikeService
    {
        CommentLikeViewModel Like(CommentLikeViewModel model);
        void Unlike(CommentLikeViewModel model);
        IEnumerable<CommentLikeViewModel> GetLikesByComment(CommentViewModel model);
        IEnumerable<CommentLikeViewModel> GetLikesByUser(UserViewModel model);
        IEnumerable<CommentLikeViewModel> GetLikes();
    }
}
