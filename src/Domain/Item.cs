namespace Domain
{
    public struct Item
    {
        internal Weight Weight { get; }

        public Item(uint weight)
        {
            Weight = (Weight)weight;
        }
    }
}
