using System;
using System.Globalization;

namespace Domain
{
    public struct ShippingCosts : IEquatable<ShippingCosts>
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

        public static bool operator ==(ShippingCosts left, ShippingCosts right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ShippingCosts left, ShippingCosts right)
        {
            return !left.Equals(right);
        }

        public bool Equals(ShippingCosts other)
        {
            return _shippingCosts == other._shippingCosts;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is ShippingCosts other && Equals(other);
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
