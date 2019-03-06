using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITNews.Data.Contracts.Entities
{
    public class CommentEntity
    {
        [Key]
        public string CommentId { get; set; }
        public string Content { get; set; }

        public string UserId { get; set; }
        public UserEntity User { get; set; }

        public string NewsId { get; set; }
        public NewsEntity News { get; set; }

        public DateTime Created { get; set; }

        public IEnumerable<CommentLikeEntity> Likes { get; set; }
    }
}