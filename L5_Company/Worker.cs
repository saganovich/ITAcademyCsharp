using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Company
{
    internal class Worker
    {
        private string firstName;
        private string lastName;
        private int age;
        private Company.Post post;
        private decimal salary;
        public string FirstName
        {
            get => firstName; set => firstName = value;
        }
        public string LastName
        {
            get => lastName; set => lastName = value;
        }
        public int Age
        {
            get => age; set => age = value;
        }
        public Company.Post Post
        {
            get => post;
            internal protected set => post = value;
        }
        public decimal Salary
        {
            get => salary;
            internal protected set => salary = value;
        }
        public Worker(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }
}
