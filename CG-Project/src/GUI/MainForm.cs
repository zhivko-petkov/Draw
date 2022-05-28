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

		//Прихващане на преместването на мишката.
		// Ако сме в режм на "влачене", то избрания елемент се транслира.
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.PointerPosition.Text = "X: " + e.Location.X.ToString() + " Y: " + e.Location.Y.ToString();
			

			
				if (dialogProcessor.IsDragging)
				{
					if (dialogProcessor.Selection != null || dialogProcessor.MultipleSelection != null)
						statusBar.Items[0].Text = "Последно действие: Влачене";
						
                
				if (MultipleSelector.Checked)
                {
					this.NameOfCurrentSelection.Text = "Multiple selection";
					dialogProcessor.TranslateMultipleSelectionTo(e.Location);
                }
                
				if (pickUpSpeedButton.Checked)
                {
					this.NameOfCurrentSelection.Text = dialogProcessor.Selection.Name;
					dialogProcessor.TranslateTo(e.Location);
                }	
					viewPort.Invalidate();
				}
				
		}

		//Прихващане на отпускането на бутона на мишката.
		// Излизаме от режим "влачене".
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

		//Ellipse
		private void ellipseBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomOval();

			statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

			viewPort.Invalidate();
		}
		//Fill collor primitive
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
		//Resize enlarge
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (dialogProcessor.Selection != null)
				statusBar.Items[0].Text = "Последно действие: Увеличаване размера на фигурата";
			string message = "Въведете коректни стойности за преоразмеряване на примитива.";
			bool errorMessage = false;
			if (toolStripTextBox1.Text != "")
			{
				Console.WriteLine(toolStripTextBox1.Text);
				if (float.Parse(toolStripTextBox1.Text) > 0.01)
				{
					dialogProcessor.ResizeElementEnlarge(float.Parse(toolStripTextBox1.Text));
				} else
				{
					errorMessage = true;
				}

			}
			else
			{
				errorMessage = true;
			}
			if (errorMessage)
            {
				MessageBox.Show(message, "Увеличаване на примитива");
				toolStripTextBox1.Clear();

			}
			toolStripTextBox1.Clear();
			//dialogProcessor.TranslateTo(e.Location);
			viewPort.Invalidate();
		}

		//Resize reduce
        private void reduceShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (dialogProcessor.Selection != null)
				statusBar.Items[0].Text = "Последно действие: Намаляване размера на фигурата";
			
			string message = "Въведете коректни стойности за преоразмеряване на примитива.";
			bool errorMessage = false;
			if (toolStripTextBox1.Text != "")
			{
				Console.WriteLine(toolStripTextBox1.Text);
				if (float.Parse(toolStripTextBox1.Text) > 0.01)
				{
					dialogProcessor.ResizeElementReduce(float.Parse(toolStripTextBox1.Text));
				}
				else
				{
					errorMessage = true;
				}

			}
			else
			{
				errorMessage = true;
			}
			if (errorMessage)
			{
				MessageBox.Show(message, "Намаляване на примитива");
				toolStripTextBox1.Clear();

			}
			toolStripTextBox1.Clear();
			//dialogProcessor.TranslateTo(e.Location);
			viewPort.Invalidate();
		}
		//Add triangle
        private void triangleBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomTriangle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

			viewPort.Invalidate();
		}

		//Add square
        private void squareBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomSquare();

			statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";

			viewPort.Invalidate();
		}

		//Add line
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

		//Clear workplace
        private void clearBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.ShapeList.Clear();
			statusBar.Items[0].Text = "Последно действие: Почистване на работното поле";
			viewPort.Invalidate();
		}

		//save primitives
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			WrapperClass currentSave = new WrapperClass(); 
			saveFileDialogBIN.ShowDialog();
			currentSave.Save(saveFileDialogBIN.FileName, dialogProcessor.ShapeList); 
			statusBar.Items[0].Text = "Последно действие: Запазване на примитивите";


		}

        private void MultipleSelector_Click(object sender, EventArgs e)
        {

        }

        private void pickUpSpeedButton_Click(object sender, EventArgs e)
        {

		}

        private void groupBtn_Click(object sender, EventArgs e)
        {

				statusBar.Items[0].Text = "Последно действие: Групиране на елементите";
				dialogProcessor.GroupShapes();
				MultipleSelector.PerformClick();
				viewPort.Invalidate();
			

        }

        private void UngroupBtn_Click(object sender, EventArgs e)
        {
			statusBar.Items[0].Text = "Последно действие: Разгрупиране на елементите";
			dialogProcessor.UngroupShapes();
			viewPort.Invalidate();
        }

		//Open save file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
			WrapperClass currentOpen = new WrapperClass();
			openFileDialog1.ShowDialog();
			dialogProcessor.ShapeList = currentOpen.Open(openFileDialog1.FileName);
			statusBar.Items[0].Text = "Последно действие: Отваряне на файл с примитиви";
			viewPort.Invalidate();
		}

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
		
		}
		//resize button
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
			clearBtn.PerformClick();
        }

        private void NameOfCurrentSelection_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
		
			dialogProcessor.OpacityShape(int.Parse(OpacityTextBox.Text));

        }

        private void RotateAngleTextBox_Click(object sender, EventArgs e)
        {

        }

        private void RemovePrimitiveBtn_Click(object sender, EventArgs e)
        {

			statusBar.Items[0].Text = "Последно действие: Изтриване на селектиран елемент";
			dialogProcessor.RemoveShape();
			viewPort.Invalidate();

		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
