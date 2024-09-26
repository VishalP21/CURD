using Buisness.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Service
{
    public interface IEmployeeService
    {
        bool addEmployee(EmployeeViewModel employee);

        bool updateEmployee(EmployeeViewModel employee);

        bool deleteEmployee(int ids);

        List<EmployeeViewModel> GetAllemployes();
    }
}
