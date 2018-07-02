using System;
using System.Collections.Generic;

    public class FairRandomiser
    {
        private Random rnd;
        private List<int> memory;
        public FairRandomiser()
        {
            rnd = new Random();
            memory = new List<int>();
        }

        public int NextInt(int size)
        {
            int x;
            do
            {
                x = rnd.Next(size);
            } while (memory.Contains(x));
            memory.Add(x);
            if (memory.Count == size)
            {
                memory = new List<int>();
            }
            return x;
        }
    }
