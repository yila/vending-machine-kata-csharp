using VendingMachineKata.interfaces;

namespace VendingMachineKata.implementations
{
    public class DisplayPanel : IDisplay
    {
        public string DisplayAmount(int cents)
        {
            return "INSERT COIN";
        }
    }
}