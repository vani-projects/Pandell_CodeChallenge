using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintRandomNumbers
{
    public class RandomSequenceStrategy2:RandomSequenceStrategy
    {
        public IEnumerable<int> generateRandomSequence(int count)
        {
            int iterations = 0;
            Random random = new Random();

            HashSet<int> randomNumbers = new HashSet<int>();
            while (randomNumbers.Count < count)
            {
                int r = random.Next(1, count + 1);
                randomNumbers.Add(r); // May succeed or fail (Hashset will only allow unique values). Keep trying to add unique random numbers till you got all
            }

            Console.WriteLine("Total Number of Iterations:" + iterations);

            return randomNumbers;
        }
    }
}
