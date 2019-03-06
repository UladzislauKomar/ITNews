using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ITNews.Data.Contracts.Entities
{
    public class UserEntity: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public DateTime Birthdate { get; set; }

        public IEnumerable<NewsEntity> News { get; set; }
        public IEnumerable<CommentEntity> Comments { get; set; }
        public IEnumerable<NewsRatingEntity> Ratings { get; set; }
        public IEnumerable<CommentLikeEntity> Likes { get; set; }
    }
}
