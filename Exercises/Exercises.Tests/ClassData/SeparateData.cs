using System.Collections;

namespace Exercises.Tests.ClassData
{
    public class SeparateData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "Adrian, Mayra, Paulo, Mariana, Jose",
                ',',
                new string[]
                {
                    "Adrian",
                    "Mayra",
                    "Paulo",
                    "Mariana",
                    "Jose",
                },
            };

            yield return new object[]
            {
                "3,2,46, 32,    63,6",
                ',',
                new string[]
                {
                    "3",
                    "2",
                    "46",
                    "32",
                    "63",
                    "6",
                },
            };

            yield return new object[]
            {
                "Apples/Grapes/ Bread/milk,butter",
                '/',
                new string[]
                {
                    "Apples",
                    "Grapes",
                    "Bread",
                    "milk,butter",
                },
            };

            yield return new object[]
            {
                "I read the news today, oh boy ",
                ' ',
                new string[]
                {
                    "I",
                    "read",
                    "the",
                    "news",
                    "today,",
                    "oh",
                    "boy",
                },
            };

            yield return new object[]
            {
                "Somewhere in her smile she knows",
                ',',
                new string[]
                {
                    "Somewhere in her smile she knows",
                },
            };

            yield return new object[]
            {
                " ",
                ',',
                Array.Empty<string>(),
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
