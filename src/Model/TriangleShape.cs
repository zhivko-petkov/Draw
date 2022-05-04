using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Draw.src.Model
{
	[Serializable]
	class TriangleShape : Shape
	{
		public TriangleShape(RectangleF polygon) : base(polygon)
		{

		}

		public TriangleShape(TriangleShape triangle) : base(triangle)
		{

		}
		public Point[] points;
		//TO DO: 
		public override bool Contains(PointF point)
		{
			//points[0].X <= point.X && points[1].X >= point.X && points[0].Y >= point.Y
			if (base.Contains(point))
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>

		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);
			Point[] currentPoints = { new Point((int)(Rectangle.Width+(int)Location.X), ((int)Location.Y)), new Point((int)(Location.X), (int)Location.Y), new Point((int)(Location.X), (int)Rectangle.Height+(int)(Location.Y)) };
			this.points = currentPoints;
			//Point[] points = { new Point((int)Location.X, ((int)Location.Y)), new Point((int)(Location.X), (int)Location.Y), new Point((int)(Location.X), (int)(Location.Y)) };
			//Point[] points = { new Point((int)Location.X, (100 + (int)Location.Y)), new Point(0, 0), new Point((int)(0), (int)(0)) };
			Pen pen = new Pen(new SolidBrush(StrokeColor));
			grfx.FillPolygon(new SolidBrush(FillColor), points);
			grfx.DrawPolygon(pen, points);

		}


	}
}
