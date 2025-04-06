namespace _08.外观模式
{
    public class ShoppingCarFacade
    {
        private UserAuth userAuth;
        private StockSys stockSys;
        private OrderSys orderSys;
        private LogSys logSys;

        public ShoppingCarFacade()
        {
            userAuth = new UserAuth();
            stockSys = new StockSys();
            orderSys = new OrderSys();
            logSys = new LogSys();
        }

        public void Submit()
        {
            userAuth.Auth();
            stockSys.Jian();
            orderSys.Create();
            logSys.Write();
        }
    }
}
