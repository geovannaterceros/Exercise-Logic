using Exercises.Interfaces;

namespace Exercises.Models
{
    public class Item : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
