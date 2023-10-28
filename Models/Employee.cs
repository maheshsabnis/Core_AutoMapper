namespace Core_AutoMapper.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? DeptName { get; set; }
        public string? Designation { get; set; }
        public Address? Address { get; set; }
        public int Salary { get; set; }
    }
}
