namespace Domain
{
    public class Parcel
    {
        private readonly Item[] _items;

        public Parcel(params Item[] items)
        {
            _items = items;
        }

        public TotalWeight TotalWeight
        {
            get
            {
                ulong totalWeight = 0;

                foreach (var item in _items)
                {
                    totalWeight += item.Weight;
                }

                return (TotalWeight)totalWeight;
            }
        }
    }
}
