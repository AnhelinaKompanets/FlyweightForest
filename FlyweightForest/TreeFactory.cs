using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightForest
{
    public sealed class TreeFactory
    {
        private readonly Dictionary<string, TreeType> types = new();

        public TreeType Get(string name, Color crown, Color trunk)
        {
            string key = name + crown.ToArgb() + trunk.ToArgb();

            if (!types.ContainsKey(key))
                types[key] = new TreeType(name, crown, trunk);

            return types[key];
        }

        public int Count => types.Count;
    }
}
