namespace ComputerGraphics
{
    partial class Fractals
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
            this.canvasPictureBox = new System.Windows.Forms.PictureBox();
            this.canvasLabel = new System.Windows.Forms.Label();
            this.graphicButton = new System.Windows.Forms.Button();
            this.plusZoomButton = new System.Windows.Forms.Button();
            this.minusZoomButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoomLabel = new System.Windows.Forms.Label();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.nNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vicsekDiagonalRadioButton = new System.Windows.Forms.RadioButton();
            this.vicsekSquareRadioButton = new System.Windows.Forms.RadioButton();
            this.vonkochCurveRadioButton = new System.Windows.Forms.RadioButton();
            this.sierpinskiTriangleRadioButton4 = new System.Windows.Forms.RadioButton();
            this.sierpinskiCarpetRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.Location = new System.Drawing.Point(0, 0);
            this.canvasPictureBox.MinimumSize = new System.Drawing.Size(750, 750);
            this.canvasPictureBox.Name = "canvasPictureBox";
            this.canvasPictureBox.Size = new System.Drawing.Size(750, 750);
            this.canvasPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.canvasPictureBox.TabIndex = 0;
            this.canvasPictureBox.TabStop = false;
            // 
            // canvasLabel
            // 
            this.canvasLabel.AutoSize = true;
            this.canvasLabel.Location = new System.Drawing.Point(12, 15);
            this.canvasLabel.Name = "canvasLabel";
            this.canvasLabel.Size = new System.Drawing.Size(89, 15);
            this.canvasLabel.TabIndex = 11;
            this.canvasLabel.Text = "Area de trazado";
            // 
            // graphicButton
            // 
            this.graphicButton.Location = new System.Drawing.Point(768, 64);
            this.graphicButton.Name = "graphicButton";
            this.graphicButton.Size = new System.Drawing.Size(259, 37);
            this.graphicButton.TabIndex = 12;
            this.graphicButton.Text = "D R A W";
            this.graphicButton.UseVisualStyleBackColor = true;
            this.graphicButton.Click += new System.EventHandler(this.graphicButton_Click);
            // 
            // plusZoomButton
            // 
            this.plusZoomButton.Location = new System.Drawing.Point(975, 108);
            this.plusZoomButton.Name = "plusZoomButton";
            this.plusZoomButton.Size = new System.Drawing.Size(23, 23);
            this.plusZoomButton.TabIndex = 13;
            this.plusZoomButton.Text = "+";
            this.plusZoomButton.UseVisualStyleBackColor = true;
            this.plusZoomButton.Click += new System.EventHandler(this.plusZoomButton_Click);
            // 
            // minusZoomButton
            // 
            this.minusZoomButton.Location = new System.Drawing.Point(1004, 108);
            this.minusZoomButton.Name = "minusZoomButton";
            this.minusZoomButton.Size = new System.Drawing.Size(23, 23);
            this.minusZoomButton.TabIndex = 14;
            this.minusZoomButton.Text = "-";
            this.minusZoomButton.UseVisualStyleBackColor = true;
            this.minusZoomButton.Click += new System.EventHandler(this.minusZoomButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(889, 112);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(80, 15);
            this.zoomLabel.TabIndex = 16;
            this.zoomLabel.Text = "Zoom control";
            // 
            // canvasPanel
            // 
            this.canvasPanel.AutoScroll = true;
            this.canvasPanel.Controls.Add(this.canvasPictureBox);
            this.canvasPanel.Location = new System.Drawing.Point(12, 33);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(750, 750);
            this.canvasPanel.TabIndex = 17;
            // 
            // nNumericUpDown
            // 
            this.nNumericUpDown.Location = new System.Drawing.Point(768, 33);
            this.nNumericUpDown.Name = "nNumericUpDown";
            this.nNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.nNumericUpDown.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sierpinskiCarpetRadioButton);
            this.groupBox1.Controls.Add(this.sierpinskiTriangleRadioButton4);
            this.groupBox1.Controls.Add(this.vonkochCurveRadioButton);
            this.groupBox1.Controls.Add(this.vicsekSquareRadioButton);
            this.groupBox1.Controls.Add(this.vicsekDiagonalRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(768, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fractals";
            // 
            // vicsekDiagonalRadioButton
            // 
            this.vicsekDiagonalRadioButton.AutoSize = true;
            this.vicsekDiagonalRadioButton.Location = new System.Drawing.Point(6, 22);
            this.vicsekDiagonalRadioButton.Name = "vicsekDiagonalRadioButton";
            this.vicsekDiagonalRadioButton.Size = new System.Drawing.Size(108, 19);
            this.vicsekDiagonalRadioButton.TabIndex = 0;
            this.vicsekDiagonalRadioButton.TabStop = true;
            this.vicsekDiagonalRadioButton.Text = "Vicsek Diagonal";
            this.vicsekDiagonalRadioButton.UseVisualStyleBackColor = true;
            // 
            // vicsekSquareRadioButton
            // 
            this.vicsekSquareRadioButton.AutoSize = true;
            this.vicsekSquareRadioButton.Location = new System.Drawing.Point(122, 22);
            this.vicsekSquareRadioButton.Name = "vicsekSquareRadioButton";
            this.vicsekSquareRadioButton.Size = new System.Drawing.Size(97, 19);
            this.vicsekSquareRadioButton.TabIndex = 21;
            this.vicsekSquareRadioButton.TabStop = true;
            this.vicsekSquareRadioButton.Text = "Vicsek Square";
            this.vicsekSquareRadioButton.UseVisualStyleBackColor = true;
            // 
            // vonkochCurveRadioButton
            // 
            this.vonkochCurveRadioButton.AutoSize = true;
            this.vonkochCurveRadioButton.Location = new System.Drawing.Point(6, 47);
            this.vonkochCurveRadioButton.Name = "vonkochCurveRadioButton";
            this.vonkochCurveRadioButton.Size = new System.Drawing.Size(109, 19);
            this.vonkochCurveRadioButton.TabIndex = 22;
            this.vonkochCurveRadioButton.TabStop = true;
            this.vonkochCurveRadioButton.Text = "Von Koch Curve";
            this.vonkochCurveRadioButton.UseVisualStyleBackColor = true;
            // 
            // sierpinskiTriangleRadioButton4
            // 
            this.sierpinskiTriangleRadioButton4.AutoSize = true;
            this.sierpinskiTriangleRadioButton4.Location = new System.Drawing.Point(122, 47);
            this.sierpinskiTriangleRadioButton4.Name = "sierpinskiTriangleRadioButton4";
            this.sierpinskiTriangleRadioButton4.Size = new System.Drawing.Size(119, 19);
            this.sierpinskiTriangleRadioButton4.TabIndex = 23;
            this.sierpinskiTriangleRadioButton4.TabStop = true;
            this.sierpinskiTriangleRadioButton4.Text = "Sierpinski Triangle";
            this.sierpinskiTriangleRadioButton4.UseVisualStyleBackColor = true;
            // 
            // sierpinskiCarpetRadioButton
            // 
            this.sierpinskiCarpetRadioButton.AutoSize = true;
            this.sierpinskiCarpetRadioButton.Location = new System.Drawing.Point(6, 72);
            this.sierpinskiCarpetRadioButton.Name = "sierpinskiCarpetRadioButton";
            this.sierpinskiCarpetRadioButton.Size = new System.Drawing.Size(113, 19);
            this.sierpinskiCarpetRadioButton.TabIndex = 24;
            this.sierpinskiCarpetRadioButton.TabStop = true;
            this.sierpinskiCarpetRadioButton.Text = "Sierpinski Carpet";
            this.sierpinskiCarpetRadioButton.UseVisualStyleBackColor = true;
            // 
            // Fractals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 789);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nNumericUpDown);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.minusZoomButton);
            this.Controls.Add(this.plusZoomButton);
            this.Controls.Add(this.graphicButton);
            this.Controls.Add(this.canvasLabel);
            this.Name = "Fractals";
            this.Text = "Fractals";
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            this.canvasPanel.ResumeLayout(false);
            this.canvasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox canvasPictureBox;
        private Label canvasLabel;
        private Button graphicButton;
        private Button plusZoomButton;
        private Button minusZoomButton;
        private ContextMenuStrip contextMenuStrip1;
        private Label zoomLabel;
        private Panel canvasPanel;
        private NumericUpDown nNumericUpDown;
        private GroupBox groupBox1;
        private RadioButton vicsekDiagonalRadioButton;
        private RadioButton sierpinskiCarpetRadioButton;
        private RadioButton sierpinskiTriangleRadioButton4;
        private RadioButton vonkochCurveRadioButton;
        private RadioButton vicsekSquareRadioButton;
    }
}