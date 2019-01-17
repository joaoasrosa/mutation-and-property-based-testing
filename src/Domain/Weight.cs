using System;
using System.Globalization;

namespace Domain
{
    public struct Weight : IEquatable<Weight>
    {
        private readonly uint _weight;

        private Weight(uint weight)
        {
            _weight = weight;
        }

        public static implicit operator uint(Weight weight)
        {
            return weight._weight;
        }

        public static explicit operator Weight(uint weight)
        {
            return new Weight(weight);
        }

        public static bool operator ==(Weight left, Weight right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Weight left, Weight right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Weight other)
        {
            return _weight == other._weight;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is Weight other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _weight.GetHashCode();
        }

        public override string ToString()
        {
            var copyOfWeight = _weight;
            return copyOfWeight.ToString(CultureInfo.InvariantCulture);
        }
    }
}
