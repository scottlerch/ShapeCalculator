namespace ShapeCalculator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxCircleArea = new System.Windows.Forms.TextBox();
            this.bindingSourceCircle = new System.Windows.Forms.BindingSource(this.components);
            this.labelCircleArea = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCircleRadius = new System.Windows.Forms.Label();
            this.groupBoxCircle = new System.Windows.Forms.GroupBox();
            this.groupBoxSquare = new System.Windows.Forms.GroupBox();
            this.labelSquareLength = new System.Windows.Forms.Label();
            this.labelSquareArea = new System.Windows.Forms.Label();
            this.textBoxSquareArea = new System.Windows.Forms.TextBox();
            this.bindingSourceSquare = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSquareLength = new System.Windows.Forms.TextBox();
            this.groupBoxRectangle = new System.Windows.Forms.GroupBox();
            this.labelRectangleWidth = new System.Windows.Forms.Label();
            this.textBoxWidthLength = new System.Windows.Forms.TextBox();
            this.bindingSourceRectangle = new System.Windows.Forms.BindingSource(this.components);
            this.labelRectangleLength = new System.Windows.Forms.Label();
            this.labelRectangleArea = new System.Windows.Forms.Label();
            this.textBoxRectangleArea = new System.Windows.Forms.TextBox();
            this.textBoxRectangleLength = new System.Windows.Forms.TextBox();
            this.errorProviderCircle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSquare = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRectangle = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelEllipseRadiusB = new System.Windows.Forms.Label();
            this.textBoxEllipseRadiusB = new System.Windows.Forms.TextBox();
            this.labelEllipseRadiusA = new System.Windows.Forms.Label();
            this.labelEllipseArea = new System.Windows.Forms.Label();
            this.textBoxEllipseArea = new System.Windows.Forms.TextBox();
            this.textBoxEllipseRadiusA = new System.Windows.Forms.TextBox();
            this.bindingSourceEllipse = new System.Windows.Forms.BindingSource(this.components);
            this.errorProviderEllipse = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCircle)).BeginInit();
            this.groupBoxCircle.SuspendLayout();
            this.groupBoxSquare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSquare)).BeginInit();
            this.groupBoxRectangle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRectangle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEllipse)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCircleArea
            // 
            this.textBoxCircleArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCircleArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCircle, "Area", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N6"));
            this.textBoxCircleArea.Location = new System.Drawing.Point(188, 38);
            this.textBoxCircleArea.Name = "textBoxCircleArea";
            this.textBoxCircleArea.ReadOnly = true;
            this.textBoxCircleArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxCircleArea.TabIndex = 2;
            // 
            // bindingSourceCircle
            // 
            this.bindingSourceCircle.DataSource = typeof(ShapeLibrary.Circle);
            // 
            // labelCircleArea
            // 
            this.labelCircleArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCircleArea.AutoSize = true;
            this.labelCircleArea.Location = new System.Drawing.Point(185, 22);
            this.labelCircleArea.Name = "labelCircleArea";
            this.labelCircleArea.Size = new System.Drawing.Size(32, 13);
            this.labelCircleArea.TabIndex = 1;
            this.labelCircleArea.Text = "Area:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCircle, "Radius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(13, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelCircleRadius
            // 
            this.labelCircleRadius.AutoSize = true;
            this.labelCircleRadius.Location = new System.Drawing.Point(13, 22);
            this.labelCircleRadius.Name = "labelCircleRadius";
            this.labelCircleRadius.Size = new System.Drawing.Size(43, 13);
            this.labelCircleRadius.TabIndex = 3;
            this.labelCircleRadius.Text = "Radius:";
            // 
            // groupBoxCircle
            // 
            this.groupBoxCircle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCircle.Controls.Add(this.labelCircleRadius);
            this.groupBoxCircle.Controls.Add(this.labelCircleArea);
            this.groupBoxCircle.Controls.Add(this.textBoxCircleArea);
            this.groupBoxCircle.Controls.Add(this.textBox1);
            this.groupBoxCircle.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCircle.Name = "groupBoxCircle";
            this.groupBoxCircle.Size = new System.Drawing.Size(301, 75);
            this.groupBoxCircle.TabIndex = 0;
            this.groupBoxCircle.TabStop = false;
            this.groupBoxCircle.Text = "Circle";
            // 
            // groupBoxSquare
            // 
            this.groupBoxSquare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSquare.Controls.Add(this.labelSquareLength);
            this.groupBoxSquare.Controls.Add(this.labelSquareArea);
            this.groupBoxSquare.Controls.Add(this.textBoxSquareArea);
            this.groupBoxSquare.Controls.Add(this.textBoxSquareLength);
            this.groupBoxSquare.Location = new System.Drawing.Point(12, 93);
            this.groupBoxSquare.Name = "groupBoxSquare";
            this.groupBoxSquare.Size = new System.Drawing.Size(301, 75);
            this.groupBoxSquare.TabIndex = 3;
            this.groupBoxSquare.TabStop = false;
            this.groupBoxSquare.Text = "Square";
            // 
            // labelSquareLength
            // 
            this.labelSquareLength.AutoSize = true;
            this.labelSquareLength.Location = new System.Drawing.Point(13, 22);
            this.labelSquareLength.Name = "labelSquareLength";
            this.labelSquareLength.Size = new System.Drawing.Size(43, 13);
            this.labelSquareLength.TabIndex = 3;
            this.labelSquareLength.Text = "Length:";
            // 
            // labelSquareArea
            // 
            this.labelSquareArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSquareArea.AutoSize = true;
            this.labelSquareArea.Location = new System.Drawing.Point(185, 22);
            this.labelSquareArea.Name = "labelSquareArea";
            this.labelSquareArea.Size = new System.Drawing.Size(32, 13);
            this.labelSquareArea.TabIndex = 1;
            this.labelSquareArea.Text = "Area:";
            // 
            // textBoxSquareArea
            // 
            this.textBoxSquareArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSquareArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSquare, "Area", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N5"));
            this.textBoxSquareArea.Location = new System.Drawing.Point(188, 38);
            this.textBoxSquareArea.Name = "textBoxSquareArea";
            this.textBoxSquareArea.ReadOnly = true;
            this.textBoxSquareArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxSquareArea.TabIndex = 5;
            // 
            // bindingSourceSquare
            // 
            this.bindingSourceSquare.DataSource = typeof(ShapeLibrary.Square);
            // 
            // textBoxSquareLength
            // 
            this.textBoxSquareLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSquare, "Length", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxSquareLength.Location = new System.Drawing.Point(13, 38);
            this.textBoxSquareLength.Name = "textBoxSquareLength";
            this.textBoxSquareLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxSquareLength.TabIndex = 4;
            // 
            // groupBoxRectangle
            // 
            this.groupBoxRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRectangle.Controls.Add(this.labelRectangleWidth);
            this.groupBoxRectangle.Controls.Add(this.textBoxWidthLength);
            this.groupBoxRectangle.Controls.Add(this.labelRectangleLength);
            this.groupBoxRectangle.Controls.Add(this.labelRectangleArea);
            this.groupBoxRectangle.Controls.Add(this.textBoxRectangleArea);
            this.groupBoxRectangle.Controls.Add(this.textBoxRectangleLength);
            this.groupBoxRectangle.Location = new System.Drawing.Point(12, 174);
            this.groupBoxRectangle.Name = "groupBoxRectangle";
            this.groupBoxRectangle.Size = new System.Drawing.Size(301, 113);
            this.groupBoxRectangle.TabIndex = 6;
            this.groupBoxRectangle.TabStop = false;
            this.groupBoxRectangle.Text = "Rectangle";
            // 
            // labelRectangleWidth
            // 
            this.labelRectangleWidth.AutoSize = true;
            this.labelRectangleWidth.Location = new System.Drawing.Point(13, 64);
            this.labelRectangleWidth.Name = "labelRectangleWidth";
            this.labelRectangleWidth.Size = new System.Drawing.Size(38, 13);
            this.labelRectangleWidth.TabIndex = 5;
            this.labelRectangleWidth.Text = "Width:";
            // 
            // textBoxWidthLength
            // 
            this.textBoxWidthLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceRectangle, "Width", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxWidthLength.Location = new System.Drawing.Point(13, 80);
            this.textBoxWidthLength.Name = "textBoxWidthLength";
            this.textBoxWidthLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidthLength.TabIndex = 8;
            // 
            // bindingSourceRectangle
            // 
            this.bindingSourceRectangle.DataSource = typeof(ShapeLibrary.Rectangle);
            // 
            // labelRectangleLength
            // 
            this.labelRectangleLength.AutoSize = true;
            this.labelRectangleLength.Location = new System.Drawing.Point(13, 22);
            this.labelRectangleLength.Name = "labelRectangleLength";
            this.labelRectangleLength.Size = new System.Drawing.Size(43, 13);
            this.labelRectangleLength.TabIndex = 3;
            this.labelRectangleLength.Text = "Length:";
            // 
            // labelRectangleArea
            // 
            this.labelRectangleArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRectangleArea.AutoSize = true;
            this.labelRectangleArea.Location = new System.Drawing.Point(185, 64);
            this.labelRectangleArea.Name = "labelRectangleArea";
            this.labelRectangleArea.Size = new System.Drawing.Size(32, 13);
            this.labelRectangleArea.TabIndex = 1;
            this.labelRectangleArea.Text = "Area:";
            // 
            // textBoxRectangleArea
            // 
            this.textBoxRectangleArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRectangleArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceRectangle, "Area", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N6"));
            this.textBoxRectangleArea.Location = new System.Drawing.Point(188, 80);
            this.textBoxRectangleArea.Name = "textBoxRectangleArea";
            this.textBoxRectangleArea.ReadOnly = true;
            this.textBoxRectangleArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxRectangleArea.TabIndex = 9;
            // 
            // textBoxRectangleLength
            // 
            this.textBoxRectangleLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceRectangle, "Length", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxRectangleLength.Location = new System.Drawing.Point(13, 38);
            this.textBoxRectangleLength.Name = "textBoxRectangleLength";
            this.textBoxRectangleLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxRectangleLength.TabIndex = 7;
            // 
            // errorProviderCircle
            // 
            this.errorProviderCircle.ContainerControl = this;
            this.errorProviderCircle.DataSource = this.bindingSourceCircle;
            // 
            // errorProviderSquare
            // 
            this.errorProviderSquare.ContainerControl = this;
            this.errorProviderSquare.DataSource = this.bindingSourceSquare;
            // 
            // errorProviderRectangle
            // 
            this.errorProviderRectangle.ContainerControl = this;
            this.errorProviderRectangle.DataSource = this.bindingSourceRectangle;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelEllipseRadiusB);
            this.groupBox1.Controls.Add(this.textBoxEllipseRadiusB);
            this.groupBox1.Controls.Add(this.labelEllipseRadiusA);
            this.groupBox1.Controls.Add(this.labelEllipseArea);
            this.groupBox1.Controls.Add(this.textBoxEllipseArea);
            this.groupBox1.Controls.Add(this.textBoxEllipseRadiusA);
            this.groupBox1.Location = new System.Drawing.Point(12, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ellipse";
            // 
            // labelEllipseRadiusB
            // 
            this.labelEllipseRadiusB.AutoSize = true;
            this.labelEllipseRadiusB.Location = new System.Drawing.Point(13, 64);
            this.labelEllipseRadiusB.Name = "labelEllipseRadiusB";
            this.labelEllipseRadiusB.Size = new System.Drawing.Size(53, 13);
            this.labelEllipseRadiusB.TabIndex = 5;
            this.labelEllipseRadiusB.Text = "Radius B:";
            // 
            // textBoxEllipseRadiusB
            // 
            this.textBoxEllipseRadiusB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEllipse, "RadiusB", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxEllipseRadiusB.Location = new System.Drawing.Point(13, 80);
            this.textBoxEllipseRadiusB.Name = "textBoxEllipseRadiusB";
            this.textBoxEllipseRadiusB.Size = new System.Drawing.Size(100, 20);
            this.textBoxEllipseRadiusB.TabIndex = 8;
            // 
            // labelEllipseRadiusA
            // 
            this.labelEllipseRadiusA.AutoSize = true;
            this.labelEllipseRadiusA.Location = new System.Drawing.Point(13, 22);
            this.labelEllipseRadiusA.Name = "labelEllipseRadiusA";
            this.labelEllipseRadiusA.Size = new System.Drawing.Size(53, 13);
            this.labelEllipseRadiusA.TabIndex = 3;
            this.labelEllipseRadiusA.Text = "Radius A:";
            // 
            // labelEllipseArea
            // 
            this.labelEllipseArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEllipseArea.AutoSize = true;
            this.labelEllipseArea.Location = new System.Drawing.Point(185, 64);
            this.labelEllipseArea.Name = "labelEllipseArea";
            this.labelEllipseArea.Size = new System.Drawing.Size(32, 13);
            this.labelEllipseArea.TabIndex = 1;
            this.labelEllipseArea.Text = "Area:";
            // 
            // textBoxEllipseArea
            // 
            this.textBoxEllipseArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEllipseArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEllipse, "Area", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N6"));
            this.textBoxEllipseArea.Location = new System.Drawing.Point(188, 80);
            this.textBoxEllipseArea.Name = "textBoxEllipseArea";
            this.textBoxEllipseArea.ReadOnly = true;
            this.textBoxEllipseArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxEllipseArea.TabIndex = 9;
            // 
            // textBoxEllipseRadiusA
            // 
            this.textBoxEllipseRadiusA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEllipse, "RadiusA", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxEllipseRadiusA.Location = new System.Drawing.Point(13, 38);
            this.textBoxEllipseRadiusA.Name = "textBoxEllipseRadiusA";
            this.textBoxEllipseRadiusA.Size = new System.Drawing.Size(100, 20);
            this.textBoxEllipseRadiusA.TabIndex = 7;
            // 
            // bindingSourceEllipse
            // 
            this.bindingSourceEllipse.DataSource = typeof(ShapeLibrary.Ellipse);
            // 
            // errorProviderEllipse
            // 
            this.errorProviderEllipse.ContainerControl = this;
            this.errorProviderEllipse.DataSource = this.bindingSourceEllipse;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRectangle);
            this.Controls.Add(this.groupBoxSquare);
            this.Controls.Add(this.groupBoxCircle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Shape Calculator";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCircle)).EndInit();
            this.groupBoxCircle.ResumeLayout(false);
            this.groupBoxCircle.PerformLayout();
            this.groupBoxSquare.ResumeLayout(false);
            this.groupBoxSquare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSquare)).EndInit();
            this.groupBoxRectangle.ResumeLayout(false);
            this.groupBoxRectangle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRectangle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEllipse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCircleArea;
        private System.Windows.Forms.Label labelCircleArea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCircleRadius;
        private System.Windows.Forms.GroupBox groupBoxCircle;
        private System.Windows.Forms.GroupBox groupBoxSquare;
        private System.Windows.Forms.Label labelSquareLength;
        private System.Windows.Forms.Label labelSquareArea;
        private System.Windows.Forms.TextBox textBoxSquareArea;
        private System.Windows.Forms.TextBox textBoxSquareLength;
        private System.Windows.Forms.GroupBox groupBoxRectangle;
        private System.Windows.Forms.Label labelRectangleWidth;
        private System.Windows.Forms.TextBox textBoxWidthLength;
        private System.Windows.Forms.Label labelRectangleLength;
        private System.Windows.Forms.Label labelRectangleArea;
        private System.Windows.Forms.TextBox textBoxRectangleArea;
        private System.Windows.Forms.TextBox textBoxRectangleLength;
        private System.Windows.Forms.BindingSource bindingSourceCircle;
        private System.Windows.Forms.ErrorProvider errorProviderCircle;
        private System.Windows.Forms.BindingSource bindingSourceSquare;
        private System.Windows.Forms.BindingSource bindingSourceRectangle;
        private System.Windows.Forms.ErrorProvider errorProviderSquare;
        private System.Windows.Forms.ErrorProvider errorProviderRectangle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelEllipseRadiusB;
        private System.Windows.Forms.TextBox textBoxEllipseRadiusB;
        private System.Windows.Forms.Label labelEllipseRadiusA;
        private System.Windows.Forms.Label labelEllipseArea;
        private System.Windows.Forms.TextBox textBoxEllipseArea;
        private System.Windows.Forms.TextBox textBoxEllipseRadiusA;
        private System.Windows.Forms.BindingSource bindingSourceEllipse;
        private System.Windows.Forms.ErrorProvider errorProviderEllipse;
    }
}

