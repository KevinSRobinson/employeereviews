using System;
using System.Collections.Generic;
using System.Data.Entity;


public class EmployeeReviewsContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Review> Reviews { get; set; }

}




public class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Tel { get; set; }

    public List<Review> Reviews { get; set; }
}


public class Review
{
    public int Id { get; set; }

    public string Comments { get; set; }

    public DateTime Date { get; set; }
   

}
