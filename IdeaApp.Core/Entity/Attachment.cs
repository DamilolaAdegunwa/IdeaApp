using IdeaApp.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaApp.Core.Entity
{
    public class Attachment : FullAuditedEntity
    {
        public AttachmentTypes? AttachmentTypes { get; set; }
        public byte[] File { get; set; }
        public string FilePath { get; set; }
    }
}
