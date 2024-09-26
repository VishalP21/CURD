using Employee.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Repo.conc
{
    public class employeeRepo : Iemployee
    {
        EmployeemanagesystemContext employeemanagesystemContext;
        public employeeRepo()
        {
            employeemanagesystemContext = new EmployeemanagesystemContext();
        }
        public bool addEmployee(Employe employee)
        {
            employeemanagesystemContext.Employes.Add(employee);
            return employeemanagesystemContext.SaveChanges()>0? true:false;
        }

        public bool deleteEmployee(int ids)
        {
            var d = employeemanagesystemContext.Employes.Find(ids);
            return employeemanagesystemContext.SaveChanges() > 0? true:false;
        }

        public List<Employe> GetAllemployes()
        {
            return employeemanagesystemContext.Employes.ToList();
        }

        public bool updateEmployee(Employe employee)
        {
            var d = employeemanagesystemContext.Employes.Find(employee.Id);
            d.FirstName = employee.FirstName;
            d.LastName = employee.LastName;
            return employeemanagesystemContext.SaveChanges() > 0 ? true : false;
        }
    }
}
