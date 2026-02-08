using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManagementSystem;

namespace EmployeeDepartmentSalaryManagementSystem
{
    class Program
    {
        static void Main()
        {
            HRDataService service = new HRDataService();
            service.LoadData();

            while (true)
            {
                Console.WriteLine("\n===== HR MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Add Department");
                Console.WriteLine("2. Add Employee");
                Console.WriteLine("3. Add Salary");
                Console.WriteLine("4. View All Employees");
                Console.WriteLine("5. Search Employee by Name");
                Console.WriteLine("6. Filter by Department");
                Console.WriteLine("7. Filter by Salary Range");
                Console.WriteLine("8. Update Employee Department");
                Console.WriteLine("9. Update Salary");
                Console.WriteLine("10. Delete Employee");
                Console.WriteLine("11. Delete Department");
                Console.WriteLine("12. View Departments");
                Console.WriteLine("0. Exit");

                Console.Write("Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: service.AddDepartment(); break;
                    case 2: service.AddEmployee(); break;
                    case 3: service.AddSalary(); break;
                    case 4: service.ViewAllEmployees(); break;
                    case 5: service.SearchEmployee(); break;
                    case 6: service.FilterByDepartment(); break;
                    case 7: service.FilterBySalary(); break;
                    case 8: service.UpdateEmployeeDepartment(); break;
                    case 9: service.UpdateSalary(); break;
                    case 10: service.DeleteEmployee(); break;
                    case 11: service.DeleteDepartment(); break;
                    case 12:service.ViewDepartments(); break;

                    case 0: return;
                }
            }
        }
    }
}
