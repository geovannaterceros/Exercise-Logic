using Exercises.Models;
using Exercises.Tests.Helpers;
using System.Collections;

namespace Exercises.Tests.ClassData
{
    public class HasPropertyData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                typeof(Container),
                "items",
                false,
            };

            yield return new object[]
            {
                typeof(Container),
                "Items",
                true,
            };

            yield return new object[]
            {
                typeof(MyClass),
                "Age",
                true,
            };

            yield return new object[]
            {
                typeof(MyInterface),
                "Id",
                true,
            };

            yield return new object[]
            {
                typeof(MyInterface),
                "Items",
                false,
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
