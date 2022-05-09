using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataStore.Entities
{
    public class Teacher : EntittyBase
    {
        private string _courseName;

        public string CourseName
        {
            get 
            { 
                return _courseName; 
            }
            set
            {
                _courseName = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}, CourseName: {CourseName}";
        }

    }
}
