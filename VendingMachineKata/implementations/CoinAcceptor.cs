using VendingMachineKata.interfaces;

namespace VendingMachineKata.implementations
{
    public class CoinAcceptor : ICoinAcceptor
    {
        public int TotalAmount { get; set; }

        public bool AcceptCoin(Coin coin)
        {
            TotalAmount += coin.Value();
            return !coin.Equals(CoinFactory.Penny());
        }
    }
}