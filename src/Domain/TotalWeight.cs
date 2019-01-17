using System.Globalization;

namespace Domain
{
    public struct TotalWeight
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
