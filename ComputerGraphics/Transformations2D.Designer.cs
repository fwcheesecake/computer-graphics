namespace ComputerGraphics
{
    partial class Transformations2D
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
            this.pointsDataGrid = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canvasLabel = new System.Windows.Forms.Label();
            this.graphicButton = new System.Windows.Forms.Button();
            this.plusZoomButton = new System.Windows.Forms.Button();
            this.minusZoomButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoomLabel = new System.Windows.Forms.Label();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.pathsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transformGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moveRadioButton = new System.Windows.Forms.RadioButton();
            this.rotateRadioButton = new System.Windows.Forms.RadioButton();
            this.scaleRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDataGrid)).BeginInit();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pathsDataGrid)).BeginInit();
            this.transformGroupBox.SuspendLayout();
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
            // pointsDataGrid
            // 
            this.pointsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.xColumn,
            this.yColumn});
            this.pointsDataGrid.Location = new System.Drawing.Point(769, 212);
            this.pointsDataGrid.Name = "pointsDataGrid";
            this.pointsDataGrid.RowTemplate.Height = 25;
            this.pointsDataGrid.Size = new System.Drawing.Size(259, 304);
            this.pointsDataGrid.TabIndex = 10;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
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
            this.graphicButton.Location = new System.Drawing.Point(769, 139);
            this.graphicButton.Name = "graphicButton";
            this.graphicButton.Size = new System.Drawing.Size(112, 37);
            this.graphicButton.TabIndex = 12;
            this.graphicButton.Text = "O P E N   F I L E";
            this.graphicButton.UseVisualStyleBackColor = true;
            this.graphicButton.Click += new System.EventHandler(this.graphicButton_Click);
            // 
            // plusZoomButton
            // 
            this.plusZoomButton.Location = new System.Drawing.Point(976, 183);
            this.plusZoomButton.Name = "plusZoomButton";
            this.plusZoomButton.Size = new System.Drawing.Size(23, 23);
            this.plusZoomButton.TabIndex = 13;
            this.plusZoomButton.Text = "+";
            this.plusZoomButton.UseVisualStyleBackColor = true;
            this.plusZoomButton.Click += new System.EventHandler(this.plusZoomButton_Click);
            // 
            // minusZoomButton
            // 
            this.minusZoomButton.Location = new System.Drawing.Point(1005, 183);
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
            this.zoomLabel.Location = new System.Drawing.Point(890, 187);
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
            // pathsDataGrid
            // 
            this.pathsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pathsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pathsDataGrid.Location = new System.Drawing.Point(769, 522);
            this.pathsDataGrid.Name = "pathsDataGrid";
            this.pathsDataGrid.RowTemplate.Height = 25;
            this.pathsDataGrid.Size = new System.Drawing.Size(259, 304);
            this.pathsDataGrid.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "From";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "To";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // transformGroupBox
            // 
            this.transformGroupBox.Controls.Add(this.textBox3);
            this.transformGroupBox.Controls.Add(this.textBox2);
            this.transformGroupBox.Controls.Add(this.textBox1);
            this.transformGroupBox.Controls.Add(this.label3);
            this.transformGroupBox.Controls.Add(this.label2);
            this.transformGroupBox.Controls.Add(this.label1);
            this.transformGroupBox.Controls.Add(this.moveRadioButton);
            this.transformGroupBox.Controls.Add(this.rotateRadioButton);
            this.transformGroupBox.Controls.Add(this.scaleRadioButton);
            this.transformGroupBox.Location = new System.Drawing.Point(769, 33);
            this.transformGroupBox.Name = "transformGroupBox";
            this.transformGroupBox.Size = new System.Drawing.Size(256, 100);
            this.transformGroupBox.TabIndex = 19;
            this.transformGroupBox.TabStop = false;
            this.transformGroupBox.Text = "Transform";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 23);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 23);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // moveRadioButton
            // 
            this.moveRadioButton.AutoSize = true;
            this.moveRadioButton.Location = new System.Drawing.Point(98, 22);
            this.moveRadioButton.Name = "moveRadioButton";
            this.moveRadioButton.Size = new System.Drawing.Size(55, 19);
            this.moveRadioButton.TabIndex = 2;
            this.moveRadioButton.TabStop = true;
            this.moveRadioButton.Text = "Move";
            this.moveRadioButton.UseVisualStyleBackColor = true;
            // 
            // rotateRadioButton
            // 
            this.rotateRadioButton.AutoSize = true;
            this.rotateRadioButton.Location = new System.Drawing.Point(191, 22);
            this.rotateRadioButton.Name = "rotateRadioButton";
            this.rotateRadioButton.Size = new System.Drawing.Size(59, 19);
            this.rotateRadioButton.TabIndex = 1;
            this.rotateRadioButton.TabStop = true;
            this.rotateRadioButton.Text = "Rotate";
            this.rotateRadioButton.UseVisualStyleBackColor = true;
            // 
            // scaleRadioButton
            // 
            this.scaleRadioButton.AutoSize = true;
            this.scaleRadioButton.Location = new System.Drawing.Point(6, 22);
            this.scaleRadioButton.Name = "scaleRadioButton";
            this.scaleRadioButton.Size = new System.Drawing.Size(52, 19);
            this.scaleRadioButton.TabIndex = 0;
            this.scaleRadioButton.TabStop = true;
            this.scaleRadioButton.Text = "Scale";
            this.scaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "T R A N S F O R M";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transformations2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 793);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transformGroupBox);
            this.Controls.Add(this.pathsDataGrid);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.minusZoomButton);
            this.Controls.Add(this.plusZoomButton);
            this.Controls.Add(this.graphicButton);
            this.Controls.Add(this.canvasLabel);
            this.Controls.Add(this.pointsDataGrid);
            //this.Name = "Transformations2D";
            this.Text = "2D Transformations";
            this.Load += new System.EventHandler(this.Transformations2D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDataGrid)).EndInit();
            this.canvasPanel.ResumeLayout(false);
            this.canvasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pathsDataGrid)).EndInit();
            this.transformGroupBox.ResumeLayout(false);
            this.transformGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox canvasPictureBox;
        private DataGridView pointsDataGrid;
        private Label canvasLabel;
        private Button graphicButton;
        private Button plusZoomButton;
        private Button minusZoomButton;
        private ContextMenuStrip contextMenuStrip1;
        private Label zoomLabel;
        private Panel canvasPanel;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn xColumn;
        private DataGridViewTextBoxColumn yColumn;
        private DataGridView pathsDataGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private GroupBox transformGroupBox;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton moveRadioButton;
        private RadioButton rotateRadioButton;
        private RadioButton scaleRadioButton;
        private Button button1;
    }
}