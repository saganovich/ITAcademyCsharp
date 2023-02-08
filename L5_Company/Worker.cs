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
            internal set => post = value;
        }
        public decimal Salary
        {
            get => salary;
            internal set => salary = value;
        }
        public Worker(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public string GetInfo()
        {
            return $"{this.FirstName} {this.LastName}\t|{this.Age}|\t{this.Post}|${this.Salary}";
        }
    }
}
