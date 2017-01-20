using System.Collections.Generic;
using VendingMachineKata.interfaces;

namespace VendingMachineKata
{
    public class VendingMachine
    {
        private readonly ICoinAcceptor _coinAcceptor;
        private readonly IDisplay _display;
        private readonly IList<Coin> _rejectedCoins = new List<Coin>(); 


        public VendingMachine(ICoinAcceptor coinAcceptor, IDisplay display)
        {
            _coinAcceptor = coinAcceptor;
            _display = display;
        }

        public IList<Coin> RejectedCoins()
        {
            return _rejectedCoins;
        }

        public string DisplayMessage()
        {
            return _display.DisplayAmount(_coinAcceptor.TotalAmount);
        }

        public void AcceptCoin(Coin coin)
        {
            if (!_coinAcceptor.AcceptCoin(coin))
            {
                _rejectedCoins.Add(coin);
            };
        }
    }
}