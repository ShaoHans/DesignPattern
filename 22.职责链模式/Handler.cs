namespace _22.职责链模式
{
    public abstract class Handler
    {
        public string Name { get; protected set; }
        public Handler Superior { get; protected set; }

        public Handler(string name)
        {
            Name = name;
        }

        public void Next(Handler handler)
        {
            Superior = handler;
        }

        public abstract void HandleRequest(PurchaseRequest request);
    }
}
