using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Models
{
    internal class People<T>
    {
        T[] arr;
        private string _name;
        private string _surname;
        private int _age;

        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string Surname        
        {
            get { return _surname; }
            set { _surname = value; }
        }

        
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public People(T[] arr, string name, string surname, int age)
        {
            this.arr = arr;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void FindAll(string name,string surname,int age) 
        { 
            foreach (var item in arr) 
            {
                if (item)
                {
                    age++;
                }
            }
        }
    }
}
