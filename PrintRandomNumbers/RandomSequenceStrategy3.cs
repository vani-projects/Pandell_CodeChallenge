using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintRandomNumbers
{
    public class RandomSequenceStrategy3:RandomSequenceStrategy
    {
        public IEnumerable<int> generateRandomSequence(int count)
        {
            Random random = new Random();

            List<int> original = Enumerable.Range(1, count).ToList();

            //Do a random shuffle
            List<int> sorted = original.OrderBy(item => random.Next()).ToList();

            return sorted;
        }
    }
}
