using System;
using System.Data;
using System.Data.SqlClient;

namespace HRManagementSystem
{
    public class HRDataService
    {
        SqlConnection con =
            new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HRDB;Integrated Security=True;");

        SqlDataAdapter daDept, daEmp, daSal;
        DataSet ds = new DataSet();

        public static T ReadValue<T>(string message)
        {
            Console.Write(message);
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    return (T)Convert.ChangeType(input, typeof(T));
                }
                catch
                {
                    Console.WriteLine("Invalid Input . Try Again");
                }
            }
        }
        public void LoadData()
        {

            daDept = new SqlDataAdapter("Select * from Departments", con);
            daEmp = new SqlDataAdapter("Select * from Employees", con);
            daSal = new SqlDataAdapter("Select * from Salary", con);

            daDept.MissingSchemaAction = daEmp.MissingSchemaAction = daSal.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            new SqlCommandBuilder(daDept);
            new SqlCommandBuilder(daSal);
            new SqlCommandBuilder(daEmp);

            daDept.Fill(ds, "Departments");
            daEmp.Fill(ds, "Employees");
            daSal.Fill(ds, "Salaries");

            ds.Relations.Add("Dept_Emp",
                ds.Tables["Departments"].Columns["DepartmentId"], 
                ds.Tables["Employees"].Columns["DepartmentId"]);

            ds.Relations.Add("Emp_Salary", 
                ds.Tables["Employees"].Columns["EmployeeId"], 
                ds.Tables["Salaries"].Columns["EmployeeId"]);
        }

        // ================= CREATE =================

        public void AddDepartment()
        {
            try
            {
                int id = ReadValue<int>("Dept Id: ");
                if (ds.Tables["Departments"].Rows.Find(id) != null)
                {
                    Console.WriteLine("Department Id already exits . Use different Id");
                    return;
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Location: ");
                string loc = Console.ReadLine();

                DataRow row = ds.Tables["Departments"].NewRow();
                row["DepartmentId"] = id;
                row["DepartmentName"] = name;
                row["Location"] = loc;

                ds.Tables["Departments"].Rows.Add(row);
                daDept.Update(ds, "Departments");

                Console.WriteLine("Department Added");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Invalid Input Format");
            }
            catch(ConstraintException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddEmployee()
        {
            Console.Write("Emp Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Dept Id: ");
            int deptId = int.Parse(Console.ReadLine());

            if (ds.Tables["Departments"].Rows.Find(deptId) == null)
            {
                Console.WriteLine("Invalid Department");
                return;
            }

            Console.Write("Designation: ");
            string des = Console.ReadLine();

            DataRow row = ds.Tables["Employees"].NewRow();
            row["EmployeeId"] = id;
            row["EmployeeName"] = name;
            row["Email"] = email;
            row["DepartmentId"] = deptId;
            row["Designation"] = des;

            ds.Tables["Employees"].Rows.Add(row);
            daEmp.Update(ds, "Employees");
            Console.WriteLine("Employee Added");
        }

        public void AddSalary()
        {
            Console.Write("Emp Id: ");
            int empId = int.Parse(Console.ReadLine());

            if (ds.Tables["Employees"].Rows.Find(empId) == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }

            Console.Write("Basic: ");
            decimal basic = decimal.Parse(Console.ReadLine());

            Console.Write("HRA: ");
            decimal hra = decimal.Parse(Console.ReadLine());

            Console.Write("Allowance: ");
            decimal allow = decimal.Parse(Console.ReadLine());

            DataRow row = ds.Tables["Salaries"].NewRow();
            row["SalaryId"] = Guid.NewGuid().GetHashCode();
            row["EmployeeId"] = empId;
            row["Basic"] = basic;
            row["HRA"] = hra;
            row["Allowance"] = allow;
            row["LastUpdated"] = DateTime.Now;

            ds.Tables["Salaries"].Rows.Add(row);
            daSal.Update(ds, "Salaries");
            Console.WriteLine("Salary Added");
        }

        // ================= READ =================

        public void ViewAllEmployees()
        {
            foreach (DataRow emp in ds.Tables["Employees"].Rows)
            {
                DataRow dept = emp.GetParentRow("Dept_Emp");
                DataRow[] sal = emp.GetChildRows("Emp_Salary");

                decimal total = 0;
                if (sal.Length > 0)
                    total = Convert.ToDecimal(sal[0]["Basic"])
                          + Convert.ToDecimal(sal[0]["HRA"])
                          + Convert.ToDecimal(sal[0]["Allowance"]);

                Console.WriteLine($"{emp["EmployeeName"]} | {dept["DepartmentName"]} | Salary: {total}");
            }
        }
        public void ViewDepartments()
        {
            DataTable deptTable = ds.Tables["Departments"];

            if (deptTable.Rows.Count == 0)
            {
                Console.WriteLine("No deparment Found");
                return;
            }

            Console.WriteLine("\n------ Departments List ------");
            foreach(DataRow row in deptTable.Rows)
            {
                Console.WriteLine($"Id: {row["DepartmentId"]}, Name: {row["DepartmentName"]}, Location: {row["Location"]}");
            }
        }

        public void SearchEmployee()
        {
            Console.Write("Name contains: ");
            string key = Console.ReadLine();

            DataView dv = new DataView(ds.Tables["Employees"]);
            dv.RowFilter = $"EmployeeName LIKE '%{key}%'";

            foreach (DataRowView row in dv)
                Console.WriteLine(row["EmployeeName"]);
        }

        public void FilterByDepartment()
        {
            Console.Write("Department Id: ");
            int id = int.Parse(Console.ReadLine());

            DataRow[] rows =
                ds.Tables["Employees"].Select($"DepartmentId = {id}");

            foreach (DataRow r in rows)
                Console.WriteLine(r["EmployeeName"]);
        }

        public void FilterBySalary()
        {
            DataRow[] rich =
                ds.Tables["Salaries"]
                  .Select("Basic + HRA + Allowance > 60000");

            foreach (DataRow r in rich)
            {
                DataRow emp =
                    ds.Tables["Employees"].Rows.Find(r["EmployeeId"]);
                Console.WriteLine(emp["EmployeeName"]);
            }
        }

        // ================= UPDATE =================

        public void UpdateEmployeeDepartment()
        {
            Console.Write("Emp Id: ");
            int empId = int.Parse(Console.ReadLine());

            Console.Write("New Dept Id: ");
            int deptId = int.Parse(Console.ReadLine());

            DataRow emp = ds.Tables["Employees"].Rows.Find(empId);
            if (emp == null) return;

            emp["DepartmentId"] = deptId;
            daEmp.Update(ds, "Employees");
            Console.WriteLine("Employee Updated");
        }

        public void UpdateSalary()
        {
            Console.Write("Emp Id: ");
            int empId = int.Parse(Console.ReadLine());

            DataRow[] rows =
                ds.Tables["Salaries"].Select($"EmployeeId = {empId}");

            if (rows.Length == 0) return;

            Console.Write("New Basic: ");
            rows[0]["Basic"] = decimal.Parse(Console.ReadLine());

            rows[0]["LastUpdated"] = DateTime.Now;
            daSal.Update(ds, "Salaries");
            Console.WriteLine("Salary Updated");
        }

        // ================= DELETE =================

        public void DeleteEmployee()
        {
            Console.Write("Emp Id: ");
            int empId = int.Parse(Console.ReadLine());

            DataRow emp = ds.Tables["Employees"].Rows.Find(empId);
            if (emp == null) return;

            foreach (DataRow sal in emp.GetChildRows("Emp_Salary"))
                sal.Delete();

            emp.Delete();

            daSal.Update(ds, "Salaries");
            daEmp.Update(ds, "Employees");

            Console.WriteLine("Employee Deleted");
        }

        public void DeleteDepartment()
        {
            Console.Write("Dept Id: ");
            int id = int.Parse(Console.ReadLine());

            DataRow dept = ds.Tables["Departments"].Rows.Find(id);
            if (dept == null) return;

            if (dept.GetChildRows("Dept_Emp").Length > 0)
            {
                Console.WriteLine("Cannot delete. Employees exist.");
                return;
            }

            dept.Delete();
            daDept.Update(ds, "Departments");
            Console.WriteLine("Department Deleted");
        }
    }
}
