using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Domain.Contracts.Services
{
    public interface ICommentService
    {
        CommentViewModel Comment(CommentViewModel model);
        IEnumerable<CommentViewModel> GetCommentsByNews(NewsViewModel model);
    }
}
