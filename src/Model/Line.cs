using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
	[Serializable]
	class Line : Shape, ICloneable
	{
		public Line(RectangleF polygon) : base(polygon)
		{

		}

		public Line(Line line) : base(line)
		{

		}
		public Point[] points;
		//TO DO: 
		public override bool Contains(PointF pointCurr)
		{
			if (base.Contains(pointCurr))
				return true;
			else
				return false;

		}

		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>

		public override void DrawSelf(Graphics graphicsC)
		{
			base.DrawSelf(graphicsC);
			base.CustomShapeRotator(graphicsC);
			Point[] currentPoints = { new Point((int)(Rectangle.Width + (int)Location.X), ((int)Rectangle.Height + (int)Location.Y)), new Point((int)(Location.X), (int)(Location.Y)) };
			this.points = currentPoints;
			Pen penCurr = new Pen(new SolidBrush(StrokeColor));

			graphicsC.DrawPolygon(penCurr, points);

		}



		public override object Clone()
        {
			return this.MemberwiseClone();
		}
    }
}
