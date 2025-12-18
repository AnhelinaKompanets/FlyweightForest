using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightForest
{
    public interface ITreeDecorator
    {
        void Draw(Graphics g, Tree tree);
    }
}