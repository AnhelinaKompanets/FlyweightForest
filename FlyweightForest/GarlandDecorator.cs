using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightForest
{
    public class GarlandDecorator : ITreeDecorator
    {
        public void Draw(Graphics g, Tree tree)
        {
            float k = 1f + tree.Age * 0.01f;

            float w = 30 * tree.Size * k;
            float h = 22 * tree.Size * k;

            float x = tree.X - w / 2;
            float y = tree.Y - (35 * tree.Size * k);

            using var pen = new Pen(Color.Gold, 2);
            g.DrawArc(pen, x, y, w, h, 0, 180);
        }
    }
}