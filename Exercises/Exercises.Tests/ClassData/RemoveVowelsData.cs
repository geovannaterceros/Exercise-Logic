using System.Collections;

namespace Exercises.Tests.ClassData
{
    public class RemoveVowelsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "Some text",
                "Sm txt",
            };

            yield return new object[]
            {
                "Hello World!",
                "Hll Wrld!",
            };

            yield return new object[]
            {
                "Hi!",
                "H!",
            };

            yield return new object[]
            {
                "In the end",
                "n th nd",
            };

            yield return new object[]
            {
                "aei ou",
                " ",
            };

            yield return new object[]
            {
                "",
                "",
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
