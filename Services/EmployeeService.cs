using Core_AutoMapper.Database;
using Core_AutoMapper.Models;

namespace Core_AutoMapper.Services
{
    public class EmployeeService
    {
        EmployeesDb employeesDb;

        public EmployeeService()
        {
            employeesDb = new EmployeesDb();
        }

        public List<Employee> GetEmoployees()
        {
            return employeesDb;
        }
    }
}
