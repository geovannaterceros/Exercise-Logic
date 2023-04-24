namespace Exercises.Models
{
    public class Container
    {
        private IEnumerable<Box> boxes = Enumerable.Empty<Box>();
        private IEnumerable<Item> items = Enumerable.Empty<Item>();

        public Guid Id { get; set; }

        public IEnumerable<Box> Boxes { get => boxes; set => boxes = value; }
        public IEnumerable<Item> Items { get => items; set => items = value; }
    }
}
