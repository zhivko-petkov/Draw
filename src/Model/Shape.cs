﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Базовия клас на примитивите, който съдържа общите характеристики на примитивите. ФИГУРИ
	/// </summary>
	
	[Serializable]
	public abstract class Shape 
	{
		#region Constructors
		public Shape()
		{
		}

		public Shape(RectangleF rect)
		{
			rectangle = rect;
		}

		public Shape(Shape shape)
		{
			this.Height = shape.Height;
			this.Width = shape.Width;
			this.Location = shape.Location;
			this.rectangle = shape.rectangle;

			this.FillColor = shape.FillColor;
		}
		#endregion

		#region PropertiesRectangle

		
		/// <summary>
		/// Обхващащ правоъгълник на елемента.
		/// </summary>
		private RectangleF rectangle;
		public virtual RectangleF Rectangle
		{
			get { return rectangle; }
			set { rectangle = value; }
		}


		/// <summary>
		/// Широчина на елемента.
		/// </summary>
		public virtual float Width
		{
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}

		/// <summary>
		/// Височина на елемента.
		/// </summary>
		public virtual float Height
		{
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}

		/// <summary>
		/// Горен ляв ъгъл на елемента.
		/// </summary>
		public virtual PointF Location
		{
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}


		/// <summary>
		/// Цвят на елемента.
		/// </summary>
		private Color fillColor;
		public virtual Color FillColor
		{
			get { return fillColor; }
			set { fillColor = value; }
		}

		//Цвят на контура
		private Color strokeColor;

		public virtual Color StrokeColor
		{
			get { return strokeColor; }
			set { strokeColor = value; }
		}

		#endregion

		//Име на примитив
		private string name;
		public virtual string Name { get; set; }

		private int subCurrentAngle;
		public virtual int SubCurrentAngle { get { return subCurrentAngle; } set { subCurrentAngle = value; } }
		
		/*
		private Matrix transformationMatrix = new Matrix();*/

        internal IEnumerable<Shape> subShapes;

		/*
        public virtual Matrix TransformationMatrix
        {
			get { return transformationMatrix; }
			set { transformationMatrix = value; }
        }*/

		
		/// <summary>
		/// Проверка дали точка point принадлежи на елемента.
		/// </summary>
		/// <param name="point">Точка</param>
		/// <returns>Връща true, ако точката принадлежи на елемента и
		/// false, ако не пренадлежи</returns>
		public virtual bool Contains(PointF point)
		{
			return Rectangle.Contains(point.X, point.Y);
		}

		/// <summary>
		/// Визуализира елемента.
		/// </summary>
		/// <param name="grfx">Къде да бъде визуализиран елемента.</param>
		public virtual void DrawSelf(Graphics grfx)
		{
			//shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
		}

        public virtual void TranslateSubShapes(float xC, float yC)
        {
			Location = new PointF( xC + Location.X, yC + Location.Y);
		}

		//За да можем да деселектираме фигурите
		//override в SubShapes
        public virtual List<Shape> GetShapes()
        {
            throw new NotImplementedException();
        }

        public virtual void SetShape(Shape shape)
        {
            throw new NotImplementedException();
        }

		public virtual void CustomShapeRotator(Graphics graphics)
        {
			graphics.TranslateTransform(((Rectangle.Width / 2) + Rectangle.X), ((Rectangle.Height / 2) + Rectangle.Y));
			graphics.RotateTransform(subCurrentAngle);
			graphics.TranslateTransform(-((Rectangle.Width / 2) + Rectangle.X), -((Rectangle.Height / 2) + Rectangle.Y));
		}

        public virtual object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
