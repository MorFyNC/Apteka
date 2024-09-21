using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka.Core.Database
{
    public static class DatabaseManager
    {
        private static AptekaEntities _database = new AptekaEntities();
        
        public static List <Employee> GetEmployees(Predicate<Employee> p = null)
        {
            if (p == null) p = delegate (Employee e) { return true; };
            return _database.Employee.Where(x => p.Invoke(x)).ToList();
        }
    }
}
