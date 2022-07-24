namespace Employees.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
    }
}
