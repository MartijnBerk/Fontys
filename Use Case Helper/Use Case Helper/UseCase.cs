using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper
{
    public class UseCase
    {
        public bool Destroy { get; private set; }

        public PointF Center
        {
            get
            {
                return new PointF(location.X + (size.Width / 2.0f), location.Y + (size.Height / 2.0f));
            }
        }
        public RectangleF HitBox
        {
            get
            {
                return new RectangleF(location, size);
            }
        }
        public string Name { get; set; }

        private PointF location;
        private SizeF size;

        private PointF spawnLocation;

        private static Font arialFont = new Font("Arial", 11);
        
        public UseCase(float x, float y, float width, float height)
        {
            Name = "Use Case";
            Destroy = false;

            location = new PointF(x, y);
            spawnLocation = location;

            size = new SizeF(width, height);
        }

        public void Draw(Graphics graphics)
        {
            try
            {
                graphics.DrawEllipse(new Pen(Brushes.Black), new RectangleF(location, size));

                SizeF fontSize = graphics.MeasureString(Name, arialFont);
                PointF centerLocation = new PointF(Center.X - (fontSize.Width / 2.0f), Center.Y - (fontSize.Height / 2.0f));
                graphics.DrawString(Name, arialFont, Brushes.Black, centerLocation);
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        public void SetSize(float otherX, float otherY)
        {
            size.Width = otherX - spawnLocation.X;
            size.Height = otherY - spawnLocation.Y;
        }

        public void DestroyUseCase()
        {
            Destroy = true;
        }
    }
}
