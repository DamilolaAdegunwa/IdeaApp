using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaApp.Core.Entity
{
    public class User: FullAuditedEntity
    {
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string ProfilePicturePath { get; set; }
        //public IdentityUser IdentityUser { get; set; }
        public Guid IdentityUserId { get; set; }
    }
}