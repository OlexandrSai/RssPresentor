using System;
using System.Collections.Generic;
using System.Text;

namespace RssPresentor.Model.Entities
{
    public class Category:IEntityBase
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }
        public virtual IEnumerable<ArticleCategory> ArticlesCategories { get; set; }
    }
}
