using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IdeaApp.Core.Entity
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
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
    public abstract class FullAuditedEntity : IEntity<long>, ICreationAudited<long>, IDeletionAudited<long?>, IModificationAudited<long?>
    {
        public virtual DateTimeOffset CreationTime { get; set; }
        public virtual long CreatorUserId { get; set; }//TUser
        public virtual long? DeleterUserId { get; set; }//TUser
        public virtual DateTimeOffset? DeletionTime { get; set; }
        public virtual long Id { get; set; }//TPrimaryKey
        public virtual bool IsDeleted { get; set; }
        public virtual DateTimeOffset? LastModificationTime { get; set; }
        public virtual long? LastModifierUserId { get; set; }//TUser
    }
    public abstract class FullAuditedEntity<TPrimaryKey, CreationUser, DeletionUser, ModificationUser> : 
        IEntity<TPrimaryKey>, ICreationAudited<CreationUser>, IDeletionAudited<DeletionUser>, IModificationAudited<ModificationUser>
    {
        public virtual DateTimeOffset CreationTime { get; set; }
        public virtual CreationUser CreatorUserId { get; set; }//TUser
        public virtual DeletionUser DeleterUserId { get; set; }//TUser
        public virtual DateTimeOffset? DeletionTime { get; set; }
        public virtual TPrimaryKey Id { get; set; }//TPrimaryKey
        public virtual bool IsDeleted { get; set; }
        public virtual DateTimeOffset? LastModificationTime { get; set; }
        public virtual ModificationUser LastModifierUserId { get; set; }//TUser
    }
}
