using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new Employee { FirstName = "Zadok" });
employeeRepository.Add(new Employee { FirstName = "Samuel" });
employeeRepository.Add(new Employee { FirstName = "James" });

var organizationRepository = new GenericRepository<Organization>();
organizationRepository.Add(new Organization { Name = "GLO" });
organizationRepository.Add(new Organization { Name = "CypherCrescent Ltd" });

employeeRepository.Save();
organizationRepository.Save(); 

Console.ReadLine();