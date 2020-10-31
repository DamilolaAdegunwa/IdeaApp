using IdeaApp.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaApp.Core.Entity
{
    public class Notification : FullAuditedEntity
    {
        public NotificationType NotificationType { get; set; }
        public string Message { get; set; }
    }
}
