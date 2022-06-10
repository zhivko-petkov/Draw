using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Draw.src.Model;

namespace Draw
{
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		private static int numberOfPrimitives = 0; 
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
		/// 

		//Копирани елементи
		private List<Shape> copiedElements = new List<Shape>();
		public List<Shape> CopiedElements
        {
			get { return copiedElements; }
			set { copiedElements = value;  }
        }

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

		//Change color with bucket
		public void SetBackgroundSelection(Color color)
        {
			if(selection != null)
            {
				if (selection.GetType().Name.ToString().Equals("SubShapesClass"))
				{
					for (int i = 0; i < selection.GetShapes().Count; i++)
					{

						selection.GetShapes()[i].Name += "Recolor with " + color.Name;
						selection.GetShapes()[i].FillColor = color;

					}
				}
				else
				{
					this.selection.FillColor = color;
				}
				
            }
			
			if(this.multipleSelection.Count > 0)
            {
				multipleSelection.ForEach(a => {
					if (a.GetType().Name.ToString().Equals("SubShapesClass"))
					{
						for (int i = 0; i < a.GetShapes().Count; i++)
						{

							a.GetShapes()[i].Name += "Recolor with " + color.Name;
							a.GetShapes()[i].FillColor = color;

						}
					} else
                    {
						a.FillColor = color;
                    }
				});
			}
        }

