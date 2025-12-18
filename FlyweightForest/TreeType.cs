using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightForest
{
    public sealed class TreeType
    {
        public string Name { get; }
        public Color CrownColor { get; }
        public Color TrunkColor { get; }

        public TreeType(string name, Color crown, Color trunk)
        {
            Name = name;
            CrownColor = crown;
            TrunkColor = trunk;
        }

        public void Draw(Graphics g, int x, int y, float size, int age)
        {
            float k = 1f + age * 0.01f;

            float trunkW = 6 * size;
            float trunkH = 18 * size * k;

            float crownW = 26 * size * k;
            float crownH = 22 * size * k;

            using var trunk = new SolidBrush(TrunkColor);
            g.FillRectangle(trunk, x - trunkW / 2, y - trunkH, trunkW, trunkH);

            using var crown = new SolidBrush(CrownColor);

            if (Name == "Сосна" || Name == "Ялина")
            {
                PointF[] p =
                {
                    new(x, y - trunkH - crownH),
                    new(x - crownW / 2, y - trunkH),
                    new(x + crownW / 2, y - trunkH)
                };
                g.FillPolygon(crown, p);
            }
            else
            {
                g.FillEllipse(
                    crown,
                    x - crownW / 2,
                    y - trunkH - crownH / 2,
                    crownW,
                    crownH
                );
            }
        }
    }
}