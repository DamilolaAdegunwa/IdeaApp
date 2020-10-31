using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IdeaApp.Core.Entity;

namespace IdeaApp.Data.DatabaseContext
{
    public class IdeaAppDbContext : IdentityDbContext
    {
        public IdeaAppDbContext(DbContextOptions<IdeaAppDbContext> options): base(options)
        {

        }

        #region DbSet
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<BrainstormSession> BrainstormSessions { get; set; }
        public DbSet<BrainstormSessionMember> BrainstormSessionMembers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> UserProfiles { get; set; }
        #endregion
    }
}