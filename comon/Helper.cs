using Buisness.Entity;
using Employee.Database;

namespace comon
{
    public static class Helper
    {
        public static Employe ToDataModel(this EmployeeViewModel employeeViewModel)
        {
            Employe employe = new Employe();
            employe.FirstName = employeeViewModel.FirstName;
            employe.LastName = employeeViewModel.LastName;
            return employe;
        }

        public static EmployeeViewModel ToViewModel(this Employe employe)
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.FirstName = employe.FirstName;
            employeeViewModel.LastName = employe.LastName;
            return employeeViewModel;
        }

        public static List<EmployeeViewModel> ToViewModel(this List<Employe> employes)
        {
           return employes.Select(y=>y.ToViewModel()).ToList();
            
        }
    }
}
