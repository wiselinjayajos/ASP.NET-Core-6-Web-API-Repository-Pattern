using HRISWebAPI.Data;
using HRISWebAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace HRISWebAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly List<Employee> _employees;

        //to be used with the actual db connection
        //public EmployeeRepository(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public EmployeeRepository()
        {
            // Sample data to simulate database records
            _employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "johndoe@example.com", Phone = "123-456-7890", MiddleInitial = "A", SocialSecurityNumber = "XXX-XX-1234", Address1 = "123 Main St", City = "City A", State = "CA", Zip = "90001", Gender = "Male", DateOfBirth = new DateTime(1985, 1, 1), MaritalStatus = "Single", StartDate = new DateTime(2020, 1, 1), Department = "IT", PayRate = 60000, Store = "HQ", Position = "Developer", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "janesmith@example.com", Phone = "987-654-3210", MiddleInitial = "B", SocialSecurityNumber = "XXX-XX-5678", Address1 = "456 Oak St", City = "City B", State = "TX", Zip = "75001", Gender = "Female", DateOfBirth = new DateTime(1990, 5, 12), MaritalStatus = "Married", StartDate = new DateTime(2021, 6, 1), Department = "HR", PayRate = 55000, Store = "HQ", Position = "HR Manager", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" },
            new Employee { Id = 3, FirstName = "Sam", LastName = "Wilson", Email = "samwilson@example.com", Phone = "555-555-5555", MiddleInitial = "C", SocialSecurityNumber = "XXX-XX-9101", Address1 = "789 Pine St", City = "City C", State = "FL", Zip = "33001", Gender = "Male", DateOfBirth = new DateTime(1988, 3, 23), MaritalStatus = "Single", StartDate = new DateTime(2019, 11, 15), Department = "Finance", PayRate = 50000, Store = "HQ", Position = "Accountant", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" },
            new Employee { Id = 4, FirstName = "Alice", LastName = "Johnson", Email = "alicejohnson@example.com", Phone = "111-222-3333", MiddleInitial = "D", SocialSecurityNumber = "XXX-XX-1023", Address1 = "101 Elm St", City = "City D", State = "NY", Zip = "10001", Gender = "Female", DateOfBirth = new DateTime(1992, 8, 10), MaritalStatus = "Single", StartDate = new DateTime(2020, 5, 20), Department = "Marketing", PayRate = 65000, Store = "HQ", Position = "Marketing Manager", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" },
            new Employee { Id = 5, FirstName = "Bob", LastName = "Brown", Email = "bobbrown@example.com", Phone = "222-333-4444", MiddleInitial = "E", SocialSecurityNumber = "XXX-XX-3045", Address1 = "202 Cedar St", City = "City E", State = "NV", Zip = "89001", Gender = "Male", DateOfBirth = new DateTime(1985, 12, 5), MaritalStatus = "Married", StartDate = new DateTime(2018, 9, 30), Department = "Sales", PayRate = 70000, Store = "HQ", Position = "Sales Manager", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" },
            new Employee { Id = 6, FirstName = "Charlie", LastName = "Davis", Email = "charliedavis@example.com", Phone = "333-444-5555", MiddleInitial = "F", SocialSecurityNumber = "XXX-XX-5671", Address1 = "303 Birch St", City = "City F", State = "IL", Zip = "60001", Gender = "Male", DateOfBirth = new DateTime(1979, 4, 19), MaritalStatus = "Married", StartDate = new DateTime(2019, 1, 3), Department = "Engineering", PayRate = 75000, Store = "HQ", Position = "Lead Engineer", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" },
            new Employee { Id = 7, FirstName = "Diane", LastName = "Garcia", Email = "dianegarcia@example.com", Phone = "444-555-6666", MiddleInitial = "G", SocialSecurityNumber = "XXX-XX-1098", Address1 = "404 Maple St", City = "City G", State = "PA", Zip = "17001", Gender = "Female", DateOfBirth = new DateTime(1987, 6, 25), MaritalStatus = "Married", StartDate = new DateTime(2017, 12, 1), Department = "Support", PayRate = 58000, Store = "HQ", Position = "Support Manager", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" },
            new Employee { Id = 8, FirstName = "Eve", LastName = "Martinez", Email = "evemartinez@example.com", Phone = "555-666-7777", MiddleInitial = "H", SocialSecurityNumber = "XXX-XX-2389", Address1 = "505 Spruce St", City = "City H", State = "GA", Zip = "30001", Gender = "Female", DateOfBirth = new DateTime(1994, 9, 14), MaritalStatus = "Single", StartDate = new DateTime(2020, 4, 18), Department = "IT", PayRate = 64000, Store = "HQ", Position = "Developer", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" },
            new Employee { Id = 9, FirstName = "Frank", LastName = "Lopez", Email = "franklopez@example.com", Phone = "666-777-8888", MiddleInitial = "I", SocialSecurityNumber = "XXX-XX-5679", Address1 = "606 Pine St", City = "City I", State = "NC", Zip = "27001", Gender = "Male", DateOfBirth = new DateTime(1993, 11, 7), MaritalStatus = "Married", StartDate = new DateTime(2021, 3, 5), Department = "Legal", PayRate = 78000, Store = "HQ", Position = "Attorney", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" },
            new Employee { Id = 10, FirstName = "Grace", LastName = "Thomas", Email = "gracethomas@example.com", Phone = "777-888-9999", MiddleInitial = "J", SocialSecurityNumber = "XXX-XX-1948", Address1 = "707 Oak St", City = "City J", State = "VA", Zip = "22001", Gender = "Female", DateOfBirth = new DateTime(1984, 12, 12), MaritalStatus = "Single", StartDate = new DateTime(2018, 7, 20), Department = "Marketing", PayRate = 61000, Store = "HQ", Position = "Marketing Executive", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" },
            new Employee { Id = 11, FirstName = "Hank", LastName = "White", Email = "hankwhite@example.com", Phone = "888-999-0000", MiddleInitial = "K", SocialSecurityNumber = "XXX-XX-1848", Address1 = "808 Cedar St", City = "City K", State = "OH", Zip = "44001", Gender = "Male", DateOfBirth = new DateTime(1982, 7, 11), MaritalStatus = "Married", StartDate = new DateTime(2019, 10, 21), Department = "Operations", PayRate = 67000, Store = "HQ", Position = "Operations Manager", EmployeeStatus = "FullTime", PayType = "Salary", PayFrequency = "Monthly", WOTCResult = "Pass" }
            };
        }

        public async Task<IEnumerable<Employee>> GetAllAsync(int pageNumber, int pageSize)
        {
            // Apply pagination using LINQ Skip and Take methods
            var paginatedEmployees = _employees
                .Skip((pageNumber - 1) * pageSize) // Skip the previous pages
                .Take(pageSize)                    // Take only the pageSize items
                .ToList();

            return await Task.FromResult(paginatedEmployees); // Return the paginated employee list
            //return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            return await Task.FromResult(employee); // Return the matching employee or null
            //return await _context.Employees.FindAsync(id);
        }
    }
}
