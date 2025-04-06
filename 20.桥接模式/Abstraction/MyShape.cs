namespace _20.桥接模式
{
    public abstract class MyShape
    {
        protected MyColor _color;

        public void SetColor(MyColor color)
        {
            _color = color;
        }

        public abstract void Draw();
    }
}
