using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IdeaApp.Core.Entity.Audit
{
    public interface IEntity
    {
    }
    public interface ICreationAudited<TUser>
    {
        DateTimeOffset CreationTime { get; set; }
        TUser CreatorUserId { get; set; }
    }
    public interface IDeletionAudited<TUser>
    {
        TUser DeleterUserId { get; set; }
        DateTimeOffset? DeletionTime { get; set; }
        bool IsDeleted { get; set; }
    }
    public interface IModificationAudited<TUser>
    {
        DateTimeOffset? LastModificationTime { get; set; }
        TUser LastModifierUserId { get; set; }
    }
    public abstract class AuditedEntity
    {
        public virtual DateTimeOffset CreationTime { get; set; }
        public virtual long? CreatorUserId { get; set; }//TUser
        public virtual long? DeleterUserId { get; set; }//TUser
        public virtual DateTimeOffset? DeletionTime { get; set; }//TUser
        public virtual long Id { get; set; }//TEntityUser
        public virtual bool IsDeleted { get; set; }
        public virtual DateTimeOffset? LastModificationTime { get; set; }
        public virtual long? LastModifierUserId { get; set; }//TUser
    }
}
