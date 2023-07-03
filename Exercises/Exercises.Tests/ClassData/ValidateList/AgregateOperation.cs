using Exercises.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests.ClassData.ValidateList
{
    internal class AgregateOperation : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new List<int> () {1,2,3,4,5},
                15
            };
            yield return new object[] {
                new List<int> () {-1,-2,3,4,5},
                9
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
