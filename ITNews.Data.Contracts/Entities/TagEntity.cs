using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITNews.Data.Contracts.Entities
{
    public class TagEntity
    {
        [Key]
        public string TagId { get; set; }
        public string Name { get; set; }

        public IEnumerable<NewsTagEntity> News { get; set; }
    }
}