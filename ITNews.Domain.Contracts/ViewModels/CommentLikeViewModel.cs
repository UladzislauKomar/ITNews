using System.ComponentModel.DataAnnotations;

namespace ITNews.Domain.Contracts.ViewModels
{
    public class CommentLikeViewModel
    {
        [Key]
        public string CommentLikeId { get; set; }
        
        public string UserId { get; set; }
        public UserViewModel User { get; set; }

        public string CommentId { get; set; }
        public CommentViewModel Comment { get; set; }
    }
}