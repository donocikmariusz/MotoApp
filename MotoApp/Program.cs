using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());

employeeRepository.Add(new Employee { FirstName = "Jarosław" });
employeeRepository.Add(new Employee { FirstName = "Zbigniew" });
employeeRepository.Add(new Employee { FirstName = "Maciej" });
employeeRepository.Save();

GetEmployeeById(employeeRepository);

static void GetEmployeeById(IRepository<Employee> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine(employee.ToString());
}