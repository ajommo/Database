using System;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Game.Database.Models;
using System.Collections.Generic;

namespace Game.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<AccountEntity> Accounts { set; get; }
        public DbSet<AssetEntity> Assets { set; get; }
        public DbSet<BundleEntity> Bundles { set; get; }
        public DbSet<InstanceEntity> Instances { set; get; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public AccountEntity GetAccount(string username, string password)
        {
            return Accounts.FirstOrDefault(a => a.Username == username && a.Password == password && a.Active);
        }

        public AccountEntity GetAccount(int id, Guid token)
        {
            return Accounts.FirstOrDefault(a => a.Id == id && a.Token == token && a.Active);
        }

        public AssetEntity GetAsset(string id)
        {
            return Assets.FirstOrDefault(a => a.Id == id && a.Active);
        }

        public List<AssetEntity> GetAssets()
        {
            return Assets.Where(a => a.Active).ToList();
        }

        public BundleEntity GetBundle(string id)
        {
            return Bundles.FirstOrDefault(b => b.Id == id && b.Active);
        }

        public List<BundleEntity> GetBundles()
        {
            return Bundles.Where(b => b.Active).ToList();
        }

        public InstanceEntity GetInstance(Guid id)
        {
            return Instances.FirstOrDefault(b => b.Id == id);
        }
    }
}
