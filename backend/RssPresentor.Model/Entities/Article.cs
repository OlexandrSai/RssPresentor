using System;
using System.Collections.Generic;
using System.Text;

namespace RssPresentor.Model.Entities
{
    public class Article:IEntityBase
    {
        public string Id { get; set; }
        public string IdFromRssOriginal { get; set; }

        public string BaseUri { get; set; }
        public string ImageUri { get; set; }

        public string ContentType { get; set; }

        public string ContentText { get; set; }


        public DateTime LastUpdatedTimeUtc { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsApproved { get; set; }


        public DateTime PublishDateUtc { get; set; }

        public RssFeed SourceFeed { get; set; }

        public string TitleType { get; set; }
        public string TitleText { get; set; }

        public string SummaryType { get; set; }
        public int UpvotesCount { get; set; }
        public int DownVotesCount { get; set; }

        public string SummaryText { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }

        public virtual IEnumerable<ArticleCategory> ArticlesCategories { get; set; }
    }
}
