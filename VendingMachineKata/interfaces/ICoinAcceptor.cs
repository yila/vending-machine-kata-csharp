namespace VendingMachineKata.interfaces
{
    public interface ICoinAcceptor
    {
        void AcceptCoin(Coin coin);
        int TotalAmount { get; set; }
    }
}