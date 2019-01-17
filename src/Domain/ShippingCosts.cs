using System.Globalization;

namespace Domain
{
    public struct ShippingCosts
    {
        private readonly decimal _shippingCosts;

        private ShippingCosts(decimal shippingCosts)
        {
            _shippingCosts = shippingCosts;
        }

        public static implicit operator decimal(ShippingCosts shippingCosts)
        {
            return shippingCosts._shippingCosts;
        }

        public static explicit operator ShippingCosts(decimal shippingCosts)
        {
            return new ShippingCosts(shippingCosts);
        }

        public override int GetHashCode()
        {
            return _shippingCosts.GetHashCode();
        }

        public override string ToString()
        {
            var copyOfShippingCosts = _shippingCosts;
            return copyOfShippingCosts.ToString(CultureInfo.InvariantCulture);
        }
    }
}
