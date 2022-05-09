using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP_weekend
{
	public static class Program
	{
		public static void Main()
		{
			var objectTrial = new GenericMultiPurpose<ObjectTrial>();
			objectTrial.Add(new ObjectTrial{Name = "Zadok"});
			objectTrial.Add(new ObjectTrial{Name = "Josh"});
			objectTrial.Reverse();
			objectTrial.LastElementAndCount();
			
		}
	}
	
	public class ObjectTrial
	{
		
		public string Name {get; set;}
		
		public override string ToString() => $"Name: {Name}";

		
	}
	
	public class GenericMultiPurpose<T>
	{
		private readonly List<T> _items = new List<T>();
		
		public void Add(T item)
        {
            _items.Add(item);  
        }
        
        public void LastElementAndCount()
        {
        	int x = _items.Count();
        	int lastElement = x - 1;
        	Console.WriteLine("Total count in the list is " + x);
        	Console.WriteLine("Last element in the list is " + _items[lastElement]);
        }
        
        public void Reverse()
        {
        	for(int i = (_items.Count() - 1); i >= 0; i--)
        	{
        		Console.WriteLine(_items[i]);
        	}
        }
	}
	
}



