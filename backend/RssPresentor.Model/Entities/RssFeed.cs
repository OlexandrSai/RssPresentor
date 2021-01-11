using System;
using System.Collections.Generic;
using System.Text;

namespace RssPresentor.Model.Entities
{
    public class RssFeed:IEntityBase
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Link { get; set; }
        public DateTime LastUpdateDateTimeUtc { get; set; }
        public virtual IEnumerable<Article> Articles { get; set; }
    }
}
