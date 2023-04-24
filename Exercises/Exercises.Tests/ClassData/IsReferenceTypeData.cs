using Exercises.Models;
using Exercises.Tests.Helpers;
using System.Collections;

namespace Exercises.Tests.ClassData
{
    public class IsReferenceTypeData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                typeof(Container),
                true
            };

            yield return new object[]
            {
                typeof(bool),
                false,
            };

            yield return new object[]
            {
                typeof(MyClass),
                true,
            };

            yield return new object[]
            {
                typeof(MyDelegate),
                true,
            };

            yield return new object[]
            {
                typeof(MyEnum),
                false,
            };

            yield return new object[]
            {
                typeof(MyInterface),
                true,
            };

            yield return new object[]
            {
                typeof(MyRecord),
                true,
            };

            yield return new object[]
            {
                typeof(MyStruct),
                false,
            };

            yield return new object[]
            {
                typeof(int),
                false,
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
