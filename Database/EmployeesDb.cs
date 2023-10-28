using Core_AutoMapper.Models;

namespace Core_AutoMapper.Database
{
    public class EmployeesDb : List<Employee>
    {
        public EmployeesDb()
        {
            Add(new Employee() {
                EmpNo=101,
                EmpName="Mahesh",
                DeptName="IT",
                Designation= "Director",
                Address =new Address() 
                {
                   BuildingOrSocietyName = "Society-1",
                   BuindingNoFlatNo = "B192",
                   Area= "A.M.Road",
                   City = "Pune",
                   State = "MH"
                },
             Salary =1200000
            });

            Add(new Employee()
            {
                EmpNo = 102,
                EmpName = "Manoj",
                DeptName = "HR",
                Designation = "Director",
                Address = new Address()
                {
                    BuildingOrSocietyName = "Society-2",
                    BuindingNoFlatNo = "C192",
                    Area = "B.M.Road",
                    City = "Pune",
                    State = "MH"
                },
                Salary = 3200000
            });

            Add(new Employee()
            {
                EmpNo = 103,
                EmpName = "Ajay",
                DeptName = "IT",
                Designation = "Manager",
                Address = new Address()
                {
                    BuildingOrSocietyName = "Society-3",
                    BuindingNoFlatNo = "D192",
                    Area = "C.M.Road",
                    City = "Bangalore",
                    State = "KR"
                },
                Salary = 900000
            });

            Add(new Employee()
            {
                EmpNo = 104,
                EmpName = "Amit",
                DeptName = "HR",
                Designation = "Manager",
                Address = new Address()
                {
                    BuildingOrSocietyName = "Society-4",
                    BuindingNoFlatNo = "E192",
                    Area = "K.M.Road",
                    City = "Bangalore",
                    State = "KR"
                },
                Salary = 800000
            });


        }
    }
}
