using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaApp.Core.Entity
{
    public class Post : FullAuditedEntity
    {
        public string Message { get; set; }//This might be taking a HTML string later
        public string Title { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
        public ICollection<Tag> Tags { get; set; }//hashtags, word indexers, topics, keywords
        public ICollection<Comment> Comments { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }

    }
}
