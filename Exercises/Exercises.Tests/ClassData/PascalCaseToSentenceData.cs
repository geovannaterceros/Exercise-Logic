using System.Collections;

namespace Exercises.Tests.ClassData
{
    public class PascalCaseToSentenceData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "SomeText",
                "Some text",
            };

            yield return new object[]
            {
                "someText",
                "some text",
            };

            yield return new object[]
            {
                "HelloThere!",
                "Hello there!",
            };

            yield return new object[]
            {
                "Somethingintheway",
                "Somethingintheway",
            };

            yield return new object[]
            {
                "IReadTheNewsToday",
                "I read the news today",
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
