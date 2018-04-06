using System;

namespace _16.组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("阿里巴巴杭州总部");
            root.Add(new HrDepartment("集团HR部"));
            root.Add(new FianceDepartment("集团财务部"));

            ConcreteCompany beijing = new ConcreteCompany("阿里巴巴北京分公司");
            beijing.Add(new HrDepartment("北京分公司HR部"));
            beijing.Add(new FianceDepartment("北京分公司财务部"));

            root.Add(beijing);
            root.Display(1);
            root.LineOfDuty();


            Console.ReadKey();
        }
    }
}
