using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper
{
    public class UseCase : Obj
    {
        private static int useCaseCount = 0;

        public UseCase(float x, float y, float width, float height) : base(x, y, width, height)
        {
            Name = "Use Case " + useCaseCount;
            useCaseCount += 1;
        }

        public void Draw(Graphics graphics)
        {
            try
            {
                graphics.DrawEllipse(new Pen(Brushes.Black), new RectangleF(Location, Size));

                SizeF fontSize = graphics.MeasureString(Name, arialFont);
                PointF centerLocation = new PointF(Center.X - (fontSize.Width / 2.0f), Center.Y - (fontSize.Height / 2.0f));
                graphics.DrawString(Name, arialFont, Brushes.Black, centerLocation);
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }
    }
}
