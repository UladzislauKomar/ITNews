using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITNews.Data.Contracts.Entities
{
    public class NewsEntity
    {
        [Key]
        public string NewsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public bool IsAllowed { get; set; }
        public string OutUrl { get; set; }

        public string UserId { get; set; }
        public UserEntity User { get; set; }
            
        public string SectionId { get; set; }
        public SectionEntity Section { get; set; }

        public IEnumerable<NewsTagEntity> Tags { get; set; }
        public IEnumerable<NewsRatingEntity> Ratings { get; set; }
        public IEnumerable<CommentEntity> Comments { get; set; }
    }
}