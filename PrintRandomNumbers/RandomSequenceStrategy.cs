using System;
using System.Collections.Generic;

namespace PrintRandomNumbers
{
    public interface RandomSequenceStrategy
    {
        public IEnumerable<int> generateRandomSequence(int count);
    }
}
