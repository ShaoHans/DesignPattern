namespace _11.发布订阅模式
{
    public interface ISubject
    {
        event UpdateHandler Update;

        void Nodify();
    }
}
