using System.ComponentModel.DataAnnotations;

namespace ITNews.Data.Contracts.Entities
{
    public class CommentLikeEntity
    {
        [Key]
        public string CommentLikeId { get; set; }
        
        public string UserId { get; set; }
        public UserEntity User { get; set; }

        public string CommentId { get; set; }
        public CommentEntity Comment { get; set; }
    }
}