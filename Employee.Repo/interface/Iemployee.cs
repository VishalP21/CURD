using Employee.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Repo
{
    public interface Iemployee
    {
        bool addEmployee(Employe employee);

        bool updateEmployee(Employe employee);

        bool deleteEmployee(int ids);

        List<Employe> GetAllemployes();
    }
}