		public void SetStrokeSelection(Color color)
        {
			if (selection != null)
			{
				if (selection.GetType().Name.ToString().Equals("SubShapesClass"))
				{
					for (int i = 0; i < selection.GetShapes().Count; i++)
					{

						selection.GetShapes()[i].Name += "Recolor with " + color.Name;
						selection.GetShapes()[i].StrokeColor = color;

					}
				}
				else
				{
					this.selection.StrokeColor = color;
				}

			}

			if (this.multipleSelection.Count > 0)
			{
				multipleSelection.ForEach(a => {
					if (a.GetType().Name.ToString().Equals("SubShapesClass"))
					{
						for (int i = 0; i < a.GetShapes().Count; i++)
						{

							a.GetShapes()[i].Name += "Recolor with " + color.Name;
							a.GetShapes()[i].StrokeColor = color;

						}
					}
					else
					{
						a.StrokeColor = color;
					}
				});
			}
		}

		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		//Rectangle
		public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));
			numberOfPrimitives++; 
			rect.Name = "Rectangle" + numberOfPrimitives; 
			rect.FillColor = FillColor;
			rect.StrokeColor = StrokeColor;

			ShapeList.Add(rect);
		}
		
		//Line
		public void AddRandomLine() {
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			Line line = new Line(new RectangleF(x, y, 100, 200));
			numberOfPrimitives++;
			line.Name = "Line" + numberOfPrimitives;
			line.StrokeColor = StrokeColor;

			ShapeList.Add(line);
		}
		
		//Oval
		public void AddRandomOval()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			OvalShape ellipse = new OvalShape(new Rectangle(x, y, 100, 200));
			numberOfPrimitives++;
			ellipse.Name = "Ellipse" + numberOfPrimitives;
			//ROTATE 45 DEGREES OUR SHAPE
			//ellipse.TransformationMatrix.RotateAt(45, new PointF(ellipse.Rectangle.X + ellipse.Rectangle.Width / 2, ellipse.Rectangle.X + ellipse.Rectangle.Height / 2));

			ellipse.FillColor = FillColor;
			ellipse.StrokeColor = StrokeColor;
			ShapeList.Add(ellipse);
		}

		//Square
		public void AddRandomSquare()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			SquareShape square = new SquareShape(new Rectangle(x, y, 100, 100));
			square.FillColor = FillColor;
			square.StrokeColor = StrokeColor;
			numberOfPrimitives++;
			square.Name = "Square" + numberOfPrimitives;

			ShapeList.Add(square);

		}
		//Oval
		public void AddRandomTriangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			TriangleShape triangle = new TriangleShape(new RectangleF(x, y, 200, 100));

			triangle.FillColor = FillColor;
			triangle.StrokeColor = StrokeColor;
			numberOfPrimitives++;
			triangle.Name = "Triangle" + numberOfPrimitives;
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
					//ShapeList[i].FillColor = Color.Lavender;
					return ShapeList[i];
				} 
			}
			return null;
		}

		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF enterPoint)
		{
			if (selection != null)
			{
                if (selection.GetType().Name.ToString().Equals("SubShapesClass"))
                {
					selection.TranslateSubShapes(enterPoint.X - lastLocation.X, enterPoint.Y - lastLocation.Y);
				} else
                {
					selection.Location = new PointF(selection.Location.X + enterPoint.X - lastLocation.X, selection.Location.Y + enterPoint.Y - lastLocation.Y);
                }
				
				lastLocation = enterPoint;
			}
			
            
		}

		public void TranslateMultipleSelectionTo(PointF p)
        {
			if (multipleSelection != null)
			{
				foreach (Shape currentSelection in multipleSelection)
				{
                    if (currentSelection.GetType().Name.ToString().Equals("SubShapesClass")){
						currentSelection.TranslateSubShapes(p.X - lastLocation.X, p.Y - lastLocation.Y);
					} 
					else
                    {
						currentSelection.Location = new PointF(currentSelection.Location.X + p.X - lastLocation.X, currentSelection.Location.Y + p.Y - lastLocation.Y);
                    }
					
				}
			}

			lastLocation = p;
		}

		public void ResizeElementEnlarge(float size)
		{
			if(selection != null)
            {
				if(selection.GetType().Name.ToString().Equals("SubShapesClass"))
                {
					for(int i = 0; i < selection.GetShapes().Count; i++)
                    {
						selection.GetShapes()[i].Height += size;
						selection.GetShapes()[i].Width += size;
						selection.GetShapes()[i].Name += "Resized with " + size;
						selection.Width += size / 2;
						selection.Height += size / 2;
					}
                } else
                {
					selection.Height += size;
					selection.Width += size;
					selection.Name += "Resized with " + size;
                }
				
            }
			

			if(multipleSelection != null)
            {
				foreach (Shape currentSelection in multipleSelection)
				{
					if (currentSelection.GetType().Name.ToString().Equals("SubShapesClass"))
					{
						for (int i = 0; i < currentSelection.GetShapes().Count; i++)
						{
							currentSelection.GetShapes()[i].Height += size;
							currentSelection.GetShapes()[i].Width += size;
							currentSelection.GetShapes()[i].Name += "Resized with " + size; 
							currentSelection.Width += size/2;
							currentSelection.Height += size/2;
						}
					}
					else
					{
						currentSelection.Height += size;
						currentSelection.Width += size;
						currentSelection.Name += "Resized with " + size;
					}
				}

			}

		}

		public void ResizeElementReduce(float size)
		{
			string message = "Въведете по-ниски стойности за намаляване размера на примитива";
			if (selection != null)
			{
				if (selection.GetType().Name == "SubShapesClass")
				{
					for (int i = 0; i < selection.GetShapes().Count; i++)
					{
						
						if (selection.GetShapes()[i].Height - size > 0 && selection.GetShapes()[i].Width - size > 0)
						{
							selection.GetShapes()[i].Height -= size;
							selection.GetShapes()[i].Width -= size;
							selection.Width -= size / 2;
							selection.Height -= size / 2;
						}
						else
						{
							MessageBox.Show(message, "Намаляване на примитива");
						}
					}
				}
				else
				{
					if (selection.Height - size > 0 && selection.Width - size > 0)
					{
						selection.Height -= size;
						selection.Width -= size;
					}
					else
					{
						MessageBox.Show(message, "Намаляване на примитива");
					}
				}
				
				
			}


			if (multipleSelection != null)
			{
				foreach (Shape currentSelection in multipleSelection)
				{
					if (currentSelection.GetType().Name.ToString().Equals("SubShapesClass"))
					{
						for (int i = 0; i < currentSelection.GetShapes().Count; i++)
						{

							if (currentSelection.GetShapes()[i].Height - size > 0 && currentSelection.GetShapes()[i].Width - size > 0)
							{
								currentSelection.GetShapes()[i].Height -= size;
								currentSelection.GetShapes()[i].Width -= size;
								currentSelection.Width -= size / 2;
								currentSelection.Height -= size / 2;
							}
							else
							{
								MessageBox.Show(message, "Намаляване на примитива");
							}
						}
					}
					else
					{
						if (currentSelection.Height - size > 0 && currentSelection.Width - size > 0)
						{
							currentSelection.Height -= size;
							currentSelection.Width -= size;
						}
						else
						{
							MessageBox.Show(message, "Намаляване на примитива");
						}
					}
				}
			}


			//selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);
			//lastLocation = p;
		}

		public void CustomRotationElement(int rotation)
        {

			if (selection != null)
			{
				if (selection.GetType().Name.ToString().Equals("SubShapesClass"))
				{
					for (int i = 0; i < selection.GetShapes().Count; i++)
					{
						selection.GetShapes()[i].SubCurrentAngle = rotation;

					}
				}
				else
				{
					selection.SubCurrentAngle = rotation;
				}
				

			}


			if (multipleSelection != null)
			{
				foreach (Shape currentSelection in multipleSelection)
				{
					if (currentSelection.GetType().Name.ToString().Equals("SubShapesClass"))
					{
						for (int i = 0; i < currentSelection.GetShapes().Count; i++)
						{
							currentSelection.GetShapes()[i].SubCurrentAngle = rotation;
						}
					}
					else
					{
						currentSelection.SubCurrentAngle = rotation;
					}
				}

			}
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
	
		public void GroupShapes()
        {
			if(multipleSelection.Count > 0)
            {
				var minX = float.PositiveInfinity;
				var maxX = float.NegativeInfinity;
				var minY = float.PositiveInfinity;
				var maxY = float.NegativeInfinity;

				foreach(Shape currentShape in multipleSelection){
					if(minX > currentShape.Location.X)
					{
						minX = currentShape.Location.X;
					}
					if(minY > currentShape.Location.Y)
					{
						minY = currentShape.Location.Y; 
					}
					if(maxX < currentShape.Location.X + currentShape.Width)
					{
						maxX = currentShape.Location.X + currentShape.Width;
					}
					if (maxY < currentShape.Location.Y + currentShape.Height)
					{
						maxY = currentShape.Location.Y + currentShape.Height;
					}
				}

				//list with shapes
				SubShapesClass selectedShapes = new SubShapesClass(new RectangleF(minX, minY, maxX-minX, maxY-minY));

				List<Shape> cShape = new List<Shape>(); 
				foreach(Shape shape in multipleSelection)
				{
					cShape.Add(shape);
				}

				foreach(Shape shape in cShape)
				{
				
					selectedShapes.subShapes.Add(shape);
					multipleSelection.Remove(shape);
					ShapeList.Remove(shape);
				
				}
				selectedShapes.Name = "Group" + numberOfPrimitives; 
				ShapeList.Add(selectedShapes);
				multipleSelection.Add(selectedShapes);
				selectedShapes.subShapes.ForEach(a => a.FillColor = FillColor);
				selectedShapes.subShapes.ForEach(a => a.StrokeColor = StrokeColor); 
            } else
            {
				MessageBox.Show("Моля направете множествена селекция на примитиви, за да ги групирате!", "Групиране на примитиви");
			}
			
			
		}
		
		public void UngroupShapes()
        {
			if(selection != null) {
				if (selection.GetType().Name.ToString().Equals("SubShapesClass"))
				{
					foreach(Shape currentShape in selection.GetShapes())
					{
						ShapeList.Add(currentShape);
					}
					numberOfPrimitives--;
					ShapeList.Remove(selection);
				} else
				{
					MessageBox.Show("Моля направете селекция на група, а не на единичен елемент!", "Разгрупиране на примитиви");
				}
			} else
            {
				MessageBox.Show("Моля направете селекция на група!", "Разгрупиране на примитиви");
			}
           
			
        }

		public void OpacityShape(int opacity)
        {
			if(selection != null && multipleSelection.Count == 0)
            {
				selection.FillColor = Color.FromArgb((int)(255-opacity*2.55), selection.FillColor);
                if (selection.GetType().Name.ToString().Equals("SubShapesClass"))
                {
					foreach (Shape shape in selection.GetShapes())
					{
						shape.FillColor = Color.FromArgb(opacity, shape.FillColor);
					}
				}

            } else if(multipleSelection.Count > 0 && selection == null)
            {
				foreach(Shape currentShape in multipleSelection)
                {
					currentShape.FillColor = Color.FromArgb(opacity, currentShape.FillColor);
					if (currentShape.GetType().Name.ToString().Equals("SubShapesClass"))
					{
						foreach(Shape shape in currentShape.GetShapes())
                        {
							shape.FillColor = Color.FromArgb(opacity, currentShape.FillColor);
						}
					}
				}
				
            } else
            {
				MessageBox.Show("Няма селектирани примитиви на които да приложите прозрачност", "Прозрачност на примитиви");
            }
			
        }

		public void RemoveShape()
		{
			bool isRemoveEl = false;
			if (selection != null)
			{
				ShapeList.Remove(selection);
				isRemoveEl = true;
			}
			if (multipleSelection != null)
            {
				foreach(Shape currentShape in multipleSelection)
                {
					ShapeList.Remove(currentShape); 
                }
				MultipleSelection.Clear();
				isRemoveEl = true;
            }
            if (!isRemoveEl)
            {
				MessageBox.Show("Няма селектирани елементи за изтриване", "Премахване на елемент");
            }
			
		}

		private bool lastCopiedIsMultiple = false; 
		public void CopyShapes()
        {
			if(multipleSelection.Count > 0)
            {
				for(int i = 0; i < multipleSelection.Count; i++)
                {
					 copiedElements.Add(multipleSelection[i]);
                }
				lastCopiedIsMultiple = true; 
            } else
            {
				copiedElements.Add(selection);
				lastCopiedIsMultiple = false; 
            }
        }

		public void PasteShape()
        {
			if(copiedElements.Count > 0)
            {
                if (lastCopiedIsMultiple)
                {
					
					foreach(Shape shape in copiedElements)
                    {
						/*Shape currentShape = new Shape();
						currentShape.Name = shape.Name;
						currentShape.Height = shape.Height;
						currentShape.Location = shape.Location; 
						
						currentShape.StrokeColor = shape.StrokeColor; */

						if (shape.GetType().Name.ToString().Equals("Line"))
                        {
							PointF current = shape.Location;
							current.X += 25;
							current.Y += 25;
							Shape currentShape = new Line(shape.Rectangle);
							currentShape.Height = shape.Height;
							currentShape.Width = shape.Width;
							currentShape.Location = current;
							currentShape.Name = shape.Name + " - Copied";
							currentShape.StrokeColor = shape.StrokeColor;
							currentShape.FillColor = shape.FillColor;	
							numberOfPrimitives++;
							ShapeList.Add(currentShape);

                        } else if (shape.GetType().Name.ToString().Equals("OvalShape"))
                        {
							PointF current = shape.Location;
							current.X += 25;
							current.Y += 25;
							Shape currentShape = new OvalShape(shape.Rectangle);
							currentShape.Height = shape.Height;
							currentShape.Width = shape.Width;
							currentShape.Location = current;
							currentShape.Name = shape.Name + " - Copied";
							currentShape.StrokeColor = shape.StrokeColor;
							currentShape.FillColor = shape.FillColor;
							numberOfPrimitives++;
							ShapeList.Add(currentShape);

						}  else if (shape.GetType().Name.ToString().Equals("RectangleShape"))
                        {
							PointF current = shape.Location;
							current.X += 25;
							current.Y += 25;
							Shape currentShape = new RectangleShape(shape.Rectangle);
							currentShape.Height = shape.Height;
							currentShape.Width = shape.Width;
							currentShape.Location = current;
							currentShape.Name = shape.Name + " - Copied";
							currentShape.StrokeColor = shape.StrokeColor;
							currentShape.FillColor = shape.FillColor;
							numberOfPrimitives++;
							ShapeList.Add(currentShape);

						} else if (shape.GetType().Name.ToString().Equals("SquareShape"))
                        {
							PointF current = shape.Location;
							current.X += 25;
							current.Y += 25;
							Shape currentShape = new SquareShape(shape.Rectangle);
							currentShape.Height = shape.Height;
							currentShape.Width = shape.Width;
							currentShape.Location = current;
							currentShape.Name = shape.Name + " - Copied";
							currentShape.StrokeColor = shape.StrokeColor;
							currentShape.FillColor = shape.FillColor;
							numberOfPrimitives++;
							ShapeList.Add(currentShape);

						} else if (shape.GetType().Name.ToString().Equals("SubShapesClass"))
                        {
							PointF current = shape.Location;
							current.X += 25;
							current.Y += 25;
							Shape currentShape = new SubShapesClass(shape.Rectangle);
							currentShape.Height = shape.Height;
							currentShape.Width = shape.Width;
							currentShape.Location = current;
                            currentShape.Name = shape.Name + " - Copied";
							foreach(Shape sh in shape.GetShapes())
                            {
								Shape copy = (Shape)sh.Clone(); 
								currentShape.SetShape(copy);
                            }
							
							currentShape.StrokeColor = shape.StrokeColor;
							currentShape.FillColor = shape.FillColor;
							numberOfPrimitives++;
							ShapeList.Add(currentShape);
						} else if (shape.GetType().Name.ToString().Equals("TriangleShape"))
                        {
							PointF current = shape.Location;
							current.X += 25;
							current.Y += 25;
							Shape currentShape = new TriangleShape(shape.Rectangle);
							currentShape.Height = shape.Height;
							currentShape.Width = shape.Width;
							currentShape.Location = current;
							currentShape.Name = shape.Name + " - Copied";
							currentShape.StrokeColor = shape.StrokeColor;
							currentShape.FillColor = shape.FillColor;
							numberOfPrimitives++;
							ShapeList.Add(currentShape);

						}

						/*shape.Location = current;
						shape.Name += " - Copied";*/

					}
                }
				else
				{
					Shape shape = copiedElements[(copiedElements.Count-1)]; 
					if (shape.GetType().Name.ToString().Equals("Line"))
					{
						PointF current = shape.Location;
						current.X += 25;
						current.Y += 25;
						Shape currentShape = new Line(shape.Rectangle);
						currentShape.Height = shape.Height;
						currentShape.Width = shape.Width;
						currentShape.Location = current;
						currentShape.Name = shape.Name + " - Copied";
						currentShape.StrokeColor = shape.StrokeColor;
						currentShape.FillColor = shape.FillColor;
						numberOfPrimitives++;
						ShapeList.Add(currentShape);

					}
					else if (shape.GetType().Name.ToString().Equals("OvalShape"))
					{
						PointF current = shape.Location;
						Shape currentShape = new OvalShape(shape.Rectangle);
						currentShape.Height = shape.Height;
						currentShape.Width = shape.Width;
						currentShape.Location = current;
						currentShape.Name = shape.Name + " - Copied";
						currentShape.StrokeColor = shape.StrokeColor;
						currentShape.FillColor = shape.FillColor;
						numberOfPrimitives++;
						ShapeList.Add(currentShape);

					}
					else if (shape.GetType().Name.ToString().Equals("RectangleShape"))
					{
						PointF current = shape.Location;
						current.X += 25;
						current.Y += 25;
						Shape currentShape = new RectangleShape(shape.Rectangle);
						currentShape.Height = shape.Height;
						currentShape.Width = shape.Width;
						currentShape.Location = current;
						currentShape.Name = shape.Name + " - Copied";
						currentShape.StrokeColor = shape.StrokeColor;
						currentShape.FillColor = shape.FillColor;
						numberOfPrimitives++;
						ShapeList.Add(currentShape);

					}
					else if (shape.GetType().Name.ToString().Equals("SquareShape"))
					{
						PointF current = shape.Location;
						current.X += 25;
						current.Y += 25;
						Shape currentShape = new SquareShape(shape.Rectangle);
						currentShape.Height = shape.Height;
						currentShape.Width = shape.Width;
						currentShape.Location = current;
						currentShape.Name = shape.Name + " - Copied";
						currentShape.StrokeColor = shape.StrokeColor;
						currentShape.FillColor = shape.FillColor;
						numberOfPrimitives++;
						ShapeList.Add(currentShape);

					}
					else if (shape.GetType().Name.ToString().Equals("SubShapesClass"))
					{
						PointF current = shape.Location;
						Shape currentShape = new SubShapesClass(shape.Rectangle);
						currentShape.Height = shape.Height;
						currentShape.Width = shape.Width;
						currentShape.Location = current;
						currentShape.Name = shape.Name + " - Copied";
						foreach (Shape sh in shape.GetShapes())
						{
							Shape copy = (Shape)sh.Clone();
							currentShape.SetShape(copy);
						}

						currentShape.StrokeColor = shape.StrokeColor;
						currentShape.FillColor = shape.FillColor;
						numberOfPrimitives++;
						ShapeList.Add(currentShape);
					}
					else if (shape.GetType().Name.ToString().Equals("TriangleShape"))
					{
						PointF current = shape.Location;
						current.X += 25;
						current.Y += 25;
						Shape currentShape = new TriangleShape(shape.Rectangle);
						currentShape.Height = shape.Height;
						currentShape.Width = shape.Width;
						currentShape.Location = current;
						currentShape.Name = shape.Name + " - Copied";
						currentShape.StrokeColor = shape.StrokeColor;
						currentShape.FillColor = shape.FillColor;
						numberOfPrimitives++;
						ShapeList.Add(currentShape);

					}
				}
			} 
        }
	}
}
