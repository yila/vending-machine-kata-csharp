namespace VendingMachineKata
{
    public class Coin
    {
        public double WeightInGrams { get; set; }
        public double DiameterInMilliMeter { get; set; }

        public int Value()
        {
            if (WeightInGrams == 5.67 && DiameterInMilliMeter == 24.26)
            {
                return 25;
            }
            if (WeightInGrams == 2.268 && DiameterInMilliMeter == 17.91)
            {
                return 10;
            }

            if (WeightInGrams == 5.0 && DiameterInMilliMeter == 21.21)
            {
                return 5;
            }

            if (WeightInGrams == 2.5 && DiameterInMilliMeter == 19.05)
            {
                return 1;
            }
            return 0;
        }

        public override bool Equals(object obj)
        {
            Coin coinToCompare = (Coin)obj;
            return WeightInGrams == coinToCompare.WeightInGrams && DiameterInMilliMeter == coinToCompare.DiameterInMilliMeter;
        }
    }
}