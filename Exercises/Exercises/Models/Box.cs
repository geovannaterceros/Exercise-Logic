using Exercises.Interfaces;

namespace Exercises.Models
{
    public class Box : IEntity
    {
        public Guid Id { get; set; }

        public IEnumerable<Item> Items { get; set; } = Enumerable.Empty<Item>();
    }
}
