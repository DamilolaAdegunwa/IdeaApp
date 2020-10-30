using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace IdeaApp.Data.DatabaseContext
{
    public class IdeaAppDbContext : DbContext
    {
        public IdeaAppDbContext(DbContextOptions<IdeaAppDbContext> options): base(options)
        {

        }

        #region DbSet

        #endregion
    }
}
