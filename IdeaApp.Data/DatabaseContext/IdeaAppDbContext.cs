using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace IdeaApp.Data.DatabaseContext
{
    public class IdeaAppDbContext : IdentityDbContext
    {
        public IdeaAppDbContext(DbContextOptions<IdeaAppDbContext> options): base(options)
        {

        }

        #region DbSet

        #endregion
    }
}