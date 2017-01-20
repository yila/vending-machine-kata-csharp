namespace VendingMachineKata.interfaces
{
    public interface ICoinAcceptor
    {
        bool AcceptCoin(Coin coin);
        int TotalAmount { get; set; }
    }
}