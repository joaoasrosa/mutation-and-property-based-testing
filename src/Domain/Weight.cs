using System.Globalization;

namespace Domain
{
    public struct Weight
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
