using FluentAssertions;
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

            parcelShippingCosts.Should().Be(
                2m,
                "because the cost of shipping 1 kilo is 2 euro"
            );
        }
    }
}
