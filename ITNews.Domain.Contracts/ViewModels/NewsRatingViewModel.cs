using System.ComponentModel.DataAnnotations;

namespace ITNews.Domain.Contracts.ViewModels
{
    public class NewsRatingViewModel
    {
        [Key]
        public string NewsRatingId { get; set; }

        public string UserId { get; set; }
        public UserViewModel User { get; set; }

        public string NewsId { get; set; }
        public NewsViewModel News { get; set; }

        public float Rating { get; set; }
    }
}