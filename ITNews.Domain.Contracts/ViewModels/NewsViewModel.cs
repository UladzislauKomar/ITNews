using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITNews.Domain.Contracts.ViewModels
{
    public class NewsViewModel
    {
        [Key]
        public string NewsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public bool IsAllowed { get; set; }
        public string OutUrl { get; set; }

        public string UserId { get; set; }
        public UserViewModel User { get; set; }
            
        public string SectionId { get; set; }
        public SectionViewModel Section { get; set; }

        public IEnumerable<NewsTagViewModel> Tags { get; set; }
        public IEnumerable<NewsRatingViewModel> Ratings { get; set; }
        public IEnumerable<CommentViewModel> Comments { get; set; }
    }
}