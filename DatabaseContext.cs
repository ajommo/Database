using System;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Game.Database.Models;

namespace Game.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<AccountEntity> Accounts { set; get; }
        public DbSet<AssetEntity> Assets { set; get; }
        public DbSet<BundleEntity> Bundles { set; get; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public AccountEntity GetAccount(string username, string password)
        {
            return Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);
        }

        public AccountEntity GetAccount(int id, Guid token)
        {
            return Accounts.FirstOrDefault(a => a.Id == id && a.Token == token);
        }

        public AssetEntity GetAsset(string id)
        {
            return Assets.FirstOrDefault(a => a.Id == id);
        }

        public BundleEntity GetBundle(string id)
        {
            return Bundles.FirstOrDefault(bundle => bundle.Id == id);
        }

        public IQueryable<BundleEntity> GetBundles()
        {
            return Bundles;
        }
    }
}
