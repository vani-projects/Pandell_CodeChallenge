using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintRandomNumbers
{
    public class RandomSequenceStrategy1:RandomSequenceStrategy
    {
        public IEnumerable<int> generateRandomSequence(int count)
        {
            int[] numbers = new int[count];
            List<int> availablePositions = Enumerable.Range(0, count).ToList();

            int iterations = 0;

            Random random = new Random();
            for (int i = 1; i < count + 1; i++)
            {
                int randomPos = random.Next(availablePositions.Count);
                int insertAt = availablePositions[randomPos];
                numbers[insertAt] = i;
                availablePositions.RemoveAt(randomPos);
                iterations++;
            }

            Console.WriteLine("Total Number of Iterations:" + iterations);

            return numbers;
        }
    }
}
