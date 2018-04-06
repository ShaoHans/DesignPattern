using System;

namespace _15.备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================打BOSS之前=================");
            Originator originator = new Originator(100, 100, 100);
            originator.Show();

            Console.WriteLine("====================游戏存档=================");
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.SaveMemento();

            Console.WriteLine("====================战斗开始=================");
            originator.Fight();
            originator.Show();
            Console.WriteLine("====================战斗结束=================");

            Console.WriteLine("====================恢复=================");
            originator.RestoreMemento(caretaker.Memento);
            originator.Show();

            Console.ReadKey();
        }
    }
}
