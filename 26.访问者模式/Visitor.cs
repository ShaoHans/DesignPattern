namespace _26.访问者模式
{
    public abstract class Visitor
    {
        public abstract void CalcTotalInAmount(Bill bill);

        public abstract void CalcTotalOutAmount(Bill bill);
    }
}
