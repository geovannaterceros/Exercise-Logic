using Exercises.Models;
using System.Collections;

namespace Exercises.Tests.ClassData.ValidateList
{
    internal class OrderByThenBy : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new List<Person> () { 
                    new Person() { Name = "Perez", Age = 25}, 
                    new Person() { Name = "Gomez", Age = 30}, 
                    new Person() { Name = "Garcia", Age = 28}, 
                    new Person() { Name = "Gomez", Age = 27} },
                new List<Person> () {
                    new Person() { Name = "Garcia", Age = 28},
                    new Person() { Name = "Gomez", Age = 27},
                    new Person() { Name = "Gomez", Age = 30},
                    new Person() { Name = "Perez", Age = 25}
                    }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
