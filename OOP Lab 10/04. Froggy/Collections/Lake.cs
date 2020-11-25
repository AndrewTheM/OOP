using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Froggy.Collections
{
    public class Lake : IEnumerable<int>
    {
        private readonly IEnumerable<int> stoneNumbers;

        public Lake(IEnumerable<int> stoneNumbers)
        {
            this.stoneNumbers = stoneNumbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int count = stoneNumbers.Count();

            for (int i = 0; i < count; i += 2)
                yield return stoneNumbers.ElementAt(i);

            for (int i = count - 1 - count % 2; i >= 0 ; i -= 2)
                yield return stoneNumbers.ElementAt(i);
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
