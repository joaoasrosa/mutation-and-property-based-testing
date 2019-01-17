using System;
using System.Globalization;

namespace Domain
{
    public struct TotalWeight : IEquatable<TotalWeight>
    {
        private readonly ulong _totalWeight;

        private TotalWeight(ulong totalWeight)
        {
            _totalWeight = totalWeight;
        }

        public static implicit operator ulong(TotalWeight totalWeight)
        {
            return totalWeight._totalWeight;
        }

        public static explicit operator TotalWeight(ulong totalWeight)
        {
            return new TotalWeight(totalWeight);
        }

        public static bool operator ==(TotalWeight left, TotalWeight right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TotalWeight left, TotalWeight right)
        {
            return !left.Equals(right);
        }

        public bool Equals(TotalWeight other)
        {
            return _totalWeight == other._totalWeight;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is TotalWeight other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _totalWeight.GetHashCode();
        }

        public override string ToString()
        {
            var copyOfTotalWeight = _totalWeight;
            return copyOfTotalWeight.ToString(CultureInfo.InvariantCulture);
        }
    }
}
