namespace ComputerGraphics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lineDrawingButton = new System.Windows.Forms.Button();
            this.polygonDrawingButton = new System.Windows.Forms.Button();
            this.transformationsButton = new System.Windows.Forms.Button();
            this.fractalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lineDrawingButton
            // 
            this.lineDrawingButton.Location = new System.Drawing.Point(12, 12);
            this.lineDrawingButton.Name = "lineDrawingButton";
            this.lineDrawingButton.Size = new System.Drawing.Size(250, 50);
            this.lineDrawingButton.TabIndex = 0;
            this.lineDrawingButton.Text = "L I N E   D R A W I N G";
            this.lineDrawingButton.UseVisualStyleBackColor = true;
            this.lineDrawingButton.Click += new System.EventHandler(this.lineDrawingButton_Click);
            // 
            // polygonDrawingButton
            // 
            this.polygonDrawingButton.Location = new System.Drawing.Point(12, 68);
            this.polygonDrawingButton.Name = "polygonDrawingButton";
            this.polygonDrawingButton.Size = new System.Drawing.Size(250, 50);
            this.polygonDrawingButton.TabIndex = 1;
            this.polygonDrawingButton.Text = "P O L Y G O N   D R A W I N G";
            this.polygonDrawingButton.UseVisualStyleBackColor = true;
            this.polygonDrawingButton.Click += new System.EventHandler(this.polygonDrawingButton_Click);
            // 
            // transformationsButton
            // 
            this.transformationsButton.Location = new System.Drawing.Point(12, 124);
            this.transformationsButton.Name = "transformationsButton";
            this.transformationsButton.Size = new System.Drawing.Size(250, 50);
            this.transformationsButton.TabIndex = 2;
            this.transformationsButton.Text = "2 D   A N D   3 D   T R A N S F O R M S ";
            this.transformationsButton.UseVisualStyleBackColor = true;
            this.transformationsButton.Click += new System.EventHandler(this.transformationsButton_Click);
            // 
            // fractalsButton
            // 
            this.fractalsButton.Location = new System.Drawing.Point(12, 180);
            this.fractalsButton.Name = "fractalsButton";
            this.fractalsButton.Size = new System.Drawing.Size(250, 50);
            this.fractalsButton.TabIndex = 3;
            this.fractalsButton.Text = "F R A C T A L S";
            this.fractalsButton.UseVisualStyleBackColor = true;
            this.fractalsButton.Click += new System.EventHandler(this.fractalsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 242);
            this.Controls.Add(this.fractalsButton);
            this.Controls.Add(this.transformationsButton);
            this.Controls.Add(this.polygonDrawingButton);
            this.Controls.Add(this.lineDrawingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button lineDrawingButton;
        private Button polygonDrawingButton;
        private Button transformationsButton;
        private Button fractalsButton;
    }
}