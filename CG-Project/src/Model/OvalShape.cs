using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// <summary>
	/// Description of OvalShape.
	/// </summary>

	[Serializable]
	public class OvalShape : Shape, ICloneable
	{
		#region Constructor

		public OvalShape(RectangleF oval) : base(oval)
		{
		}

		public OvalShape(OvalShape oval) : base(oval)
		{
		}

		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		public override bool Contains(PointF pointCurr)
		{
			float px = pointCurr.X;
			float x = (Rectangle.X + Rectangle.Width / 2);
			float rx = Rectangle.Width / 2;

			float py = pointCurr.Y;
			float y = (Rectangle.Y + Rectangle.Height / 2);
			float ry = Rectangle.Height / 2;

			float X = px;
			float h = x;
			float a = rx; //радиус по посоката на Х (абцисна ос)

			float Y = py;
			float k = y;
			float b = ry; //радиус по посоката на У (ординатна ос)


			if (((Math.Pow(px - x, 2) / Math.Pow(rx, 2)) + (Math.Pow(py - y, 2) / Math.Pow(ry, 2))) <= 1)
				return true;
			else
				return false;
		}

		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics graphicsC)
		{

			Pen penCurrent = new Pen(new SolidBrush(StrokeColor));
			graphicsC.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			graphicsC.DrawEllipse(penCurrent, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			base.DrawSelf(graphicsC);
			base.CustomShapeRotator(graphicsC);

		}


		public override object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}
