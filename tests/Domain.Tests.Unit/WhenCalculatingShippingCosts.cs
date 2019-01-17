using Xunit;

namespace Domain.Tests.Unit
{
    public class WhenCalculatingShippingCosts
    {
        [Fact]
        public void GivenParcelWithSumOfItemsIsOneKilo_ThenShippingPriceIsTwoEuro()
        {
            var parcel = new Parcel(
                new Item(500),
                new Item(500)
            );

            var sut = new ShippingCostsService();

            var parcelShippingCosts = sut.CalculateShippingCosts(
                parcel
            );
        }
    }
}
