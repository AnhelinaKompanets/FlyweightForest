using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightForest
{
    public sealed class Forest
    {
        private readonly List<Tree> trees = new();

        public IReadOnlyList<Tree> Trees => trees;

        public void Add(Tree tree)
        {
            trees.Add(tree);
        }

        public void Clear()
        {
            trees.Clear();
        }

        public void Grow()
        {
            foreach (var t in trees)
                t.Grow();
        }

        public void Draw(Graphics g)
        {
            foreach (var t in trees)
                t.Type.Draw(g, t.X, t.Y, t.Size, t.Age);
        }
    }
}
