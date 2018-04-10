using System;

namespace _26.访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure os = new ObjectStructure();
            os.Add(new InBill());
            os.Add(new OutBill());

            Visitor zongjingli = new ZongJingLiVisitor();
            Visitor itleader = new ITDepartmentLeaderVisitor();

            os.Show(zongjingli);
            os.Show(itleader);

            Console.ReadKey();
        }
    }
}
