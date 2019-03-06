using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Domain.Contracts.ViewModels
{
    public class NewsTagViewModel
    {
        public string NewsTagId { get; set; }

        public string NewsId { get; set; }
        public NewsViewModel News { get; set; }

        public string TagId { get; set; }
        public TagViewModel Tag { get; set; }
    }
}
