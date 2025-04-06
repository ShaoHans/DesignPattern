using System;

namespace _06.原型模式
{
    public class Resume : ICloneable
    {
        public string Company { get; protected set; }

        public int Year { get; protected set; }

        public void SetWorkExperience(string company, int year)
        {
            Company = company;
            Year = year;
        }

        public void Show()
        {
            Console.WriteLine($"{Year}年,我在{Company}公司上班");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
