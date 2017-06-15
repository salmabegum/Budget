using Budget.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Budget
{
    public class BudgetDbInitializer : DropCreateDatabaseIfModelChanges<BudgetDbContext>
    {
        protected override void Seed(BudgetDbContext db)
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            if (!RoleManager.RoleExists("Family_Admin")) { RoleManager.Create(new IdentityRole("Family_Admin")); }            
            if (!RoleManager.RoleExists("Application_Admin")) { RoleManager.Create(new IdentityRole("Application_Admin")); }
            
            Category category1 = new Category();
            category1.Description = "Rent";
            category1.Name = "Rent";
            db.Categories.Add(category1);
            
            Income income1=new Income();
            income1.Description="Salary";
            income1.IncomeReceivedDate=DateTime.Now;
            income1.TotalAmount=1000;
            db.Incomes.Add(income1);

            Expense expense1=new Expense();
            expense1.Amount = 200;
            expense1.Category = category1;
            expense1.Category_ID = category1.ID;
            expense1.DateIncurred = DateTime.Now;
            expense1.Income=income1;
            expense1.Income_ID = income1.ID;
            db.Expenses.Add(expense1);

            db.SaveChanges();
        }

      
    }
    
}