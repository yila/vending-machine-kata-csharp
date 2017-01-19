namespace VendingMachineKata.interfaces
{
    public interface ICoinAcceptor
    {
        bool DetectCoin();
        int TotalAmount { get; set; }
    }
}