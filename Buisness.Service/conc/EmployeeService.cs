using Buisness.Entity;
using comon;
using Employee.Repo.conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Service.conc
{
    public class EmployeeService : IEmployeeService
    {
        employeeRepo employeeRepo;

        EmployeeService()
        {
           employeeRepo = new employeeRepo();
        }

        public bool addEmployee(EmployeeViewModel employee)
        {
            return employeeRepo.addEmployee(employee.ToDataModel());
        }

        public bool deleteEmployee(int ids)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeViewModel> GetAllemployes()
        {
            return employeeRepo.GetAllemployes().ToViewModel();
        }

        public bool updateEmployee(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
