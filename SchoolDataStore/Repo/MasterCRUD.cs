using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataStore.Repo
{
    public class MasterCRUD<T>
    {
        public List<T> items = new List<T>();

        public void Create(T item)
        {
            items.Add(item);
            }

        public void Read()
        {
            foreach (var item in items) { Console.WriteLine(item); }
        }

        public void Update(T item)
        {
            items.Add(item);
        }

        public void Delete(int item)
        {
            items.RemoveAt(item);
        }
    }
}
