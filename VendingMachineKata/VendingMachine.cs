using VendingMachineKata.interfaces;

namespace VendingMachineKata
{
    public class VendingMachine
    {
        private readonly ICoinAcceptor _coinAcceptor;
        private readonly IDisplay _display;

        public VendingMachine(ICoinAcceptor coinAcceptor, IDisplay display)
        {
            _coinAcceptor = coinAcceptor;
            _display = display;
        }

        public string DisplayMessage()
        {
            return _display.DisplayAmount(_coinAcceptor.TotalAmount);
        }

    }
}