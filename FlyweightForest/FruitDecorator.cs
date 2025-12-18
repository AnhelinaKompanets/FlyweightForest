using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightForest
{
    public class FruitDecorator : ITreeDecorator
    {
        public void Draw(Graphics g, Tree tree)
        {
            float k = tree.Size;
            float crownY = tree.Y - 25 * k;

            using var brush = new SolidBrush(Color.Red);

            g.FillEllipse(brush,
                tree.X - 10 * k,
                crownY,
                6 * k,
                6 * k);

            g.FillEllipse(brush,
                tree.X + 4 * k,
                crownY - 6 * k,
                6 * k,
                6 * k);

            g.FillEllipse(brush,
                tree.X - 2 * k,
                crownY + 6 * k,
                6 * k,
                6 * k);
        }
    }
}