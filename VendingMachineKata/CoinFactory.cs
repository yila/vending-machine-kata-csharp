namespace VendingMachineKata
{
    public static class CoinFactory
    {
        public static Coin Quarter()
        {
            return new Coin {WeightInGrams = 5.67, DiameterInMilliMeter = 24.26};
        }

        public static Coin Dime()
        {
            return new Coin {WeightInGrams = 2.268, DiameterInMilliMeter = 17.91};
        }

        public static Coin Nickel()
        {
            return new Coin {WeightInGrams = 5.0, DiameterInMilliMeter = 21.21};
        }

        public static Coin Penny()
        {
            return new Coin { WeightInGrams = 2.5, DiameterInMilliMeter = 19.05 };
        }
    }
}