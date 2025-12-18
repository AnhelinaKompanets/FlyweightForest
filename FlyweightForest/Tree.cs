using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightForest
{
    public sealed class Tree
    {
        public int X { get; }
        public int Y { get; }
        public float Size { get; private set; }
        public int Age { get; private set; }
        public float Growth { get; }
        public TreeType Type { get; }

        public Tree(int x, int y, TreeType type)
        {
            X = x;
            Y = y;
            Type = type;
            Size = 1f;
            Age = 1;
            Growth = 0.02f;
        }

        public void Grow()
        {
            Age++;
            Size += Growth;
        }
    }
}
