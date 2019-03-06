using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ITNews.Domain.Contracts.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string SecurityStamp { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public IEnumerable<NewsViewModel> News { get; set; }
        public IEnumerable<CommentViewModel> Comments { get; set; }
        public IEnumerable<NewsRatingViewModel> Ratings { get; set; }
        public IEnumerable<CommentLikeViewModel> Likes { get; set; }
    }
}
