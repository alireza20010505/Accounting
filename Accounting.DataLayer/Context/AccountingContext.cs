using Accounting.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
    public class AccountingContext : DbContext
    {

        public AccountingContext(DbContextOptions<AccountingContext> option) : base(option)
        {

        }

        #region user
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        #endregion



    }
}
