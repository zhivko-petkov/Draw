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
            this.lineBtn = new System.Windows.Forms.ToolStripButton();
            this.ellipseBtn = new System.Windows.Forms.ToolStripButton();
            this.triangleBtn = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.squareBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ResizeBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.reduceShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FillColorBtn = new System.Windows.Forms.ToolStripButton();
            this.StrokeColorBtn = new System.Windows.Forms.ToolStripButton();
            this.clearBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBtn = new System.Windows.Forms.ToolStripButton();
            this.pointerCoordinatesLabel = new System.Windows.Forms.Label();
            this.fillColorDialog = new System.Windows.Forms.ColorDialog();
            this.strokeColorDialog = new System.Windows.Forms.ColorDialog();
            this.PointerPosition = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.UngroupBtn = new System.Windows.Forms.ToolStripButton();
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
            this.statusBar.Size = new System.Drawing.Size(924, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.MultipleSelector,
            this.lineBtn,
            this.ellipseBtn,
            this.triangleBtn,
            this.drawRectangleSpeedButton,
            this.squareBtn,
            this.SaveBtn,
            this.toolStripButton1,
            this.toolStripButton2,
            this.ResizeBtn,
            this.FillColorBtn,
            this.StrokeColorBtn,
            this.clearBtn,
            this.groupBtn,
            this.UngroupBtn});
            this.speedMenu.Location = new System.Drawing.Point(0, 28);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(924, 27);
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
            this.pickUpSpeedButton.Size = new System.Drawing.Size(29, 24);
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
            this.MultipleSelector.Size = new System.Drawing.Size(29, 24);
            this.MultipleSelector.Text = "MultipleSelector";
            this.MultipleSelector.Click += new System.EventHandler(this.MultipleSelector_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineBtn.Image = ((System.Drawing.Image)(resources.GetObject("lineBtn.Image")));
            this.lineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(29, 24);
            this.lineBtn.Text = "Line";
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseBtn.Image = ((System.Drawing.Image)(resources.GetObject("ellipseBtn.Image")));
            this.ellipseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(29, 24);
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // triangleBtn
            // 
            this.triangleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.triangleBtn.Image = ((System.Drawing.Image)(resources.GetObject("triangleBtn.Image")));
            this.triangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(29, 24);
            this.triangleBtn.Text = "Triangle";
            this.triangleBtn.Click += new System.EventHandler(this.triangleBtn_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // squareBtn
            // 
            this.squareBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.squareBtn.Image = ((System.Drawing.Image)(resources.GetObject("squareBtn.Image")));
            this.squareBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(29, 24);
            this.squareBtn.Text = "DrawSquare";
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(29, 24);
            this.SaveBtn.Text = "Save";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Opacity";
            // 
            // ResizeBtn
            // 
            this.ResizeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResizeBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.reduceShapeToolStripMenuItem});
            this.ResizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResizeBtn.Image")));
            this.ResizeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResizeBtn.Name = "ResizeBtn";
            this.ResizeBtn.Size = new System.Drawing.Size(39, 24);
            this.ResizeBtn.Text = "ResizeSelectedElement";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 26);
            this.toolStripMenuItem2.Text = "Enlarge shape";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // reduceShapeToolStripMenuItem
            // 
            this.reduceShapeToolStripMenuItem.Name = "reduceShapeToolStripMenuItem";
            this.reduceShapeToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.reduceShapeToolStripMenuItem.Text = "Reduce shape";
            this.reduceShapeToolStripMenuItem.Click += new System.EventHandler(this.reduceShapeToolStripMenuItem_Click);
            // 
            // FillColorBtn
            // 
            this.FillColorBtn.BackColor = System.Drawing.SystemColors.Info;
            this.FillColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.FillColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("FillColorBtn.Image")));
            this.FillColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorBtn.Name = "FillColorBtn";
            this.FillColorBtn.Size = new System.Drawing.Size(29, 24);
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
            this.StrokeColorBtn.Size = new System.Drawing.Size(29, 24);
            this.StrokeColorBtn.Text = "Stroke Color";
            this.StrokeColorBtn.Click += new System.EventHandler(this.StrokeColorBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(29, 24);
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // groupBtn
            // 
            this.groupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupBtn.Image = ((System.Drawing.Image)(resources.GetObject("groupBtn.Image")));
            this.groupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(29, 24);
            this.groupBtn.Text = "GroupSelectedElements";
            this.groupBtn.Click += new System.EventHandler(this.groupBtn_Click);
            // 
            // pointerCoordinatesLabel
            // 
            this.pointerCoordinatesLabel.AutoSize = true;
            this.pointerCoordinatesLabel.Location = new System.Drawing.Point(13, 53);
            this.pointerCoordinatesLabel.Name = "pointerCoordinatesLabel";
            this.pointerCoordinatesLabel.Size = new System.Drawing.Size(0, 17);
            this.pointerCoordinatesLabel.TabIndex = 4;
            // 
            // PointerPosition
            // 
            this.PointerPosition.AutoSize = true;
            this.PointerPosition.Location = new System.Drawing.Point(697, 9);
            this.PointerPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PointerPosition.Name = "PointerPosition";
            this.PointerPosition.Size = new System.Drawing.Size(46, 17);
            this.PointerPosition.TabIndex = 5;
            this.PointerPosition.Text = "label1";
            this.PointerPosition.Click += new System.EventHandler(this.PointerPosition_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
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
            this.mainMenu.Size = new System.Drawing.Size(924, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 55);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(924, 444);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // UngroupBtn
            // 
            this.UngroupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UngroupBtn.Image = ((System.Drawing.Image)(resources.GetObject("UngroupBtn.Image")));
            this.UngroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UngroupBtn.Name = "UngroupBtn";
            this.UngroupBtn.Size = new System.Drawing.Size(29, 24);
            this.UngroupBtn.Text = "UngroupBtn";
            this.UngroupBtn.Click += new System.EventHandler(this.UngroupBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
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
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton MultipleSelector;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton UngroupBtn;
    }
}
