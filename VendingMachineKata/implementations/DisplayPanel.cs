using System;
using VendingMachineKata.interfaces;

namespace VendingMachineKata.implementations
{
    public class DisplayPanel : IDisplay
    {
        public string DisplayAmount(int amount)
        {
            return amount > 0 ? $"{amount/100.0:C}" : "INSERT COIN";
        }
    }
}