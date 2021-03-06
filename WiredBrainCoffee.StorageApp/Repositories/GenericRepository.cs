using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            _items.Add(item);  
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class EmployeeRepositoryWithRemove : GenericRepository<Employee>
    {
        public void Remove(Employee employee)
        {
            _items.Remove(employee);
        }
    }
}
