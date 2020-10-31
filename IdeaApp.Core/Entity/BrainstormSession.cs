using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaApp.Core.Entity
{
    public class BrainstormSession : FullAuditedEntity
    {
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
