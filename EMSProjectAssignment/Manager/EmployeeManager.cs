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
        public List<Employee> GetAll()
        {
            return this.employees;
        }
        public void Create(Employee employee)
        {
            employee.Id = this.count++;
            this.employees.Add(employee);
        }
        public Employee Find(int employeeId)
        {
            Employee employee = this.employees.Find((emp) => emp.Id == employeeId);
            return employee;
        }
        public int FindIndex(int employeeId)
        {
            return this.employees.FindIndex(0, (emp) => emp.Id == employeeId);
        }
        public bool Exist(int employeeId)
        {
            return this.employees.Exists((emp) => emp.Id == employeeId);
        }
        public void Update(Employee updatedEmployee)
        {
            this.employees[FindIndex(updatedEmployee.Id)] = updatedEmployee;
        }
        public void DeleteAtIndex(int employeeIndex)
        {
            this.employees.RemoveAt(employeeIndex);
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

            Console.WriteLine("Employee successfully created!");
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"Date of Birth: {employee.DateOfBirth}");
            Console.WriteLine($"Address: {employee.Address.Door} {employee.Address.Street} {employee.Address.Country} {employee.Address.State} {employee.Address.Pincode}");
            Console.WriteLine($"Department: {employee.Department.Name} {employee.Department.Location}");
            Console.WriteLine($"Salary: {employee.Salary}");
        }
        public void UpdateViaUserInput()
        {
            int employeeIdInput;

            Console.WriteLine("Employee ID: ");
            employeeIdInput = Convert.ToInt32(Console.ReadLine());

            if (!this.Exist(employeeIdInput))
            {
                Console.WriteLine("Employee does not exist!");
                return;
            }

            Employee employeeToUpdate = this.Find(employeeIdInput);
            int? updateInput = null;

            while (updateInput != 0)
            {
                Console.WriteLine("Update [1] Employee Info [2] Address [3] Department [0] Exit Update: ");

                try
                {
                    updateInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input, out of bounds. Please try again.");
                }

                switch (updateInput)
                {
                    case 0: break;
                    case 1:
                        this.UpdateEmployeeInfo(employeeToUpdate);
                        break;
                    case 2:
                        this.UpdateEmployeeAddress(employeeToUpdate);
                        break;
                    case 3:
                        this.UpdateEmployeeDepartment(employeeToUpdate);
                        break;
                    default:
                        Console.WriteLine("Invalid input, out of bounds. Please try again.");
                        break;
                }
            }
        }
        public void UpdateEmployeeInfo(Employee employeeToUpdate)
        {
            string FirstName, LastName, DateOfBirth, Salary;

            Console.WriteLine("First Name: (Press ENTER to skip)");
            FirstName = Console.ReadLine();
            Console.WriteLine("Last Name: (Press ENTER to skip)");
            LastName = Console.ReadLine();
            Console.WriteLine("Date of Birth (mm/dd/yyyy): (Press ENTER to skip)");
            DateOfBirth = Console.ReadLine();
            Console.WriteLine("Salary: (Press ENTER to skip)");
            Salary = Console.ReadLine();

            employeeToUpdate.FirstName = 
                    String.IsNullOrEmpty(FirstName) ? employeeToUpdate.FirstName : FirstName;
            employeeToUpdate.LastName =
                    String.IsNullOrEmpty(LastName) ? employeeToUpdate.LastName : LastName;
            employeeToUpdate.DateOfBirth =
                    String.IsNullOrEmpty(DateOfBirth) ? employeeToUpdate.DateOfBirth : DateOfBirth;
            employeeToUpdate.Salary =
                    String.IsNullOrEmpty(Salary) ? employeeToUpdate.Salary : Convert.ToInt32(Salary);

            this.Update(employeeToUpdate);
        }
        public void UpdateEmployeeAddress(Employee employeeToUpdate)
        {
            string Door, Street, State, Country, Pincode;

            Console.WriteLine("Address");
            Console.WriteLine("Door: (Press ENTER to skip)");
            Door = Console.ReadLine();
            Console.WriteLine("Street: (Press ENTER to skip)");
            Street = Console.ReadLine();
            Console.WriteLine("State: (Press ENTER to skip)");
            State = Console.ReadLine();
            Console.WriteLine("Country: (Press ENTER to skip)");
            Country = Console.ReadLine();
            Console.WriteLine("Pincode: (Press ENTER to skip)");
            Pincode = Console.ReadLine();

            employeeToUpdate.Address.Door = 
                    String.IsNullOrEmpty(Door) ? employeeToUpdate.Address.Door : Door;
            employeeToUpdate.Address.Street =
                    String.IsNullOrEmpty(Street) ? employeeToUpdate.Address.Street : Street;
            employeeToUpdate.Address.State =
                    String.IsNullOrEmpty(State) ? employeeToUpdate.Address.State : State;
            employeeToUpdate.Address.Country =
                    String.IsNullOrEmpty(Country) ? employeeToUpdate.Address.Country : Country;
            employeeToUpdate.Address.Pincode =
                    String.IsNullOrEmpty(Pincode) ? employeeToUpdate.Address.Pincode : Convert.ToInt32(Pincode);

            this.Update(employeeToUpdate);
        }
        public void UpdateEmployeeDepartment(Employee employeeToUpdate)
        {
            string Name, Location;

            Console.WriteLine("Department");
            Console.WriteLine("Name: (Press ENTER to skip)");
            Name = Console.ReadLine();
            Console.WriteLine("Location: (Press ENTER to skip)");
            Location = Console.ReadLine();

            employeeToUpdate.Department.Name = 
                String.IsNullOrEmpty(Name) ? employeeToUpdate.Department.Name : Name;
            employeeToUpdate.Department.Location =
                String.IsNullOrEmpty(Location) ? employeeToUpdate.Department.Location : Location;

            this.Update(employeeToUpdate);
        }
        public void DeleteViaUserInput()
        {
            int employeeIdInput;

            Console.WriteLine("Employee ID: ");
            employeeIdInput = Convert.ToInt32(Console.ReadLine());

            try
            {
                int employeeIndex = this.FindIndex(employeeIdInput);
                if(employeeIdInput == -1)
                {
                    Console.WriteLine("Employee not found!");
                }

                this.DeleteAtIndex(employeeIndex);
                Console.WriteLine("Employee removed.");
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
                Employee employee = this.Find(employeeIdInput);
                Console.WriteLine($"ID \t\tName \t\tDepartment \t\tSalary");
                Console.WriteLine($"{employee.Id} \t{employee.FirstName} {employee.LastName} \t{employee.Department.Name} \t{employee.Salary}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Employee not found!");
            }
        }
        public void ViewOptions()
        {
            int? viewInput = null;

            while (viewInput != 0)
            {
                Console.WriteLine("View Employee [1] All Employee [2] Info [3] Address [4] Department [0] Exit View");

                try
                {
                    viewInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input, out of bounds. Please try again.");
                }

                Console.Clear();

                switch (viewInput)
                {
                    case 0: break; 
                    case 1:
                        this.ListAll();
                        break;
                    case 2:
                        this.ViewInfo();
                        break;
                    case 3:
                        this.ViewAddress();
                        break;
                    case 4:
                        this.ViewDepartment();
                        break;
                    default:
                        Console.WriteLine("Invalid input, out of bounds. Please try again.");
                        break;
                }
            }
        }
        public void ListAll()
        {
            List<Employee> employees = this.GetAll();
            Console.WriteLine("List of Employees: ");
            Console.WriteLine("ID \t\tName");
            employees.ForEach((employee) =>
            {
                Console.WriteLine($"{employee.Id} \t\t{employee.FirstName} {employee.LastName}");
            });
        }
        public void ViewInfo()
        {
            Console.WriteLine("Employee ID: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            if (!this.Exist(employeeId))
            {
                Console.WriteLine("Employee does not exist!");
                return;
            }

            Employee employee = this.Find(employeeId);
            Console.WriteLine("ID \t\tName \t\tDate of Birth \t\tSalary");
            Console.WriteLine($"{employee.Id} " +
                $"\t\t{employee.FirstName} {employee.LastName} " +
                $"\t{employee.DateOfBirth}  \t\t{employee.Salary}");
        }
        public void ViewAddress()
        {
            Console.WriteLine("Employee ID: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            if (!this.Exist(employeeId))
            {
                Console.WriteLine("Employee does not exist!");
                return;
            }

            Employee employee = this.Find(employeeId);
            Console.WriteLine("ID \t\tName \t\tAddress");
            Console.WriteLine($"{employee.Id} " +
                $"\t\t{employee.FirstName} {employee.LastName} " +
                $"\t{employee.Address.Door} {employee.Address.Street} " +
                $"{employee.Address.State} {employee.Address.Country} {employee.Address.Pincode}");
        }
        public void ViewDepartment()
        {
            Console.WriteLine("Employee ID: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            if (!this.Exist(employeeId))
            {
                Console.WriteLine("Employee does not exist!");
                return;
            }

            Employee employee = this.Find(employeeId);
            Console.WriteLine("ID \t\tName \t\tDepartment Name \t\tDepartment Location");
            Console.WriteLine($"{employee.Id} " +
                $"\t\t{employee.FirstName} {employee.LastName} " +
                $"\t{employee.Department.Name} " +
                $"\t\t{employee.Department.Location}");
        }
    }
}
