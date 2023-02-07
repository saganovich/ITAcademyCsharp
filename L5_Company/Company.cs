using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Company
{
    internal class Company
    {
        private string name;
        private string adress;
        private List<Worker> workers;
        public string Name
        {
            get => name; set => name = value;
        }
        private string Adress
        {
            get => adress; set => adress = value;
        }
        public int CountWorkers
        {
            get => workers.Count;
        }
        public void Recruit(Worker recruiter, Post post, decimal salary)
        {
            workers.Add(recruiter);
            recruiter.Post = post;
            recruiter.Salary = salary;

        }
        public void Dismiss(Worker recruiter)
        {
            recruiter.Post = Post.None;
            recruiter.Salary = 0;
            workers.Remove(recruiter);
        }

        public void SetPost(Worker worker, Post post)
        {
            worker.Post = post;
        }
        public void SetSalary(Worker worker, decimal salary)
        {
            worker.Salary = salary;
        }
        public StringBuilder GetMainInfo()
        {
            StringBuilder tempStr = new StringBuilder();
            tempStr.Append($"Company name: {this.Name}\nAdress: {this.Adress}\nCount workers: {this.CountWorkers}\n\nWorkers:\n");
            for (int i = 0; i < workers.Count; i++)
            {
                tempStr.Append($"[{i}]\t{workers[i].GetInfo()}\n");
            }
            tempStr.Append("---");
            return tempStr;
        }
        public Worker GetWorkerByIndex(int index)
        {
            if (index >= workers.Count) { return null; }
            return workers[index];
        }
        public Company(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
            this.workers = new List<Worker>();
        }
        public enum Post
        {
            None = 0,
            Staff = 1,
            Assistant = 2,
            SeniorManager = 3,
            TechnicalManager = 4,
            CEO = 5
        }
    }
}
