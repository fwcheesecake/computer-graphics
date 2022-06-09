namespace ComputerGraphics
{
    partial class LineDrawing
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
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.y1TextBox = new System.Windows.Forms.TextBox();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.y2TextBox = new System.Windows.Forms.TextBox();
            this.x1Label = new System.Windows.Forms.Label();
            this.y1Label = new System.Windows.Forms.Label();
            this.x2Label = new System.Windows.Forms.Label();
            this.y2Label = new System.Windows.Forms.Label();
            this.algorithmsGroupBox = new System.Windows.Forms.GroupBox();
            this.bressenhamRadioButton = new System.Windows.Forms.RadioButton();
            this.ddaRadioButton = new System.Windows.Forms.RadioButton();
            this.basicRadioButton = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.canvasLabel = new System.Windows.Forms.Label();
            this.graphicButton = new System.Windows.Forms.Button();
            this.plusZoomButton = new System.Windows.Forms.Button();
            this.minusZoomButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoomLabel = new System.Windows.Forms.Label();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.xColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            this.algorithmsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.canvasPanel.SuspendLayout();
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
            // x1TextBox
            // 
            this.x1TextBox.Location = new System.Drawing.Point(768, 33);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(118, 23);
            this.x1TextBox.TabIndex = 1;
            // 
            // y1TextBox
            // 
            this.y1TextBox.Location = new System.Drawing.Point(909, 33);
            this.y1TextBox.Name = "y1TextBox";
            this.y1TextBox.Size = new System.Drawing.Size(118, 23);
            this.y1TextBox.TabIndex = 2;
            // 
            // x2TextBox
            // 
            this.x2TextBox.Location = new System.Drawing.Point(768, 77);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(118, 23);
            this.x2TextBox.TabIndex = 3;
            // 
            // y2TextBox
            // 
            this.y2TextBox.Location = new System.Drawing.Point(909, 77);
            this.y2TextBox.Name = "y2TextBox";
            this.y2TextBox.Size = new System.Drawing.Size(118, 23);
            this.y2TextBox.TabIndex = 4;
            // 
            // x1Label
            // 
            this.x1Label.AutoSize = true;
            this.x1Label.Location = new System.Drawing.Point(768, 15);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(20, 15);
            this.x1Label.TabIndex = 5;
            this.x1Label.Text = "X1";
            // 
            // y1Label
            // 
            this.y1Label.AutoSize = true;
            this.y1Label.Location = new System.Drawing.Point(909, 15);
            this.y1Label.Name = "y1Label";
            this.y1Label.Size = new System.Drawing.Size(20, 15);
            this.y1Label.TabIndex = 6;
            this.y1Label.Text = "Y1";
            // 
            // x2Label
            // 
            this.x2Label.AutoSize = true;
            this.x2Label.Location = new System.Drawing.Point(768, 59);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(20, 15);
            this.x2Label.TabIndex = 7;
            this.x2Label.Text = "X2";
            // 
            // y2Label
            // 
            this.y2Label.AutoSize = true;
            this.y2Label.Location = new System.Drawing.Point(909, 59);
            this.y2Label.Name = "y2Label";
            this.y2Label.Size = new System.Drawing.Size(20, 15);
            this.y2Label.TabIndex = 8;
            this.y2Label.Text = "Y2";
            // 
            // algorithmsGroupBox
            // 
            this.algorithmsGroupBox.Controls.Add(this.bressenhamRadioButton);
            this.algorithmsGroupBox.Controls.Add(this.ddaRadioButton);
            this.algorithmsGroupBox.Controls.Add(this.basicRadioButton);
            this.algorithmsGroupBox.Location = new System.Drawing.Point(768, 106);
            this.algorithmsGroupBox.Name = "algorithmsGroupBox";
            this.algorithmsGroupBox.Size = new System.Drawing.Size(259, 54);
            this.algorithmsGroupBox.TabIndex = 9;
            this.algorithmsGroupBox.TabStop = false;
            this.algorithmsGroupBox.Text = "Algoritmo";
            // 
            // bressenhamRadioButton
            // 
            this.bressenhamRadioButton.AutoSize = true;
            this.bressenhamRadioButton.Location = new System.Drawing.Point(164, 22);
            this.bressenhamRadioButton.Name = "bressenhamRadioButton";
            this.bressenhamRadioButton.Size = new System.Drawing.Size(89, 19);
            this.bressenhamRadioButton.TabIndex = 2;
            this.bressenhamRadioButton.TabStop = true;
            this.bressenhamRadioButton.Text = "Bressenham";
            this.bressenhamRadioButton.UseVisualStyleBackColor = true;
            // 
            // ddaRadioButton
            // 
            this.ddaRadioButton.AutoSize = true;
            this.ddaRadioButton.Location = new System.Drawing.Point(87, 22);
            this.ddaRadioButton.Name = "ddaRadioButton";
            this.ddaRadioButton.Size = new System.Drawing.Size(49, 19);
            this.ddaRadioButton.TabIndex = 1;
            this.ddaRadioButton.TabStop = true;
            this.ddaRadioButton.Text = "DDA";
            this.ddaRadioButton.UseVisualStyleBackColor = true;
            // 
            // basicRadioButton
            // 
            this.basicRadioButton.AutoSize = true;
            this.basicRadioButton.Location = new System.Drawing.Point(6, 22);
            this.basicRadioButton.Name = "basicRadioButton";
            this.basicRadioButton.Size = new System.Drawing.Size(59, 19);
            this.basicRadioButton.TabIndex = 0;
            this.basicRadioButton.TabStop = true;
            this.basicRadioButton.Text = "Básico";
            this.basicRadioButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xColumn,
            this.yColumn});
            this.dataGridView.Location = new System.Drawing.Point(768, 238);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(259, 304);
            this.dataGridView.TabIndex = 10;
            // 
            // canvasLabel
            // 
            this.canvasLabel.AutoSize = true;
            this.canvasLabel.Location = new System.Drawing.Point(12, 15);
            this.canvasLabel.Name = "canvasLabel";
            this.canvasLabel.Size = new System.Drawing.Size(86, 15);
            this.canvasLabel.TabIndex = 11;
            this.canvasLabel.Text = "Area de trasero";
            // 
            // graphicButton
            // 
            this.graphicButton.Location = new System.Drawing.Point(768, 166);
            this.graphicButton.Name = "graphicButton";
            this.graphicButton.Size = new System.Drawing.Size(259, 37);
            this.graphicButton.TabIndex = 12;
            this.graphicButton.Text = "G R A F I C A R";
            this.graphicButton.UseVisualStyleBackColor = true;
            this.graphicButton.Click += new System.EventHandler(this.graphicButton_Click);
            // 
            // plusZoomButton
            // 
            this.plusZoomButton.Location = new System.Drawing.Point(975, 209);
            this.plusZoomButton.Name = "plusZoomButton";
            this.plusZoomButton.Size = new System.Drawing.Size(23, 23);
            this.plusZoomButton.TabIndex = 13;
            this.plusZoomButton.Text = "+";
            this.plusZoomButton.UseVisualStyleBackColor = true;
            this.plusZoomButton.Click += new System.EventHandler(this.plusZoomButton_Click);
            // 
            // minusZoomButton
            // 
            this.minusZoomButton.Location = new System.Drawing.Point(1004, 209);
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
            this.zoomLabel.Location = new System.Drawing.Point(889, 213);
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
            // xColumn
            // 
            this.xColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xColumn.HeaderText = "X";
            this.xColumn.Name = "xColumn";
            // 
            // yColumn
            // 
            this.yColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yColumn.HeaderText = "Y";
            this.yColumn.Name = "yColumn";
            // 
            // LineDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 793);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.minusZoomButton);
            this.Controls.Add(this.plusZoomButton);
            this.Controls.Add(this.graphicButton);
            this.Controls.Add(this.canvasLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.algorithmsGroupBox);
            this.Controls.Add(this.y2Label);
            this.Controls.Add(this.x2Label);
            this.Controls.Add(this.y1Label);
            this.Controls.Add(this.x1Label);
            this.Controls.Add(this.y2TextBox);
            this.Controls.Add(this.x2TextBox);
            this.Controls.Add(this.y1TextBox);
            this.Controls.Add(this.x1TextBox);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            this.algorithmsGroupBox.ResumeLayout(false);
            this.algorithmsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.canvasPanel.ResumeLayout(false);
            this.canvasPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Name = "LineDrawing";
            this.Text = "Line Drawing";
            this.ResumeLayout(false);
        }

        #endregion

        private PictureBox canvasPictureBox;
        private TextBox x1TextBox;
        private TextBox y1TextBox;
        private TextBox x2TextBox;
        private TextBox y2TextBox;
        private Label x1Label;
        private Label y1Label;
        private Label x2Label;
        private Label y2Label;
        private GroupBox algorithmsGroupBox;
        private RadioButton basicRadioButton;
        private RadioButton bressenhamRadioButton;
        private RadioButton ddaRadioButton;
        private DataGridView dataGridView;
        private Label canvasLabel;
        private Button graphicButton;
        private Button plusZoomButton;
        private Button minusZoomButton;
        private ContextMenuStrip contextMenuStrip1;
        private Label zoomLabel;
        private Panel canvasPanel;
        private DataGridViewTextBoxColumn xColumn;
        private DataGridViewTextBoxColumn yColumn;
    }
}