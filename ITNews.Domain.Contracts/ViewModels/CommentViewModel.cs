using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITNews.Domain.Contracts.ViewModels
{
    public class CommentViewModel
    {
        [Key]
        public string CommentId { get; set; }
        public string Content { get; set; }

        public string UserId { get; set; }
        public UserViewModel User { get; set; }

        public string NewsId { get; set; }
        public NewsViewModel News { get; set; }

        public DateTime Created { get; set; }

        public IEnumerable<CommentLikeViewModel> Likes { get; set; }
    }
}