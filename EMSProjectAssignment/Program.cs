/**
    Build an EMS project where Person,Address, Employee, Department entites to be managed
    using a console based application

    1. Employee
        ID,  Department, Salary
    2. Department 
        ID, Name, Location
    3. Person
        ID, First Name, Last Name, DOB, Address
    4. Address
        Id,Door, Street, City, state, country, pincode

    Preapre CRUD operation for all the entites in Console based application.

    1. RunnerClass - where you will have a Menu to perform all the operations:
    2. Entity classes 
    3. Manager Classes - CRUD of each entity
*/

namespace EMSProjectAssignment
{
    using EMSProjectAssignment.Manager;

    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            int? input = null;

            Console.WriteLine("Employee Management System");

            while (input != 0)
            {
                Console.WriteLine("Operations: [1] Add [2] Update [3] Delete [4] Search by ID [5] List All [0] Exit");
                input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch(input)
                {
                    case 0: break; 
                    case 1:
                        employeeManager.CreateViaUserInput();
                        break;
                    case 2:
                        employeeManager.UpdateViaUserInput();
                        break;
                    case 3:
                        employeeManager.DeleteViaUserInput();
                        break;
                    case 4:
                        employeeManager.FindViaUserInput();
                        break;
                    case 5:
                        employeeManager.List();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using the system!");
        }
    }
}