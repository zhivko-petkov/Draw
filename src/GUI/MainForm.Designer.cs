namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.MultipleSelector = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lineBtn = new System.Windows.Forms.ToolStripButton();
            this.ellipseBtn = new System.Windows.Forms.ToolStripButton();
            this.triangleBtn = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.squareBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.FillColorBtn = new System.Windows.Forms.ToolStripButton();
            this.StrokeColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.OpacityTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBtn = new System.Windows.Forms.ToolStripButton();
            this.UngroupBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Rotate = new System.Windows.Forms.ToolStripButton();
            this.RotateAngleTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.ResizeBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.reduceShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.clearBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.pointerCoordinatesLabel = new System.Windows.Forms.Label();
            this.fillColorDialog = new System.Windows.Forms.ColorDialog();
            this.strokeColorDialog = new System.Windows.Forms.ColorDialog();
            this.PointerPosition = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemovePrimitiveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.saveFileDialogBIN = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NameOfCurrentSelection = new System.Windows.Forms.Label();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(981, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.MultipleSelector,
            this.toolStripSeparator5,
            this.lineBtn,
            this.ellipseBtn,
            this.triangleBtn,
            this.drawRectangleSpeedButton,
            this.squareBtn,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.FillColorBtn,
            this.StrokeColorBtn,
            this.toolStripButton2,
            this.OpacityTextBox,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.groupBtn,
            this.UngroupBtn,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.Rotate,
            this.RotateAngleTextBox,
            this.toolStripSeparator1,
            this.toolStripLabel4,
            this.ResizeBtn,
            this.toolStripTextBox1,
            this.toolStripSeparator6,
            this.clearBtn,
            this.toolStripSeparator7});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(981, 27);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(24, 24);
            this.pickUpSpeedButton.Text = "Select";
            this.pickUpSpeedButton.Click += new System.EventHandler(this.pickUpSpeedButton_Click);
            // 
            // MultipleSelector
            // 
            this.MultipleSelector.CheckOnClick = true;
            this.MultipleSelector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MultipleSelector.Image = ((System.Drawing.Image)(resources.GetObject("MultipleSelector.Image")));
            this.MultipleSelector.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MultipleSelector.Name = "MultipleSelector";
            this.MultipleSelector.Size = new System.Drawing.Size(24, 24);
            this.MultipleSelector.Text = "MultipleSelector";
            this.MultipleSelector.Click += new System.EventHandler(this.MultipleSelector_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // lineBtn
            // 
            this.lineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineBtn.Image = ((System.Drawing.Image)(resources.GetObject("lineBtn.Image")));
            this.lineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(24, 24);
            this.lineBtn.Text = "Line";
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseBtn.Image = ((System.Drawing.Image)(resources.GetObject("ellipseBtn.Image")));
            this.ellipseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(24, 24);
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // triangleBtn
            // 
            this.triangleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.triangleBtn.Image = ((System.Drawing.Image)(resources.GetObject("triangleBtn.Image")));
            this.triangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(24, 24);
            this.triangleBtn.Text = "Triangle";
            this.triangleBtn.Click += new System.EventHandler(this.triangleBtn_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(24, 24);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // squareBtn
            // 
            this.squareBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.squareBtn.Image = ((System.Drawing.Image)(resources.GetObject("squareBtn.Image")));
            this.squareBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(24, 24);
            this.squareBtn.Text = "DrawSquare";
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(36, 24);
            this.toolStripLabel3.Text = "Color";
            // 
            // FillColorBtn
            // 
            this.FillColorBtn.BackColor = System.Drawing.SystemColors.Info;
            this.FillColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.FillColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("FillColorBtn.Image")));
            this.FillColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorBtn.Name = "FillColorBtn";
            this.FillColorBtn.Size = new System.Drawing.Size(23, 24);
            this.FillColorBtn.Text = "Fill Color";
            this.FillColorBtn.Click += new System.EventHandler(this.FillColorBtn_Click);
            // 
            // StrokeColorBtn
            // 
            this.StrokeColorBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StrokeColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.StrokeColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("StrokeColorBtn.Image")));
            this.StrokeColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StrokeColorBtn.Name = "StrokeColorBtn";
            this.StrokeColorBtn.Size = new System.Drawing.Size(23, 24);
            this.StrokeColorBtn.Text = "Stroke Color";
            this.StrokeColorBtn.Click += new System.EventHandler(this.StrokeColorBtn_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Opacity";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // OpacityTextBox
            // 
            this.OpacityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpacityTextBox.Name = "OpacityTextBox";
            this.OpacityTextBox.Size = new System.Drawing.Size(30, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 24);
            this.toolStripLabel1.Text = "Group";
            // 
            // groupBtn
            // 
            this.groupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupBtn.Image = ((System.Drawing.Image)(resources.GetObject("groupBtn.Image")));
            this.groupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(24, 24);
            this.groupBtn.Text = "GroupSelectedElements";
            this.groupBtn.Click += new System.EventHandler(this.groupBtn_Click);
            // 
            // UngroupBtn
            // 
            this.UngroupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UngroupBtn.Image = ((System.Drawing.Image)(resources.GetObject("UngroupBtn.Image")));
            this.UngroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UngroupBtn.Name = "UngroupBtn";
            this.UngroupBtn.Size = new System.Drawing.Size(24, 24);
            this.UngroupBtn.Text = "UngroupBtn";
            this.UngroupBtn.Click += new System.EventHandler(this.UngroupBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 24);
            this.toolStripLabel2.Text = "Rotate";
            // 
            // Rotate
            // 
            this.Rotate.BackColor = System.Drawing.Color.White;
            this.Rotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rotate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Rotate.Image = ((System.Drawing.Image)(resources.GetObject("Rotate.Image")));
            this.Rotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rotate.Margin = new System.Windows.Forms.Padding(0);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(24, 27);
            this.Rotate.Text = "Rotate";
            // 
            // RotateAngleTextBox
            // 
            this.RotateAngleTextBox.BackColor = System.Drawing.Color.White;
            this.RotateAngleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RotateAngleTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RotateAngleTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.RotateAngleTextBox.Name = "RotateAngleTextBox";
            this.RotateAngleTextBox.Size = new System.Drawing.Size(30, 27);
            this.RotateAngleTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RotateAngleTextBox.Click += new System.EventHandler(this.RotateAngleTextBox_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(27, 24);
            this.toolStripLabel4.Text = "Size";
            // 
            // ResizeBtn
            // 
            this.ResizeBtn.BackColor = System.Drawing.Color.White;
            this.ResizeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResizeBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.reduceShapeToolStripMenuItem});
            this.ResizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResizeBtn.Image")));
            this.ResizeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResizeBtn.Name = "ResizeBtn";
            this.ResizeBtn.Size = new System.Drawing.Size(36, 24);
            this.ResizeBtn.Text = "ResizeSelectedElement";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem2.Text = "Enlarge shape";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            // 
            // reduceShapeToolStripMenuItem
            // 
            this.reduceShapeToolStripMenuItem.Name = "reduceShapeToolStripMenuItem";
            this.reduceShapeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.reduceShapeToolStripMenuItem.Text = "Reduce shape";
            this.reduceShapeToolStripMenuItem.Click += new System.EventHandler(this.reduceShapeToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(30, 27);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // clearBtn
            // 
            this.clearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(24, 24);
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // pointerCoordinatesLabel
            // 
            this.pointerCoordinatesLabel.AutoSize = true;
            this.pointerCoordinatesLabel.Location = new System.Drawing.Point(13, 53);
            this.pointerCoordinatesLabel.Name = "pointerCoordinatesLabel";
            this.pointerCoordinatesLabel.Size = new System.Drawing.Size(0, 16);
            this.pointerCoordinatesLabel.TabIndex = 4;
            // 
            // PointerPosition
            // 
            this.PointerPosition.AutoSize = true;
            this.PointerPosition.Location = new System.Drawing.Point(868, 9);
            this.PointerPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PointerPosition.Name = "PointerPosition";
            this.PointerPosition.Size = new System.Drawing.Size(100, 16);
            this.PointerPosition.TabIndex = 5;
            this.PointerPosition.Text = "Pointer position";
            this.PointerPosition.Click += new System.EventHandler(this.PointerPosition_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemovePrimitiveBtn,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // RemovePrimitiveBtn
            // 
            this.RemovePrimitiveBtn.Name = "RemovePrimitiveBtn";
            this.RemovePrimitiveBtn.Size = new System.Drawing.Size(134, 22);
            this.RemovePrimitiveBtn.Text = "Remove";
            this.RemovePrimitiveBtn.Click += new System.EventHandler(this.RemovePrimitiveBtn_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem4.Text = "Remove All";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem5.Text = "Copy";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem6.Text = "Paste";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem7.Text = "Duplicate";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(981, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // NameOfCurrentSelection
            // 
            this.NameOfCurrentSelection.AutoSize = true;
            this.NameOfCurrentSelection.Location = new System.Drawing.Point(674, 9);
            this.NameOfCurrentSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameOfCurrentSelection.Name = "NameOfCurrentSelection";
            this.NameOfCurrentSelection.Size = new System.Drawing.Size(107, 16);
            this.NameOfCurrentSelection.TabIndex = 6;
            this.NameOfCurrentSelection.Text = "Current selection";
            this.NameOfCurrentSelection.Click += new System.EventHandler(this.NameOfCurrentSelection_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 51);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(981, 448);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 521);
            this.Controls.Add(this.NameOfCurrentSelection);
            this.Controls.Add(this.PointerPosition);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.pointerCoordinatesLabel);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripButton ellipseBtn;
        private System.Windows.Forms.ToolStripButton triangleBtn;
        private System.Windows.Forms.ToolStripButton squareBtn;
        private System.Windows.Forms.Label pointerCoordinatesLabel;
        private System.Windows.Forms.ToolStripButton FillColorBtn;
        private System.Windows.Forms.ToolStripButton StrokeColorBtn;
        private System.Windows.Forms.ColorDialog fillColorDialog;
        private System.Windows.Forms.ColorDialog strokeColorDialog;
        private System.Windows.Forms.ToolStripSplitButton ResizeBtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reduceShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton lineBtn;
        private System.Windows.Forms.ToolStripButton groupBtn;
        private System.Windows.Forms.Label PointerPosition;
        private System.Windows.Forms.ToolStripButton clearBtn;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBIN;
        private System.Windows.Forms.ToolStripButton MultipleSelector;
        private System.Windows.Forms.ToolStripButton Rotate;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton UngroupBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripTextBox RotateAngleTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem RemovePrimitiveBtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.Label NameOfCurrentSelection;
        private System.Windows.Forms.ToolStripTextBox OpacityTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}
