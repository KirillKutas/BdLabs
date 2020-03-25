using System;
using System.Collections.Generic;
using System.Text;

namespace laba2
{
    class Customer
    {
        string name;
        int age;
        string gender;
        string phoneNumber;

        public string Name {get{return name;}}
        public int Age{get{return age;}}
        public string Gender{get{return gender;}}
        public string PhoneNumber{get{return phoneNumber;}}

        public Customer(string name, int age, string gender, string phoneNumber)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
        }
    }
}
