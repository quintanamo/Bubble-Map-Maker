namespace Bubble_Map_Maker
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.addNodeButton = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.selectedNodeBox = new System.Windows.Forms.GroupBox();
            this.cloneNodeButton = new System.Windows.Forms.Button();
            this.textColorPreview = new System.Windows.Forms.PictureBox();
            this.bgColorPreview = new System.Windows.Forms.PictureBox();
            this.addChildNodeButton = new System.Windows.Forms.Button();
            this.deleteNodeButton = new System.Windows.Forms.Button();
            this.textColorLabel = new System.Windows.Forms.Label();
            this.textSizeTextbox = new System.Windows.Forms.NumericUpDown();
            this.textSizeLabel = new System.Windows.Forms.Label();
            this.bgColorLabel = new System.Windows.Forms.Label();
            this.sizeTextbox = new System.Windows.Forms.NumericUpDown();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.captionTextbox = new System.Windows.Forms.TextBox();
            this.captionLabel = new System.Windows.Forms.Label();
            this.connectionsBox = new System.Windows.Forms.GroupBox();
            this.lineColorPreview = new System.Windows.Forms.PictureBox();
            this.connectionLineColorLabel = new System.Windows.Forms.Label();
            this.connectionLineWidthLabel = new System.Windows.Forms.Label();
            this.connectionLineWidthTextbox = new System.Windows.Forms.NumericUpDown();
            this.mainToolstrip = new System.Windows.Forms.ToolStrip();
            this.fileMenuDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.openMapButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMapButton = new System.Windows.Forms.ToolStripMenuItem();
            this.newMapButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.undoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.redoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultStylesButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.selectedNodeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSizeTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTextbox)).BeginInit();
            this.connectionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionLineWidthTextbox)).BeginInit();
            this.mainToolstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNodeButton
            // 
            this.addNodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNodeButton.Location = new System.Drawing.Point(462, 39);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(150, 23);
            this.addNodeButton.TabIndex = 1;
            this.addNodeButton.Text = "Add New Node";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(12, 39);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(440, 403);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // selectedNodeBox
            // 
            this.selectedNodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedNodeBox.Controls.Add(this.cloneNodeButton);
            this.selectedNodeBox.Controls.Add(this.textColorPreview);
            this.selectedNodeBox.Controls.Add(this.bgColorPreview);
            this.selectedNodeBox.Controls.Add(this.addChildNodeButton);
            this.selectedNodeBox.Controls.Add(this.deleteNodeButton);
            this.selectedNodeBox.Controls.Add(this.textColorLabel);
            this.selectedNodeBox.Controls.Add(this.textSizeTextbox);
            this.selectedNodeBox.Controls.Add(this.textSizeLabel);
            this.selectedNodeBox.Controls.Add(this.bgColorLabel);
            this.selectedNodeBox.Controls.Add(this.sizeTextbox);
            this.selectedNodeBox.Controls.Add(this.sizeLabel);
            this.selectedNodeBox.Controls.Add(this.captionTextbox);
            this.selectedNodeBox.Controls.Add(this.captionLabel);
            this.selectedNodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedNodeBox.Location = new System.Drawing.Point(462, 158);
            this.selectedNodeBox.Name = "selectedNodeBox";
            this.selectedNodeBox.Size = new System.Drawing.Size(150, 285);
            this.selectedNodeBox.TabIndex = 3;
            this.selectedNodeBox.TabStop = false;
            this.selectedNodeBox.Text = "Selected Node";
            this.selectedNodeBox.Visible = false;
            // 
            // cloneNodeButton
            // 
            this.cloneNodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloneNodeButton.Location = new System.Drawing.Point(6, 196);
            this.cloneNodeButton.Name = "cloneNodeButton";
            this.cloneNodeButton.Size = new System.Drawing.Size(141, 23);
            this.cloneNodeButton.TabIndex = 15;
            this.cloneNodeButton.Text = "Clone Node";
            this.cloneNodeButton.UseVisualStyleBackColor = true;
            this.cloneNodeButton.Click += new System.EventHandler(this.cloneNodeButton_Click);
            // 
            // textColorPreview
            // 
            this.textColorPreview.BackColor = System.Drawing.Color.CadetBlue;
            this.textColorPreview.Location = new System.Drawing.Point(122, 165);
            this.textColorPreview.Name = "textColorPreview";
            this.textColorPreview.Size = new System.Drawing.Size(25, 25);
            this.textColorPreview.TabIndex = 14;
            this.textColorPreview.TabStop = false;
            this.textColorPreview.Click += new System.EventHandler(this.colorPreview_Click);
            // 
            // bgColorPreview
            // 
            this.bgColorPreview.BackColor = System.Drawing.Color.CadetBlue;
            this.bgColorPreview.Location = new System.Drawing.Point(122, 134);
            this.bgColorPreview.Name = "bgColorPreview";
            this.bgColorPreview.Size = new System.Drawing.Size(25, 25);
            this.bgColorPreview.TabIndex = 13;
            this.bgColorPreview.TabStop = false;
            this.bgColorPreview.Click += new System.EventHandler(this.colorPreview_Click);
            // 
            // addChildNodeButton
            // 
            this.addChildNodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addChildNodeButton.Location = new System.Drawing.Point(6, 225);
            this.addChildNodeButton.Name = "addChildNodeButton";
            this.addChildNodeButton.Size = new System.Drawing.Size(141, 23);
            this.addChildNodeButton.TabIndex = 12;
            this.addChildNodeButton.Text = "Add Child Node";
            this.addChildNodeButton.UseVisualStyleBackColor = true;
            this.addChildNodeButton.Click += new System.EventHandler(this.addChildNodeButton_Click);
            // 
            // deleteNodeButton
            // 
            this.deleteNodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNodeButton.Location = new System.Drawing.Point(6, 254);
            this.deleteNodeButton.Name = "deleteNodeButton";
            this.deleteNodeButton.Size = new System.Drawing.Size(141, 23);
            this.deleteNodeButton.TabIndex = 10;
            this.deleteNodeButton.Text = "Delete Node";
            this.deleteNodeButton.UseVisualStyleBackColor = true;
            this.deleteNodeButton.Click += new System.EventHandler(this.deleteNodeButton_Click);
            // 
            // textColorLabel
            // 
            this.textColorLabel.AutoSize = true;
            this.textColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColorLabel.Location = new System.Drawing.Point(9, 165);
            this.textColorLabel.Name = "textColorLabel";
            this.textColorLabel.Size = new System.Drawing.Size(58, 13);
            this.textColorLabel.TabIndex = 8;
            this.textColorLabel.Text = "Text Color:";
            // 
            // textSizeTextbox
            // 
            this.textSizeTextbox.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.textSizeTextbox.Location = new System.Drawing.Point(76, 100);
            this.textSizeTextbox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.textSizeTextbox.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.textSizeTextbox.Name = "textSizeTextbox";
            this.textSizeTextbox.Size = new System.Drawing.Size(71, 22);
            this.textSizeTextbox.TabIndex = 7;
            this.textSizeTextbox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.textSizeTextbox.ValueChanged += new System.EventHandler(this.onValueChangedHandler);
            // 
            // textSizeLabel
            // 
            this.textSizeLabel.AutoSize = true;
            this.textSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSizeLabel.Location = new System.Drawing.Point(6, 104);
            this.textSizeLabel.Name = "textSizeLabel";
            this.textSizeLabel.Size = new System.Drawing.Size(54, 13);
            this.textSizeLabel.TabIndex = 6;
            this.textSizeLabel.Text = "Text Size:";
            // 
            // bgColorLabel
            // 
            this.bgColorLabel.AutoSize = true;
            this.bgColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgColorLabel.Location = new System.Drawing.Point(6, 134);
            this.bgColorLabel.Name = "bgColorLabel";
            this.bgColorLabel.Size = new System.Drawing.Size(95, 13);
            this.bgColorLabel.TabIndex = 4;
            this.bgColorLabel.Text = "Background Color:";
            // 
            // sizeTextbox
            // 
            this.sizeTextbox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sizeTextbox.Location = new System.Drawing.Point(76, 72);
            this.sizeTextbox.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.sizeTextbox.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.sizeTextbox.Name = "sizeTextbox";
            this.sizeTextbox.Size = new System.Drawing.Size(71, 22);
            this.sizeTextbox.TabIndex = 3;
            this.sizeTextbox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.sizeTextbox.ValueChanged += new System.EventHandler(this.onValueChangedHandler);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(6, 76);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(59, 13);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Node Size:";
            // 
            // captionTextbox
            // 
            this.captionTextbox.Location = new System.Drawing.Point(6, 44);
            this.captionTextbox.Name = "captionTextbox";
            this.captionTextbox.Size = new System.Drawing.Size(141, 22);
            this.captionTextbox.TabIndex = 1;
            this.captionTextbox.TextChanged += new System.EventHandler(this.onValueChangedHandler);
            // 
            // captionLabel
            // 
            this.captionLabel.AutoSize = true;
            this.captionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLabel.Location = new System.Drawing.Point(6, 28);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(75, 13);
            this.captionLabel.TabIndex = 0;
            this.captionLabel.Text = "Node Caption:";
            // 
            // connectionsBox
            // 
            this.connectionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionsBox.Controls.Add(this.lineColorPreview);
            this.connectionsBox.Controls.Add(this.connectionLineColorLabel);
            this.connectionsBox.Controls.Add(this.connectionLineWidthLabel);
            this.connectionsBox.Controls.Add(this.connectionLineWidthTextbox);
            this.connectionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionsBox.Location = new System.Drawing.Point(462, 68);
            this.connectionsBox.Name = "connectionsBox";
            this.connectionsBox.Size = new System.Drawing.Size(150, 84);
            this.connectionsBox.TabIndex = 4;
            this.connectionsBox.TabStop = false;
            this.connectionsBox.Text = "Connection Lines";
            this.connectionsBox.Visible = false;
            // 
            // lineColorPreview
            // 
            this.lineColorPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lineColorPreview.Location = new System.Drawing.Point(122, 52);
            this.lineColorPreview.Name = "lineColorPreview";
            this.lineColorPreview.Size = new System.Drawing.Size(25, 25);
            this.lineColorPreview.TabIndex = 15;
            this.lineColorPreview.TabStop = false;
            this.lineColorPreview.Click += new System.EventHandler(this.colorPreview_Click);
            // 
            // connectionLineColorLabel
            // 
            this.connectionLineColorLabel.AutoSize = true;
            this.connectionLineColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLineColorLabel.Location = new System.Drawing.Point(6, 52);
            this.connectionLineColorLabel.Name = "connectionLineColorLabel";
            this.connectionLineColorLabel.Size = new System.Drawing.Size(57, 13);
            this.connectionLineColorLabel.TabIndex = 14;
            this.connectionLineColorLabel.Text = "Line Color:";
            // 
            // connectionLineWidthLabel
            // 
            this.connectionLineWidthLabel.AutoSize = true;
            this.connectionLineWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLineWidthLabel.Location = new System.Drawing.Point(6, 28);
            this.connectionLineWidthLabel.Name = "connectionLineWidthLabel";
            this.connectionLineWidthLabel.Size = new System.Drawing.Size(61, 13);
            this.connectionLineWidthLabel.TabIndex = 13;
            this.connectionLineWidthLabel.Text = "Line Width:";
            // 
            // connectionLineWidthTextbox
            // 
            this.connectionLineWidthTextbox.Location = new System.Drawing.Point(76, 24);
            this.connectionLineWidthTextbox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.connectionLineWidthTextbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.connectionLineWidthTextbox.Name = "connectionLineWidthTextbox";
            this.connectionLineWidthTextbox.Size = new System.Drawing.Size(71, 22);
            this.connectionLineWidthTextbox.TabIndex = 13;
            this.connectionLineWidthTextbox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.connectionLineWidthTextbox.ValueChanged += new System.EventHandler(this.onValueChangedHandler);
            // 
            // mainToolstrip
            // 
            this.mainToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuDropdown,
            this.editMenuDropdown});
            this.mainToolstrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolstrip.Name = "mainToolstrip";
            this.mainToolstrip.Padding = new System.Windows.Forms.Padding(0);
            this.mainToolstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainToolstrip.Size = new System.Drawing.Size(624, 25);
            this.mainToolstrip.TabIndex = 5;
            // 
            // fileMenuDropdown
            // 
            this.fileMenuDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenuDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMapButton,
            this.openMapButton,
            this.saveMapButton,
            this.exportMapButton});
            this.fileMenuDropdown.Image = ((System.Drawing.Image)(resources.GetObject("fileMenuDropdown.Image")));
            this.fileMenuDropdown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileMenuDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenuDropdown.Name = "fileMenuDropdown";
            this.fileMenuDropdown.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fileMenuDropdown.ShowDropDownArrow = false;
            this.fileMenuDropdown.Size = new System.Drawing.Size(49, 22);
            this.fileMenuDropdown.Text = "File";
            this.fileMenuDropdown.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // openMapButton
            // 
            this.openMapButton.Name = "openMapButton";
            this.openMapButton.Size = new System.Drawing.Size(180, 22);
            this.openMapButton.Text = "Open Map";
            // 
            // saveMapButton
            // 
            this.saveMapButton.Name = "saveMapButton";
            this.saveMapButton.Size = new System.Drawing.Size(180, 22);
            this.saveMapButton.Text = "Save Map";
            // 
            // exportMapButton
            // 
            this.exportMapButton.Name = "exportMapButton";
            this.exportMapButton.Size = new System.Drawing.Size(180, 22);
            this.exportMapButton.Text = "Export Map";
            // 
            // newMapButton
            // 
            this.newMapButton.Name = "newMapButton";
            this.newMapButton.Size = new System.Drawing.Size(180, 22);
            this.newMapButton.Text = "New Map";
            // 
            // editMenuDropdown
            // 
            this.editMenuDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editMenuDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoButton,
            this.redoButton,
            this.setDefaultStylesButton});
            this.editMenuDropdown.Image = ((System.Drawing.Image)(resources.GetObject("editMenuDropdown.Image")));
            this.editMenuDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editMenuDropdown.Name = "editMenuDropdown";
            this.editMenuDropdown.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.editMenuDropdown.ShowDropDownArrow = false;
            this.editMenuDropdown.Size = new System.Drawing.Size(51, 22);
            this.editMenuDropdown.Text = "Edit";
            // 
            // undoButton
            // 
            this.undoButton.Enabled = false;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(180, 22);
            this.undoButton.Text = "Undo";
            // 
            // redoButton
            // 
            this.redoButton.Enabled = false;
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(180, 22);
            this.redoButton.Text = "Redo";
            // 
            // setDefaultStylesButton
            // 
            this.setDefaultStylesButton.Name = "setDefaultStylesButton";
            this.setDefaultStylesButton.Size = new System.Drawing.Size(180, 22);
            this.setDefaultStylesButton.Text = "Set Default Styles";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(624, 455);
            this.Controls.Add(this.mainToolstrip);
            this.Controls.Add(this.connectionsBox);
            this.Controls.Add(this.selectedNodeBox);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.addNodeButton);
            this.MinimumSize = new System.Drawing.Size(640, 494);
            this.Name = "mainForm";
            this.Text = "Bubble Map Maker";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.selectedNodeBox.ResumeLayout(false);
            this.selectedNodeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textColorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSizeTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTextbox)).EndInit();
            this.connectionsBox.ResumeLayout(false);
            this.connectionsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineColorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionLineWidthTextbox)).EndInit();
            this.mainToolstrip.ResumeLayout(false);
            this.mainToolstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNodeButton;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.GroupBox selectedNodeBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox captionTextbox;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.NumericUpDown sizeTextbox;
        private System.Windows.Forms.Label bgColorLabel;
        private System.Windows.Forms.Label textColorLabel;
        private System.Windows.Forms.NumericUpDown textSizeTextbox;
        private System.Windows.Forms.Label textSizeLabel;
        private System.Windows.Forms.Button deleteNodeButton;
        private System.Windows.Forms.Button addChildNodeButton;
        private System.Windows.Forms.GroupBox connectionsBox;
        private System.Windows.Forms.Label connectionLineColorLabel;
        private System.Windows.Forms.Label connectionLineWidthLabel;
        private System.Windows.Forms.NumericUpDown connectionLineWidthTextbox;
        private System.Windows.Forms.PictureBox bgColorPreview;
        private System.Windows.Forms.PictureBox textColorPreview;
        private System.Windows.Forms.PictureBox lineColorPreview;
        private System.Windows.Forms.Button cloneNodeButton;
        private System.Windows.Forms.ToolStrip mainToolstrip;
        private System.Windows.Forms.ToolStripDropDownButton fileMenuDropdown;
        private System.Windows.Forms.ToolStripMenuItem openMapButton;
        private System.Windows.Forms.ToolStripMenuItem saveMapButton;
        private System.Windows.Forms.ToolStripMenuItem exportMapButton;
        private System.Windows.Forms.ToolStripMenuItem newMapButton;
        private System.Windows.Forms.ToolStripDropDownButton editMenuDropdown;
        private System.Windows.Forms.ToolStripMenuItem undoButton;
        private System.Windows.Forms.ToolStripMenuItem redoButton;
        private System.Windows.Forms.ToolStripMenuItem setDefaultStylesButton;
    }
}

