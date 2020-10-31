using IdeaApp.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaApp.Core.Entity
{
    public class BrainstormSessionMember: FullAuditedEntity
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public string Badge { get; set; }
    }
}
