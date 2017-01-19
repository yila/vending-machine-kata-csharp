using VendingMachineKata.interfaces;

namespace VendingMachineKata.implementations
{
    public class CoinAcceptor : ICoinAcceptor
    {
        public bool DetectCoin()
        {
            throw new System.NotImplementedException();
        }

        public int TotalAmount { get; set; }
    }
}