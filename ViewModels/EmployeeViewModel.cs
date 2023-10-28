using System.ComponentModel.DataAnnotations;

namespace Core_AutoMapper.ViewModels
{
    public class EmployeeViewModel
    {
        [Display(Name ="Employee Name")]
        public string? EmpName { get; set; }
        [Display(Name = "Department Name")]
        public string? DeptName { get; set; }
        [Display(Name = "Designation")]
        public string? Designation { get; set; }
        [Display(Name = "Address")]
        public string? Address { get; set; }
    }
}
