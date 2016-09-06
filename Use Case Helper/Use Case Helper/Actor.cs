using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper
{
    class Actor : Obj
    {
        private static Image actorImage = Properties.Resources.Robustness_Diagram_Actor_svg;

        private static int actorCount = 0;

        public Actor(float x, float y, float width, float height) : base(x, y, width, height)
        {
            Name = "Actor " + actorCount.ToString();
            actorCount += 1;
        }

        public void Draw(Graphics graphics)
        {
            try
            {
                graphics.DrawImage(actorImage, new RectangleF(Location, Size));
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }
    }
}
