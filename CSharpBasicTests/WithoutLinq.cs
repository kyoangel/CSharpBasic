using System;
using System.Collections.Generic;
using System.Linq;
using CSharpBasicTests.Models;

namespace CSharpBasicTests
{
    public class WithoutLinq
    {
        public IEnumerable<Employee> GetEmployeesMonthSalaryBiggerThan150(IEnumerable<Employee> employees)
        {
            return null;
        }

        public IEnumerable<Employee> GetEmployeesAgeGreaterThan25(IEnumerable<Employee> employees)
        {
            return null;
        }
    }
}