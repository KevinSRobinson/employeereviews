using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ExmployeeReviews.Startup))]

namespace ExmployeeReviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            using (var db = new EmployeeReviews())
            {
                db.Employees.Add(new Employee { FirstName = "Kevin ", LastName = "Robinson", Tel = "99999" });
                db.SaveChanges();

                db.Reviews.Add(new Review { Comments = "dsfdsf sdfdsfdsfdsf" });
                db.SaveChanges();
            }

            ConfigureAuth(app);
        }
    }
}
