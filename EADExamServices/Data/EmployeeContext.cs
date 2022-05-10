using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EADExamServices.Entity;

namespace EADExamServices.Data
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext() : base("name=EADExam")
        {
        }
        public DbSet<Employee> Employee { get; set; }
    }
}