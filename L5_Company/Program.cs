using static L5_Company.Company;

namespace L5_Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker wrk1 = new("Ivan", "Ivanov", 30);
            Worker wrk2 = new("Andrey", "Andreev", 23);
            Worker wrk3 = new("Nikita", "Nikitin", 23);
            Worker wrk4 = new("Egor", "Egorovich", 22);
            Console.WriteLine(wrk1.GetInfo());
            Company cmpny1 = new Company("Company1", "Minsk,Romanovskaya sloboda street,11");
            Company cmpny2 = new Company("Company2", "Minsk,Surganova street,5");
            cmpny1.Recruit(wrk1, Post.CEO, 20000);
            cmpny1.Recruit(wrk2, Post.Assistant, 2000);
            cmpny1.Recruit(wrk3, Post.SeniorManager, 5000);
            cmpny1.Recruit(wrk4, Post.TechnicalManager, 8000);
            Console.WriteLine(cmpny1.GetMainInfo());
            cmpny1.Dismiss(wrk1);
            cmpny1.SetPost(wrk2, Post.CEO);
            cmpny1.SetSalary(wrk2, 30000);
            Console.WriteLine(cmpny1.GetMainInfo());
        }
    }
}