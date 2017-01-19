using VendingMachineKata.interfaces;

namespace VendingMachineKata.implementations
{
    public class CoinAcceptor : ICoinAcceptor
    {
        public int TotalAmount { get; set; }

        public void AcceptCoin(Coin coin)
        {
            TotalAmount += coin.Value();
        }
    }
}