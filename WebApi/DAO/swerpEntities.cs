using DAO.EF.Mapping;
using IInfrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.EF
{
    public class swerpEntities : DbContext, IDbContext
    {
        public swerpEntities() : base("name=swerpEntities") { }
        public swerpEntities(String nameOrConnectionString) : base(nameOrConnectionString) { }

        public new DbSet<TEntity> Set<TEntity>()
            where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public new DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class
        {
            return base.Entry<TEntity>(entity);
        }

        public new Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PayMethod> PayMethod { get; set; }
        public virtual DbSet<InvType> InvType { get; set; }
        public virtual DbSet<PayTerm> PayTerm { get; set; }
        public virtual DbSet<Buyer> Buyer { get; set; }

        public virtual DbSet<Po> Po { get; set; }


        #region 重写映射
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new PayMethodMapping());
            modelBuilder.Configurations.Add(new InvTypeMapping());
            modelBuilder.Configurations.Add(new PayTermMapping());
            modelBuilder.Configurations.Add(new BuyerMapping());
            modelBuilder.Configurations.Add(new PoMapping());
            
            modelBuilder.Entity<Buyer>()
                .HasMany(e => e.Po)
                .WithOptional(e => e.BUYER1)
                .HasForeignKey(e => e.BUYER);
            
            modelBuilder.Entity<PayTerm>()
                .HasMany(e => e.Po)
                .WithOptional(e => e.PAYTERM1)
                .HasForeignKey(e => e.PAYTERM);
            
            modelBuilder.Entity<PayMethod>()
                .HasMany(e => e.Po)
                .WithOptional(e => e.PAYMETHOD1)
                .HasForeignKey(e => e.PAYMETHOD);
            
            modelBuilder.Entity<InvType>()
                .HasMany(e => e.Po)
                .WithOptional(e => e.INVTYPE1)
                .HasForeignKey(e => e.INVTYPE);
            
            modelBuilder.Entity<User>()
                .HasMany(e => e.Po)
                .WithOptional(e => e.CreatedUser)
                .HasForeignKey(e => e.CREATEDBY);
        }
        #endregion
    }
}
