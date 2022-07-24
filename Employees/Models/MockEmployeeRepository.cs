using System.Collections.Generic;
using System.Linq;

namespace Employees.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {

        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault();
        }
    }
}
