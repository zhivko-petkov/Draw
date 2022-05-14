using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();
		private bool isInitialize = false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//

			InitializeComponent();
			StrokeColorBtn.PerformClick();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}

		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();
		}

		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (pickUpSpeedButton.Checked)
			{
				dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);
				if (dialogProcessor.Selection != null)
				{
					statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
					dialogProcessor.IsDragging = true;
					dialogProcessor.LastLocation = e.Location;
				}
			}

			if (MultipleSelector.Checked)
            {
				Shape temp = dialogProcessor.ContainsPoint(e.Location);
				if (temp != null)
				{
                    if (dialogProcessor.MultipleSelection.Contains(temp))
                    {
						dialogProcessor.MultipleSelection.Remove(temp);
                    } else
                    {
						dialogProcessor.MultipleSelection.Add(temp);
                    }

					if (dialogProcessor.MultipleSelection != null)
					{
						statusBar.Items[0].Text = "Последно действие: Селекция на множество примитиви";
						dialogProcessor.IsDragging = true;
						dialogProcessor.LastLocation = e.Location;
					}
				}
				
			}
			viewPort.Invalidate();

			//center Rectangle.X/2 => center => radius
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.PointerPosition.Text = "X: " + e.Location.X.ToString() + " Y: " + e.Location.Y.ToString();
			
				if (dialogProcessor.IsDragging)
				{
					if (dialogProcessor.Selection != null || dialogProcessor.MultipleSelection != null)
						statusBar.Items[0].Text = "Последно действие: Влачене";
                
				if (MultipleSelector.Checked)
                {
					dialogProcessor.TranslateMultipleSelectionTo(e.Location);
                }
                
				if (pickUpSpeedButton.Checked)
                {
					dialogProcessor.TranslateTo(e.Location);
                }	
					viewPort.Invalidate();
				}
				
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

		private void ellipseBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomOval();

			statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

			viewPort.Invalidate();
		}

        private void FillColorBtn_Click(object sender, EventArgs e)
        {
			fillColorDialog.ShowDialog();
			FillColorBtn.BackColor = fillColorDialog.Color;
			dialogProcessor.SetBackgroundColor(fillColorDialog.Color);
		}

        private void StrokeColorBtn_Click(object sender, EventArgs e)
        {
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = Color.Black;
			this.strokeColorDialog.Color = colorDialog.Color;
			if (isInitialize)
			{
				strokeColorDialog.ShowDialog();
			}
			StrokeColorBtn.BackColor = strokeColorDialog.Color;
			dialogProcessor.SetStrokeColor(strokeColorDialog.Color);
			isInitialize = true;
		}

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
			if (dialogProcessor.Selection != null)
				statusBar.Items[0].Text = "Последно действие: Увеличаване размера на фигурата";
			dialogProcessor.ResizeElementEnlarge();
			//dialogProcessor.TranslateTo(e.Location);
			viewPort.Invalidate();
		}

        private void reduceShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (dialogProcessor.Selection != null)
				statusBar.Items[0].Text = "Последно действие: Намаляване размера на фигурата";
			dialogProcessor.ResizeElementReduce();
			//dialogProcessor.TranslateTo(e.Location);
			viewPort.Invalidate();
		}

        private void triangleBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomTriangle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

			viewPort.Invalidate();
		}

        private void squareBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomSquare();

			statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";

			viewPort.Invalidate();
		}

        private void lineBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomLine();

			statusBar.Items[0].Text = "Последно действие: Рисуване на линия";

			viewPort.Invalidate();
		}

        private void PointerPosition_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.ShapeList.Clear();
			statusBar.Items[0].Text = "Последно действие: Почистване на работното поле";
			viewPort.Invalidate();
		}

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ShapesList Shapes = new ShapesList();
			foreach(Shape shape in dialogProcessor.ShapeList)
            {
				Shapes.Add(shape); 
            }

			Shapes.Save("C:\\Users\\Zhivko Petkov\\Documents\\fxgbxfvbxc\\shapes.bin");
			Shapes.Clear(); 
           
			

		}

        private void MultipleSelector_Click(object sender, EventArgs e)
        {

        }

        private void pickUpSpeedButton_Click(object sender, EventArgs e)
        {

        }

        private void groupBtn_Click(object sender, EventArgs e)
        {
            if (MultipleSelector.Checked)
            {
				statusBar.Items[0].Text = "Последно действие: Групиране на елементите";
				dialogProcessor.GroupShapes();
				viewPort.Invalidate();
			}

        }

        private void UngroupBtn_Click(object sender, EventArgs e)
        {
			statusBar.Items[0].Text = "Последно действие: Разгрупиране на елементите";
			dialogProcessor.UngroupShapes();
			viewPort.Invalidate();
        }
    }
}
