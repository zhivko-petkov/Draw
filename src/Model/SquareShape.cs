using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    [Serializable]
    class SquareShape : Shape, ICloneable
    {
        public SquareShape(RectangleF square) : base(square)
        {

        }

        public SquareShape(SquareShape square) : base(square)
        {

        }

        public override bool Contains(PointF pointC)
        {
            if (base.Contains(pointC))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        public override void DrawSelf(Graphics graphicsC)
        {
            base.DrawSelf(graphicsC);
            base.CustomShapeRotator(graphicsC);
            //Color customColor = Color.FromArgb(50, Color.White);
            Pen penCurrent = new Pen(new SolidBrush(StrokeColor));
            graphicsC.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            graphicsC.DrawRectangle(penCurrent, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            graphicsC.ResetTransform();
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }


    }
}
