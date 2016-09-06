using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper
{
    public class Obj
    {
        public bool Destroy { get; private set; }

        public PointF Center
        {
            get
            {
                return new PointF(location.X + (size.Width / 2.0f), location.Y + (size.Height / 2.0f));
            }
        }
        public PointF Location
        {
            get
            {
                return location;
            }
        }
        public SizeF Size
        {
            get
            {
                return size;
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

        public static Font arialFont = new Font("Arial", 11);

        public Obj(float x, float y, float width, float height)
        {
            Destroy = false;

            location = new PointF(x, y);
            spawnLocation = location;

            size = new SizeF(width, height);
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
