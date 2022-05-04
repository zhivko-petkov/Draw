using System;
using System.Collections.Generic;
using System.Drawing;
using Draw.src.Model;

namespace Draw
{
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor

		public DialogProcessor()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Избран елемент.
		/// </summary>
		private Shape selection;
		public Shape Selection
		{
			get { return selection; }
			set { selection = value; }
		}

		/// Избрани елементи

		private List<Shape> multipleSelection = new List<Shape>();
		public List<Shape> MultipleSelection
		{
			get { return multipleSelection; }
			set { multipleSelection = value; }
		}

		/// <summary>
		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		/// </summary>
		private bool isDragging;
		public bool IsDragging
		{
			get { return isDragging; }
			set { isDragging = value; }
		}

		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation
		{
			get { return lastLocation; }
			set { lastLocation = value; }
		}

		#endregion
		//fill color
		private Color FillColor;
		public void SetBackgroundColor(Color color)
		{
			this.FillColor = color;
		}

		private Color StrokeColor;
		public void SetStrokeColor(Color color)
		{
			this.StrokeColor = color;
		}

		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));
			rect.FillColor = FillColor;
			rect.StrokeColor = StrokeColor;

			ShapeList.Add(rect);
		}

		public void AddRandomLine() {
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			Line line = new Line(new RectangleF(x, y, 100, 200));

			line.StrokeColor = StrokeColor;

			ShapeList.Add(line);
		}


		public void AddRandomOval()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			OvalShape ellipse = new OvalShape(new Rectangle(x, y, 100, 200));

			//ROTATE 45 DEGREES OUR SHAPE
			//ellipse.TransformationMatrix.RotateAt(45, new PointF(ellipse.Rectangle.X + ellipse.Rectangle.Width / 2, ellipse.Rectangle.X + ellipse.Rectangle.Height / 2));
            
			ellipse.FillColor = FillColor;
			ellipse.StrokeColor = StrokeColor;
			ShapeList.Add(ellipse);
		}

		public void AddRandomSquare()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			SquareShape square = new SquareShape(new Rectangle(x, y, 100, 100));
			square.FillColor = FillColor;
			square.StrokeColor = StrokeColor;


			ShapeList.Add(square);

		}


		public void AddRandomTriangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			TriangleShape triangle = new TriangleShape(new RectangleF(x, y, 200, 100));

			triangle.FillColor = FillColor;
			triangle.StrokeColor = StrokeColor;

			ShapeList.Add(triangle);
		}


		/// <summary>
		/// Проверява дали дадена точка е в елемента.
		/// Обхожда в ред обратен на визуализацията с цел намиране на
		/// "най-горния" елемент т.е. този който виждаме под мишката.
		/// </summary>
		/// <param name="point">Указана точка</param>
		/// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
		public Shape ContainsPoint(PointF point)
		{
			
			for (int i = ShapeList.Count - 1; i >= 0; i--)
			{
				if (ShapeList[i].Contains(point))
				{
					ShapeList[i].FillColor = Color.Lavender;
					return ShapeList[i];
				} 
			}
			return null;
		}

		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{
			if (selection != null)
			{
				selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);
				lastLocation = p;
			}
			
            
		}

		public void TranslateMultipleSelectionTo(PointF p)
        {
			if (multipleSelection != null)
			{
				foreach (Shape currentSelection in multipleSelection)
				{
					currentSelection.Location = new PointF(currentSelection.Location.X + p.X - lastLocation.X, currentSelection.Location.Y + p.Y - lastLocation.Y);
				}
			}

			lastLocation = p;
		}

		public void ResizeElementEnlarge()
		{
			if(selection != null)
            {
				selection.Height += 5;
				selection.Width += 5;
            }
			

			if(multipleSelection != null)
            {
				foreach (Shape currentSelection in multipleSelection)
				{
					currentSelection.Height += 5;
					currentSelection.Width += 5;
				}
			}
			//selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);
			//lastLocation = p;
		}

		public void ResizeElementReduce()
		{
			if (selection != null)
			{
				selection.Height += 5;
				selection.Width += 5;
			}


			if (multipleSelection != null)
			{
				foreach (Shape currentSelection in multipleSelection)
				{
					currentSelection.Height -= 5;
					currentSelection.Width -= 5;
				}
			}


			//selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);
			//lastLocation = p;
		}

		public override void DrawShape(Graphics grfx, Shape item)
		{
			base.DrawShape(grfx, item);
			if (multipleSelection.Contains(item))
			{
				Pen currentPen = new Pen(Color.Green);
				currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
				grfx.DrawRectangle(currentPen, item.Location.X - 3, item.Location.Y - 3, item.Width + 6, item.Height + 6);
			}

		}
	}
}
