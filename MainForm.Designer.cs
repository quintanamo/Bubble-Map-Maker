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
            this.addNodeButton = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.selectedNodeBox = new System.Windows.Forms.GroupBox();
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
            this.connectionLineColorLabel = new System.Windows.Forms.Label();
            this.connectionLineWidthLabel = new System.Windows.Forms.Label();
            this.connectionLineWidthTextbox = new System.Windows.Forms.NumericUpDown();
            this.lineColorPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.selectedNodeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSizeTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTextbox)).BeginInit();
            this.connectionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionLineWidthTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineColorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // addNodeButton
            // 
            this.addNodeButton.Location = new System.Drawing.Point(819, 13);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(153, 23);
            this.addNodeButton.TabIndex = 1;
            this.addNodeButton.Text = "Add Node";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(13, 13);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 600);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // selectedNodeBox
            // 
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
            this.selectedNodeBox.Location = new System.Drawing.Point(819, 153);
            this.selectedNodeBox.Name = "selectedNodeBox";
            this.selectedNodeBox.Size = new System.Drawing.Size(153, 254);
            this.selectedNodeBox.TabIndex = 3;
            this.selectedNodeBox.TabStop = false;
            this.selectedNodeBox.Text = "Selected Node";
            this.selectedNodeBox.Visible = false;
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
            this.addChildNodeButton.Location = new System.Drawing.Point(6, 196);
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
            this.deleteNodeButton.Location = new System.Drawing.Point(6, 225);
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
            this.connectionsBox.Controls.Add(this.lineColorPreview);
            this.connectionsBox.Controls.Add(this.connectionLineColorLabel);
            this.connectionsBox.Controls.Add(this.connectionLineWidthLabel);
            this.connectionsBox.Controls.Add(this.connectionLineWidthTextbox);
            this.connectionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionsBox.Location = new System.Drawing.Point(819, 63);
            this.connectionsBox.Name = "connectionsBox";
            this.connectionsBox.Size = new System.Drawing.Size(153, 84);
            this.connectionsBox.TabIndex = 4;
            this.connectionsBox.TabStop = false;
            this.connectionsBox.Text = "Connection Lines";
            this.connectionsBox.Visible = false;
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(984, 625);
            this.Controls.Add(this.connectionsBox);
            this.Controls.Add(this.selectedNodeBox);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.addNodeButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 664);
            this.MinimumSize = new System.Drawing.Size(1000, 664);
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
            ((System.ComponentModel.ISupportInitialize)(this.connectionLineWidthTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineColorPreview)).EndInit();
            this.ResumeLayout(false);

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
    }
}

