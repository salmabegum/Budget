using Budget.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Budget
{
    public class BudgetDbContext : IdentityDbContext
    {

        public BudgetDbContext()
            : base("BudgetConn")
        {
            // Database.SetInitializer<BudgetDbContext>(new BudgetDbInitializer());
            Database.SetInitializer<BudgetDbContext>(new BudgetDbInitializer());

        }

        // used for high performance reads and fetches where result is to be returned via JSON.
        public BudgetDbContext(bool UseProxies)
            : base("BudgetConn")
        {
            Database.SetInitializer<BudgetDbContext>(new BudgetDbInitializer());

            this.Configuration.ProxyCreationEnabled = false;
        }

        // Managed entities.
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Income> Incomes { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public System.Data.Entity.DbSet<Budget.Models.SubCategory> SubCategories { get; set; }
    }

   
}