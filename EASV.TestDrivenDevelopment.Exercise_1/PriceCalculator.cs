namespace EASV.TestDrivenDevelopment.Exercise_1
{
    /*
     * A bus company has some weird rules for price calculation:
     * The price depends on the distance and the number of passengers.
     * The rules are as follows: There is an initial fee of 130 kr.
     * Anything below 100 km costing 3.20 kr. per kilometer, irrespective of passenger numbers.
     * For the kilometers that are above 100 and less than 500 paid 2.75 kr.
     * for each kilometer if there are less than 12 passengers.
     * If not below 12 passengers it costs 3.00 kr per kilometer.
     * For the kilometers above 500, each kilometer costs 2.25 kr.
     * In source-code, all these rules must be encapsulated in the following function:
        double TotalCost(int noOfPassengers, int kilometer);
        Implement the function using the TDD approach. 
     */
    
    public class PriceCalculator : IPriceCalculator
    {
        private double initialFee = 130;
        
        public double TotalCost(int noOfPassengers, int kilometer)
        {
            double totalCost = 0;
            
            if (kilometer < 100)
            {
                totalCost = kilometer * 3.2 + initialFee;
                return totalCost;
            }

            if (kilometer > 100 && kilometer <= 500 && noOfPassengers < 12)
            {
                totalCost = kilometer * 2.75 + initialFee;
                return totalCost;
            }

            if (kilometer > 100 && kilometer <= 500 && noOfPassengers >= 12)
            {
                totalCost = kilometer * 3 + initialFee;
                return totalCost;
            }

            if (kilometer > 500)
            {
                totalCost = kilometer * 2.25 + initialFee;
                return totalCost;
            }

            return totalCost;
        }
    }
}