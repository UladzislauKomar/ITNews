using System.ComponentModel.DataAnnotations;

namespace ITNews.Data.Contracts.Entities
{
    public class NewsRatingEntity
    {
        [Key]
        public string NewsRatingId { get; set; }

        public string UserId { get; set; }
        public UserEntity User { get; set; }

        public string NewsId { get; set; }
        public NewsEntity News { get; set; }

        public float Rating { get; set; }
    }
}