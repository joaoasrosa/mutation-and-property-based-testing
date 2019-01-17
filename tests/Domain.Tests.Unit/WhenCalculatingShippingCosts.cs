using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Domain.Tests.Unit
{
    public class WhenCalculatingShippingCosts
    {
        public class SingleDataPoint
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

                ((decimal)parcelShippingCosts).Should().Be(
                    2m,
                    "because the cost of shipping 1 kilo is 2 euro"
                );
            }

            [Fact]
            public void GivenParcelWithSumOfItemsIsZeroGrams_ThenShippingPriceIsZeroEuro()
            {
                var parcel = new Parcel(
                    new Item(0),
                    new Item(0)
                );

                var sut = new ShippingCostsService();

                var parcelShippingCosts = sut.CalculateShippingCosts(
                    parcel
                );

                ((decimal)parcelShippingCosts).Should().Be(
                    0m,
                    "because the cost of shipping 1 kilo is 2 euro"
                );
            }
        }

        public class ClassData
        {
            [Theory]
            [ClassData(typeof(ParcelData))]
            public void GivenParcelWithSumOfItems_ThenShippingPriceIsCorrect(
                Parcel parcel,
                decimal shippingCosts
            )
            {
                var sut = new ShippingCostsService();

                var parcelShippingCosts = sut.CalculateShippingCosts(
                    parcel
                );

                ((decimal)parcelShippingCosts).Should().Be(
                    shippingCosts,
                    $"because the cost of shipping {parcel.TotalWeight} grams is {shippingCosts} euro"
                );
            }

            private class ParcelData : IEnumerable<object[]>
            {
                public IEnumerator<object[]> GetEnumerator()
                {
                    yield return new object[] {CreateParcel(500, 500), 2M};
                    yield return new object[] {CreateParcel(0, 0), 0M};
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return GetEnumerator();
                }

                private static Parcel CreateParcel(params uint[] weights)
                {
                    var items = new List<Item>();

                    foreach (var weight in weights)
                    {
                        items.Add(new Item(weight));
                    }

                    return new Parcel(items.ToArray());
                }
            }
        }
    }
}
