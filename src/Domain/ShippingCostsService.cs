namespace Domain
{
    public class ShippingCostsService
    {
        private const decimal PricePerGram = 0.002m;

        public ShippingCosts CalculateShippingCosts(Parcel parcel)
        {
            return (ShippingCosts)(PricePerGram * parcel.TotalWeight);
        }
    }
}
