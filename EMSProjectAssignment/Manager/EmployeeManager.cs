namespace EMSProjectAssignment.Manager
{
    using EMSProjectAssignment.Entities;

    public class EmployeeManager
    {
        int count;
        List<Employee> employees;

        public EmployeeManager()
        {
            this.employees = new List<Employee>
            {
                new Employee
                {
                    Id = 0,
                    FirstName = "Test",
                    LastName = "Zero",
                    Address = new Address { Door = "00000", Street = "SomeStreet", Pincode = 1111, State = "SomeState", Country = "PH" },
                    DateOfBirth = "01/01/1999",
                    Department = new Department { Name = "IT", Location = "Makati" },
                    Salary = 10000
                }
            };

            this.count = 1;
        }
        public void List()
        {
            try
            {
                Console.WriteLine("List of Employees: ");
                Console.WriteLine("ID \t\tName \t\tDepartment \t\tSalary");
                employees.ForEach((employee) =>
                {
                    Console.WriteLine($"{employee.Id} \t\t{employee.FirstName} {employee.LastName} \t\t{employee.Department.Name} \t\t{employee.Salary}");
                });
            }catch (Exception ex)
            {
                Console.WriteLine("No employees yet!");
            }
        }

        public void Create(Employee employee)
        {
            employee.Id = this.count++;
            this.employees.Add(employee);

            Console.WriteLine("Employee successfully created!");
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"Date of Birth: {employee.DateOfBirth}");
            Console.WriteLine($"Address: {employee.Address.Door} {employee.Address.Street} {employee.Address.Country} {employee.Address.State} {employee.Address.Pincode}");
            Console.WriteLine($"Department: {employee.Department.Name} {employee.Department.Location}");
            Console.WriteLine($"Salary: {employee.Salary}");
        }

        public void Find(int employeeId)
        {
            Employee employee = this.employees.Find((emp) => emp.Id == employeeId);
            Console.WriteLine($"ID \tName \t\tDepartment \tSalary");
            Console.WriteLine($"{employee.Id} \t{employee.FirstName} {employee.LastName} \t{employee.Department.Name} \t{employee.Salary}");
        }

        public void Update(int employeeId)
        {
            Employee employee = this.employees.Find((emp) => emp.Id == employeeId);
            Console.WriteLine($"Employee with ID number {employeeId}");
            Console.WriteLine($"{employee.Id} \t{employee.FirstName} {employee.LastName} \t{employee.Department.Name} \t{employee.Salary}");
        }

        public void Delete(int employeeId)
        {
            this.employees.RemoveAll((emp) => emp.Id == employeeId);
            Console.WriteLine($"Employee with the ID {employeeId} has been removed.");
        }

        public void CreateViaUserInput()
        {
            Employee employee = new Employee();
            Address employeeAddress = new Address();
            Department employeeDepartment = new Department();

            Console.WriteLine("First Name:");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Date of Birth (mm/dd/yyyy):");
            employee.DateOfBirth = Console.ReadLine();

            Console.WriteLine("Address");
            Console.WriteLine("Door: ");
            employeeAddress.Door = Console.ReadLine();
            Console.WriteLine("Street: ");
            employeeAddress.Street = Console.ReadLine();
            Console.WriteLine("State: ");
            employeeAddress.State = Console.ReadLine();
            Console.WriteLine("Country: ");
            employeeAddress.Country = Console.ReadLine();
            Console.WriteLine("Pincode: ");
            employeeAddress.Pincode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Department");
            Console.WriteLine("Name: ");
            employeeDepartment.Name = Console.ReadLine();
            Console.WriteLine("Location: ");
            employeeDepartment.Location = Console.ReadLine();

            Console.WriteLine("Salary: ");
            employee.Salary = Convert.ToInt32(Console.ReadLine());

            employee.Address = employeeAddress;
            employee.Department = employeeDepartment;

            this.Create(employee);
        }

        public void UpdateViaUserInput()
        {
            int employeeIdInput;

            Console.WriteLine("Employee ID: ");
            employeeIdInput = Convert.ToInt32(Console.ReadLine());

            try
            {
                this.Update(employeeIdInput);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Employee not found!");
            }
        }

        public void DeleteViaUserInput()
        {
            int employeeIdInput;

            Console.WriteLine("Employee ID: ");
            employeeIdInput = Convert.ToInt32(Console.ReadLine());

            try
            {
                this.Delete(employeeIdInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Employee not found!");
            }
        }

        public void FindViaUserInput()
        {
            int employeeIdInput;

            Console.WriteLine("Employee ID: ");
            employeeIdInput = Convert.ToInt32(Console.ReadLine());

            try
            {
                this.Find(employeeIdInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Employee not found!");
            }
        }
    }
}
