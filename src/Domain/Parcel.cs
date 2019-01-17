namespace Domain
{
    public class Parcel
    {
        private readonly Item[] _items;

        public Parcel(params Item[] items)
        {
            _items = items;
        }
    }
}
