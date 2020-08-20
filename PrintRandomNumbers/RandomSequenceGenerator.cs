using System;
using System.Collections.Generic;
namespace PrintRandomNumbers
{
    public class RandomSequenceGenerator
    {
        RandomSequenceStrategy strategy { get; set; }

        public RandomSequenceGenerator(RandomSequenceStrategy strategy)
        {
            this.strategy = strategy;
        }
        public RandomSequenceGenerator() { }



        public static void Main(string[] args)
        {
            try
            {
                DateTime start = DateTime.Now;

                RandomSequenceGenerator generator = new RandomSequenceGenerator();

                int genCount = System.Int32.Parse(args[0]);
                int strategy = System.Int32.Parse(args[1]);

                switch (strategy) // Select a strategy based on the program input
                {
                    case 1:
                        generator.strategy = new RandomSequenceStrategy1();
                        break;
                    case 2:
                        generator.strategy = new RandomSequenceStrategy2();
                        break;
                    case 3:
                        generator.strategy = new RandomSequenceStrategy3();
                        break;
                    default:
                        generator.strategy = new RandomSequenceStrategy1(); // Use strategy 1 by default
                        break;
                }


                IEnumerable<int> randomSequence = generator.strategy.generateRandomSequence(genCount);

                Console.WriteLine("Random Sequence of Numbers:");
                foreach (int randomNum in randomSequence)
                {
                    Console.WriteLine(randomNum);
                }

                DateTime end = DateTime.Now;
                Console.WriteLine("Elapsed Time:" + (end - start));
            }
            catch(Exception e)
            {
                Console.WriteLine("Usage: RandomSequenceGenerator <count> <strategy:1|2|3>");
            }
        }
    }
}
