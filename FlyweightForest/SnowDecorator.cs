using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightForest
{
    public class SnowDecorator : ITreeDecorator
    {
        public void Draw(Graphics g, Tree tree)
        {
            float k = tree.Size;
            float crownTop = tree.Y - 5 * k;

            using var brush = new SolidBrush(Color.WhiteSmoke);

            g.FillEllipse(
                brush,
                tree.X - 18 * k,
                crownTop,
                36 * k,
                8 * k
            );
        }
    }
}
