using Exercises.Models;
using System.Collections;

namespace Exercises.Tests.ClassData
{
    public class CountItemsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Container()
                {
                    Id = Guid.NewGuid(),
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Foo",
                        },
                        new Item()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Bar",
                        },
                    },
                    Boxes = new List<Box>()
                    {
                        new Box()
                        {
                            Id= Guid.NewGuid(),
                            Items = new List<Item>()
                            {
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Foo",
                                },
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Bar",
                                },
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Faz",
                                },
                            }
                        },
                        new Box()
                        {
                            Id= Guid.NewGuid(),
                            Items = new List<Item>()
                            {
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Foo",
                                },
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Bar",
                                },
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Faz",
                                },
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Baz",
                                },
                            },
                        },
                    },
                },
                9
            };

            yield return new object[]
            {
                new Container()
                {
                    Id = Guid.NewGuid(),
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Foo",
                        },
                        new Item()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Bar",
                        },
                    },
                    Boxes = Enumerable.Empty<Box>()
                },
                2
            };

            yield return new object[]
            {
                new Container()
                {
                    Id = Guid.NewGuid(),
                    Items = Enumerable.Empty<Item>(),
                    Boxes = new List<Box>()
                    {
                        new Box()
                        {
                            Id= Guid.NewGuid(),
                            Items = new List<Item>()
                            {
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Foo",
                                },
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Bar",
                                },
                            }
                        },
                        new Box()
                        {
                            Id= Guid.NewGuid(),
                            Items = new List<Item>()
                            {
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Foo",
                                },
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Bar",
                                },
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Faz",
                                },
                                new Item()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Baz",
                                },
                            },
                        },
                    },
                },
                6
            };

            yield return new object[]
            {
                new Container()
                {
                    Id = Guid.NewGuid(),
                    Items = Enumerable.Empty<Item>(),
                    Boxes = new List<Box>()
                    {
                        new Box()
                        {
                            Id= Guid.NewGuid(),
                            Items = Enumerable.Empty<Item>()
                        },
                        new Box()
                        {
                            Id= Guid.NewGuid(),
                            Items = Enumerable.Empty<Item>()
                        },
                    },
                },
                0
            };

            yield return new object[]
            {
                new Container()
                {
                    Id = Guid.NewGuid(),
                    Items = Enumerable.Empty<Item>(),
                    Boxes = Enumerable.Empty<Box>()
                },
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
