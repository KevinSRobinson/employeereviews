using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


public class EmployeeReviews : DbContext
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

    public int Rating { get; set; }

    [Column(TypeName = "datetime2")]
    public DateTime Date { get; set; }
   

}
