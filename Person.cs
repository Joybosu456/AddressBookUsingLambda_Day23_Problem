using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLamdaDemo
{
    public class Person
    {
        public string PhNo;
        public string Name;
        public string Address;
        
        public int Age;

        public Person(string phno,string name,string address,int age)
        {
            PhNo = phno;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}
