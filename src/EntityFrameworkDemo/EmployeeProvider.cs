﻿using System.Linq;

namespace EntityFrameworkDemo
{
    internal class EmployeeProvider : IEmployeeProvider
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeProvider(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Employee Get(int id)
        {
            return employeeContext.Employees.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
