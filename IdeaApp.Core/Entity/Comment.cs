using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaApp.Core.Entity
{
    public class Comment : FullAuditedEntity
    {
        public string Message { get; set; }
        public long Upvote { get; set; }
        public long Downvote { get; set; }
    }
}
